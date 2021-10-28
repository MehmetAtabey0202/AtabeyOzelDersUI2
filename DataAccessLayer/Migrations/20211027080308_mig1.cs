using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationAreaTypes",
                columns: table => new
                {
                    EducationAreaType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationAreaType_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationAreaType_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationAreaTypes", x => x.EducationAreaType_ID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCenters",
                columns: table => new
                {
                    GeneralCenter_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_ID = table.Column<int>(type: "int", nullable: false),
                    Area_ID = table.Column<int>(type: "int", nullable: false),
                    District_ID = table.Column<int>(type: "int", nullable: false),
                    Province_ID = table.Column<int>(type: "int", nullable: false),
                    GeneralCenter_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCenters", x => x.GeneralCenter_ID);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Profession_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profession_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Profession_ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralCenter_ID = table.Column<int>(type: "int", nullable: true),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doual_Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Kod = table.Column<int>(type: "int", nullable: false),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_ID);
                    table.ForeignKey(
                        name: "FK_Countries_GeneralCenters_GeneralCenter_ID",
                        column: x => x.GeneralCenter_ID,
                        principalTable: "GeneralCenters",
                        principalColumn: "GeneralCenter_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralCenter_ID = table.Column<int>(type: "int", nullable: true),
                    Department_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Department_ID);
                    table.ForeignKey(
                        name: "FK_Departments_GeneralCenters_GeneralCenter_ID",
                        column: x => x.GeneralCenter_ID,
                        principalTable: "GeneralCenters",
                        principalColumn: "GeneralCenter_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Area_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_ID = table.Column<int>(type: "int", nullable: true),
                    Area_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Area_ID);
                    table.ForeignKey(
                        name: "FK_Areas_Countries_Country_ID",
                        column: x => x.Country_ID,
                        principalTable: "Countries",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Province_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area_ID = table.Column<int>(type: "int", nullable: true),
                    Province_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Province_ID);
                    table.ForeignKey(
                        name: "FK_Provinces_Areas_Area_ID",
                        column: x => x.Area_ID,
                        principalTable: "Areas",
                        principalColumn: "Area_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    District_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Province_ID = table.Column<int>(type: "int", nullable: true),
                    District_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.District_ID);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_Province_ID",
                        column: x => x.Province_ID,
                        principalTable: "Provinces",
                        principalColumn: "Province_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    District_ID = table.Column<int>(type: "int", nullable: true),
                    Province_ID = table.Column<int>(type: "int", nullable: true),
                    Department_ID = table.Column<int>(type: "int", nullable: true),
                    Profession_ID = table.Column<int>(type: "int", nullable: true),
                    Employee_Name = table.Column<int>(type: "int", nullable: false),
                    Employee_Surname = table.Column<int>(type: "int", nullable: false),
                    Employee_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Departments",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Districts_District_ID",
                        column: x => x.District_ID,
                        principalTable: "Districts",
                        principalColumn: "District_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Professions_Profession_ID",
                        column: x => x.Profession_ID,
                        principalTable: "Professions",
                        principalColumn: "Profession_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Provinces_Province_ID",
                        column: x => x.Province_ID,
                        principalTable: "Provinces",
                        principalColumn: "Province_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Season_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_ID = table.Column<int>(type: "int", nullable: true),
                    Season_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Season_Kode = table.Column<int>(type: "int", nullable: false),
                    Season_WeekOfNumber = table.Column<int>(type: "int", nullable: false),
                    Minimum_Advance_Rate = table.Column<int>(type: "int", nullable: false),
                    Max_Installment = table.Column<int>(type: "int", nullable: false),
                    Season_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Season_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Season_StartOfEdication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Season_End_Installment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Season_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Season_ID);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    District_ID = table.Column<int>(type: "int", nullable: true),
                    Province_ID = table.Column<int>(type: "int", nullable: true),
                    Branch_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice_Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_ID = table.Column<int>(type: "int", nullable: false),
                    Province_PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Province_PhoneNumber2 = table.Column<int>(type: "int", nullable: false),
                    Branch_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch_Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance_Learning = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Employee_ID1 = table.Column<int>(type: "int", nullable: true),
                    Season_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_ID);
                    table.ForeignKey(
                        name: "FK_Branches_Districts_District_ID",
                        column: x => x.District_ID,
                        principalTable: "Districts",
                        principalColumn: "District_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Employees_Employee_ID1",
                        column: x => x.Employee_ID1,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Provinces_Province_ID",
                        column: x => x.Province_ID,
                        principalTable: "Provinces",
                        principalColumn: "Province_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Seasons_Season_ID",
                        column: x => x.Season_ID,
                        principalTable: "Seasons",
                        principalColumn: "Season_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationAreas",
                columns: table => new
                {
                    EducationArea_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Season_ID = table.Column<int>(type: "int", nullable: true),
                    EducationAreaType_ID = table.Column<int>(type: "int", nullable: true),
                    EducationArea_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationArea_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy_ID = table.Column<int>(type: "int", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationAreas", x => x.EducationArea_ID);
                    table.ForeignKey(
                        name: "FK_EducationAreas_EducationAreaTypes_EducationAreaType_ID",
                        column: x => x.EducationAreaType_ID,
                        principalTable: "EducationAreaTypes",
                        principalColumn: "EducationAreaType_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationAreas_Seasons_Season_ID",
                        column: x => x.Season_ID,
                        principalTable: "Seasons",
                        principalColumn: "Season_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Country_ID",
                table: "Areas",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_District_ID",
                table: "Branches",
                column: "District_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Employee_ID1",
                table: "Branches",
                column: "Employee_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Province_ID",
                table: "Branches",
                column: "Province_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Season_ID",
                table: "Branches",
                column: "Season_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GeneralCenter_ID",
                table: "Countries",
                column: "GeneralCenter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_GeneralCenter_ID",
                table: "Departments",
                column: "GeneralCenter_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_Province_ID",
                table: "Districts",
                column: "Province_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EducationAreas_EducationAreaType_ID",
                table: "EducationAreas",
                column: "EducationAreaType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EducationAreas_Season_ID",
                table: "EducationAreas",
                column: "Season_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Department_ID",
                table: "Employees",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_District_ID",
                table: "Employees",
                column: "District_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Profession_ID",
                table: "Employees",
                column: "Profession_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Province_ID",
                table: "Employees",
                column: "Province_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_Area_ID",
                table: "Provinces",
                column: "Area_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_Branch_ID",
                table: "Seasons",
                column: "Branch_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Branches_Branch_ID",
                table: "Seasons",
                column: "Branch_ID",
                principalTable: "Branches",
                principalColumn: "Branch_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Countries_Country_ID",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Districts_District_ID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Districts_District_ID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Employees_Employee_ID1",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Provinces_Province_ID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Seasons_Season_ID",
                table: "Branches");

            migrationBuilder.DropTable(
                name: "EducationAreas");

            migrationBuilder.DropTable(
                name: "EducationAreaTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "GeneralCenters");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
