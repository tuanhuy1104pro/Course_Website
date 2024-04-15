using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastrucure.Migrations
{
    /// <inheritdoc />
    public partial class Initial_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursePrice = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91", "IT" },
                    { "CA834AA4-7F87-4DF5-A29E-A856071BE701", "History" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CategoryId", "CourseDescription", "CourseName", "CoursePrice" },
                values: new object[,]
                {
                    { 1, "CA834AA4-7F87-4DF5-A29E-A856071BE701", "escriven0", "ecollingridge0", 74.0 },
                    { 2, "CA834AA4-7F87-4DF5-A29E-A856071BE701", "ejeavon1", "wgreenstreet1", 90.0 },
                    { 3, "CA834AA4-7F87-4DF5-A29E-A856071BE701", "cprendergast2", "hhockey2", 76.0 },
                    { 4, "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91", "mbuckleigh3", "kfaichnie3", 24.0 },
                    { 5, "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91", "nwholesworth4", "pchristofle4", 64.0 },
                    { 6, "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91", "emilier5", "lcovelle5", 95.0 },
                    { 7, "CA834AA4-7F87-4DF5-A29E-A856071BE701", "rheino6", "dfranzel6", 86.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
