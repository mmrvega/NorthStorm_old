using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthStorm.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GovernmentalInstituteClassification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernmentalInstituteClassification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GradeNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    GradeAsWriting = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Stage01 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage02 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage03 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage04 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage05 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage06 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage07 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage08 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage09 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage10 = table.Column<int>(type: "INTEGER", nullable: false),
                    Stage11 = table.Column<int>(type: "INTEGER", nullable: false),
                    AnnualBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    MinimumDuration = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitleClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitleClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LevelClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferenceNo = table.Column<string>(type: "TEXT", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recruitments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferenceNo = table.Column<string>(type: "TEXT", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruitments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    KirkukSymbol = table.Column<string>(type: "TEXT", nullable: true),
                    BaghdadSymbol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BasicSalary = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ParentJobTitleId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClassificationId = table.Column<int>(type: "INTEGER", nullable: true),
                    GradeId = table.Column<int>(type: "INTEGER", nullable: true),
                    JobTitleClassificationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTitles_JobTitleClassifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "JobTitleClassifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTitles_JobTitleClassifications_JobTitleClassificationId",
                        column: x => x.JobTitleClassificationId,
                        principalTable: "JobTitleClassifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTitles_JobTitles_ParentJobTitleId",
                        column: x => x.ParentJobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ClassificationId = table.Column<int>(type: "INTEGER", nullable: true),
                    ParentLocationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_LocationClassifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "LocationClassifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_Locations_ParentLocationId",
                        column: x => x.ParentLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FourthName = table.Column<string>(type: "TEXT", nullable: true),
                    SurName = table.Column<string>(type: "TEXT", nullable: true),
                    MotherFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MotherMiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    MotherLastName = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CivilNumber = table.Column<string>(type: "TEXT", nullable: true),
                    IBAN = table.Column<string>(type: "TEXT", nullable: true),
                    GenderId = table.Column<int>(type: "INTEGER", nullable: true),
                    ReligionId = table.Column<int>(type: "INTEGER", nullable: true),
                    RaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    NationalityId = table.Column<int>(type: "INTEGER", nullable: true),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: true),
                    RecruitmentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Recruitments_RecruitmentId",
                        column: x => x.RecruitmentId,
                        principalTable: "Recruitments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GovernmentalInstitutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ClassificationId = table.Column<int>(type: "INTEGER", nullable: true),
                    ParentGovernmentalInstituteId = table.Column<int>(type: "INTEGER", nullable: true),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GovernmentalInstitutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GovernmentalInstitutes_GovernmentalInstituteClassification_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "GovernmentalInstituteClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GovernmentalInstitutes_GovernmentalInstitutes_ParentGovernmentalInstituteId",
                        column: x => x.ParentGovernmentalInstituteId,
                        principalTable: "GovernmentalInstitutes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GovernmentalInstitutes_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ParentLevelId = table.Column<int>(type: "INTEGER", nullable: true),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClassificationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Levels_LevelClassifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "LevelClassifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Levels_Levels_ParentLevelId",
                        column: x => x.ParentLevelId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Levels_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobTitleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferenceNo = table.Column<string>(type: "TEXT", nullable: true),
                    ReferenceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JobTitleAssignedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeJobTitles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeJobTitles_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeePromotion",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PromotionsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePromotion", x => new { x.EmployeesId, x.PromotionsId });
                    table.ForeignKey(
                        name: "FK_EmployeePromotion_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeePromotion_Promotions_PromotionsId",
                        column: x => x.PromotionsId,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalary",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalariesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalary", x => new { x.EmployeesId, x.SalariesId });
                    table.ForeignKey(
                        name: "FK_EmployeeSalary_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeSalary_Salary_SalariesId",
                        column: x => x.SalariesId,
                        principalTable: "Salary",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Degree = table.Column<string>(type: "TEXT", nullable: false),
                    GlobalSpecialization = table.Column<string>(type: "TEXT", nullable: false),
                    AccurateSpecialization = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    UniversityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_GovernmentalInstitutes_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "GovernmentalInstitutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLevel",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLevel", x => new { x.EmployeesId, x.LevelsId });
                    table.ForeignKey(
                        name: "FK_EmployeeLevel_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeLevel_Levels_LevelsId",
                        column: x => x.LevelsId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobTitleLevel",
                columns: table => new
                {
                    JobTitlesId = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitleLevel", x => new { x.JobTitlesId, x.LevelsId });
                    table.ForeignKey(
                        name: "FK_JobTitleLevel_JobTitles_JobTitlesId",
                        column: x => x.JobTitlesId,
                        principalTable: "JobTitles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTitleLevel_Levels_LevelsId",
                        column: x => x.LevelsId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferenceNo = table.Column<string>(type: "TEXT", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    DestinationLevelId = table.Column<int>(type: "INTEGER", nullable: true),
                    LevelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTransfers_Levels_DestinationLevelId",
                        column: x => x.DestinationLevelId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTransfers_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CertificateEmployee",
                columns: table => new
                {
                    CertificatesId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateEmployee", x => new { x.CertificatesId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_CertificateEmployee_Certificates_CertificatesId",
                        column: x => x.CertificatesId,
                        principalTable: "Certificates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CertificateEmployee_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobTransfer",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobTransfersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobTransfer", x => new { x.EmployeesId, x.JobTransfersId });
                    table.ForeignKey(
                        name: "FK_EmployeeJobTransfer_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeJobTransfer_JobTransfers_JobTransfersId",
                        column: x => x.JobTransfersId,
                        principalTable: "JobTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificateEmployee_EmployeesId",
                table: "CertificateEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_UniversityId",
                table: "Certificates",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobTitles_EmployeeId",
                table: "EmployeeJobTitles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobTitles_JobTitleId",
                table: "EmployeeJobTitles",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobTransfer_JobTransfersId",
                table: "EmployeeJobTransfer",
                column: "JobTransfersId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLevel_LevelsId",
                table: "EmployeeLevel",
                column: "LevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotion_PromotionsId",
                table: "EmployeePromotion",
                column: "PromotionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RaceId",
                table: "Employees",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RecruitmentId",
                table: "Employees",
                column: "RecruitmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReligionId",
                table: "Employees",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StatusId",
                table: "Employees",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalary_SalariesId",
                table: "EmployeeSalary",
                column: "SalariesId");

            migrationBuilder.CreateIndex(
                name: "IX_GovernmentalInstitutes_ClassificationId",
                table: "GovernmentalInstitutes",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_GovernmentalInstitutes_LocationId",
                table: "GovernmentalInstitutes",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GovernmentalInstitutes_ParentGovernmentalInstituteId",
                table: "GovernmentalInstitutes",
                column: "ParentGovernmentalInstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitleLevel_LevelsId",
                table: "JobTitleLevel",
                column: "LevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_ClassificationId",
                table: "JobTitles",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_GradeId",
                table: "JobTitles",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_JobTitleClassificationId",
                table: "JobTitles",
                column: "JobTitleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_ParentJobTitleId",
                table: "JobTitles",
                column: "ParentJobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTransfers_DestinationLevelId",
                table: "JobTransfers",
                column: "DestinationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTransfers_LevelId",
                table: "JobTransfers",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_ClassificationId",
                table: "Levels",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_LocationId",
                table: "Levels",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_ParentLevelId",
                table: "Levels",
                column: "ParentLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ClassificationId",
                table: "Locations",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParentLocationId",
                table: "Locations",
                column: "ParentLocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateEmployee");

            migrationBuilder.DropTable(
                name: "EmployeeJobTitles");

            migrationBuilder.DropTable(
                name: "EmployeeJobTransfer");

            migrationBuilder.DropTable(
                name: "EmployeeLevel");

            migrationBuilder.DropTable(
                name: "EmployeePromotion");

            migrationBuilder.DropTable(
                name: "EmployeeSalary");

            migrationBuilder.DropTable(
                name: "JobTitleLevel");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "JobTransfers");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "GovernmentalInstitutes");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Recruitments");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "JobTitleClassifications");

            migrationBuilder.DropTable(
                name: "GovernmentalInstituteClassification");

            migrationBuilder.DropTable(
                name: "LevelClassifications");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "LocationClassifications");
        }
    }
}
