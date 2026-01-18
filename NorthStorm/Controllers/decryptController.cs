using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace NorthStorm.Controllers
{
    public class decryptController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public decryptController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Decodes the scrambled number by applying the XOR key again.
        /// </summary>
        private string ScrambleDecode(int scrambled, int key)
        {
            int decoded = scrambled ^ key;
            return decoded.ToString();
        }

        [HttpPost]
        public IActionResult DecodeWatermark(IFormFile imageFile)
        {
            try
            {
                int secretKey = 42324;
                string inputPath;

                // Use uploaded file or default image
                if (imageFile != null && imageFile.Length > 0)
                {
                    // Save uploaded file to temp location
                    string tempPath = Path.Combine(_webHostEnvironment.WebRootPath, "temp");
                    if (!Directory.Exists(tempPath))
                        Directory.CreateDirectory(tempPath);

                    inputPath = Path.Combine(tempPath, Guid.NewGuid() + Path.GetExtension(imageFile.FileName));
                    
                    using (var stream = new FileStream(inputPath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                }
                else
                {
                    // Use default image
                    string imagesFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    inputPath = Path.Combine(imagesFolder, "book_watermarked.jpg");

                    if (!System.IO.File.Exists(inputPath))
                    {
                        return Json(new Dictionary<string, object> { { "success", false }, { "message", "Watermarked image not found." } });
                    }
                }

                // Define the matrix parameters to scan (must match the encoder's logic)
                List<int> xPoints = new List<int>();
                for (int x = 23; x <= 700; x += 100) xPoints.Add(x);

                List<int> yPoints = new List<int>();
                for (int y = 280; y <= 650; y += 10) yPoints.Add(y);

                // Scanning parameters
                float lineLength = 100f;
                
                string finalDecodedText = null;
                string binaryData = null;
                int foundX = 0;
                int foundY = 0;

                using (var bitmap = new Bitmap(inputPath))
                {
                    foreach (int startY in yPoints)
                    {
                        foreach (int startX in xPoints)
                        {
                            string binary = ScanArea(bitmap, startX, startY, lineLength);

                            if (binary != null && binary.StartsWith("010"))
                            {
                                // Remove the "010" prefix
                                string rawBinary = binary.Substring(3);
                                
                                // Try to decode the remaining binary
                                string result = TryDecodeBinary(rawBinary, secretKey);

                                if (result != null && result.All(char.IsDigit))
                                {
                                    finalDecodedText = result;
                                    binaryData = binary;
                                    foundX = startX;
                                    foundY = startY;
                                    goto Found;
                                }
                            }
                        }
                    }
                }

                return Json(new Dictionary<string, object> { { "success", false }, { "message", "Watermark not detected in any matrix area." } });

            Found:
                Console.WriteLine($"[DECODER] Successfully found watermark at ({foundX}, {foundY})");
                Console.WriteLine($"[DECODER] Decoded Number: {finalDecodedText}");
                
                // Clean up temp file if it was uploaded
                if (imageFile != null && System.IO.File.Exists(inputPath))
                {
                    try { System.IO.File.Delete(inputPath); } catch { }
                }
                
                var response = new Dictionary<string, object>
                {
                    { "success", true },
                    { "message", "Watermark decoded successfully!" },
                    { "decodedText", finalDecodedText },
                    { "binary", binaryData },
                    { "decodedNumber", finalDecodedText },
                    { "locationX", foundX },
                    { "locationY", foundY }
                };
                
                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(new Dictionary<string, object> { { "success", false }, { "message", $"Decoding Error: {ex.Message}" } });
            }
        }

        private string ScanArea(Bitmap bitmap, int startX, int startY, float length)
        {
            // The encoder used 3 bits prefix + roughly 40-48 bits (for 5-6 chars)
            // total bits = 3 + (8 * stringLength). For a number like 22201 ^ 42324 = 60461 (5 chars -> 40 bits).
            // Total = 43 bits.
            int bitsToScan = 43; 
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bitsToScan; i++)
            {
                float ratio = (i + 0.5f) / bitsToScan;
                int px = (int)(startX + (length * ratio));
                int py = startY;

                if (px < 0 || px >= bitmap.Width || py < 0 || py >= bitmap.Height) return null;

                Color pixel = bitmap.GetPixel(px, py);
                
                // Encoder Logic: 
                // 1 = Black Circle (Ellipse) -> Look for black
                // 0 = White Square (Rectangle) -> Look for white (or brightness)
                // The background is also white, so we distinguish based on the shapes' brightness.
                
                // If brightness is very low, it's black (the Circle/Bit 1)
                if (pixel.GetBrightness() < 0.3f)
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
            }
            return sb.ToString();
        }

        private string TryDecodeBinary(string binary, int key)
        {
            try
            {
                List<byte> bytes = new List<byte>();
                // Process in chunks of 8
                for (int i = 0; i < binary.Length; i += 8)
                {
                    if (i + 8 <= binary.Length)
                    {
                        string bitGroup = binary.Substring(i, 8);
                        bytes.Add(Convert.ToByte(bitGroup, 2));
                    }
                }

                string scrambledStr = Encoding.ASCII.GetString(bytes.ToArray());
                
                // Clean up non-numeric characters if any
                string cleanScrambled = new string(scrambledStr.Where(char.IsDigit).ToArray());

                if (int.TryParse(cleanScrambled, out int scrambledNum))
                {
                    return ScrambleDecode(scrambledNum, key);
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}