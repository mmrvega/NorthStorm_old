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
    public class encryptController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public encryptController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string ScrambleNumber(int inputNum, int key)
        {
            int scrambled = inputNum ^ key;
            return scrambled.ToString();
        }

        public IActionResult AddWatermark()
        {
            try
            {
                //the information begins here
                int myNumber = 22201;
                int secretKey = 42324;

                string imagesFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string inputPath = Path.Combine(imagesFolder, "mage2.jpg");
                string outputPath = Path.Combine(imagesFolder, "book_watermarked.jpg");
                //=================================================

                if (!System.IO.File.Exists(inputPath))
                {
                    return Json(new { success = false, message = "Source image not found in wwwroot/images/" });
                }

                using (var originalImage = Image.FromFile(inputPath))
                using (var bitmap = new Bitmap(originalImage.Width, originalImage.Height))
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawImage(originalImage, 0, 0);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    // Scramble logic
                    string textToEncode = ScrambleNumber(myNumber, secretKey);
                    byte[] bytes = Encoding.ASCII.GetBytes(textToEncode);
                    
                    // Get original binary
                    string rawBinaryString = string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
                    
                    // Add the "010" prefix
                    string fullBinaryString = "010" + rawBinaryString;

                    // --- MATRIX LOGIC START ---
                    // Generate all possible X and Y coordinates based on your rules
                    List<int> xPoints = new List<int>();
                    for (int x = 23; x <= 700; x += 100) xPoints.Add(x);

                    List<int> yPoints = new List<int>();
                    for (int y = 280; y <= 650; y += 10) yPoints.Add(y);

                    // Pick a random point from the matrix for the start of the line
                    Random rand = new Random();
                    float startX = xPoints[rand.Next(xPoints.Count)];
                    float startY = yPoints[rand.Next(yPoints.Count)];
                    
                    // Define the length of the line (e.g., 100 pixels wide)
                    float endX = startX + 100f; 
                    float endY = startY; 
                    // --- MATRIX LOGIC END ---

                    float diffX = endX - startX;
                    float diffY = endY - startY;
                    int totalBits = fullBinaryString.Length;

                    // Prepare pens for drawing
                    using (Pen whiteBgPen = new Pen(Color.White, 5)) // Background pen slightly wider
                    using (Pen whitePen = new Pen(Color.White, 3))
                    using (Pen blackPen = new Pen(Color.Black, 3))
                    {
                        // Draw a solid white line first as the background
                        graphics.DrawLine(whiteBgPen, startX, startY, endX, endY);

                        for (int i = 0; i < totalBits; i++)
                        {
                            // Calculate segment start and end coordinates
                            float ratioStart = (float)i / totalBits;
                            float ratioEnd = (float)(i + 1) / totalBits;

                            float segStartX = startX + (diffX * ratioStart);
                            float segStartY = startY + (diffY * ratioStart);
                            float segEndX = startX + (diffX * ratioEnd);
                            float segEndY = startY + (diffY * ratioEnd);

                            if (fullBinaryString[i] == '1')
                            {
                                graphics.DrawLine(blackPen, segStartX, segStartY, segEndX, segEndY);
                            }
                            else // it is '0'
                            {
                                graphics.DrawLine(whitePen, segStartX, segStartY, segEndX, segEndY);
                            }
                        }
                    }

                    bitmap.Save(outputPath, ImageFormat.Jpeg);

                    // Print to server log
                    Console.WriteLine("=== Watermark Encoding Log ===");
                    Console.WriteLine($"Original Number: {myNumber}");
                    Console.WriteLine($"Scrambled (Real) Number: {textToEncode}");
                    Console.WriteLine($"Binary Data: {rawBinaryString}");
                    Console.WriteLine($"Full Binary (with 010 prefix): {fullBinaryString}");
                    Console.WriteLine($"Coordinates: X={startX}, Y={startY}");
                    Console.WriteLine("==============================");

                    return Json(new
                    {
                        success = true,
                        message = $"Line drawn at random matrix point ({startX}, {startY})",
                        originalNumber = myNumber,
                        scrambledNumber = textToEncode,
                        originalBinary = rawBinaryString,
                        encodedBinaryWithPrefix = fullBinaryString,
                        coords = new { x = startX, y = startY }
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Processing Error: {ex.Message}" });
            }
        }
    }
}