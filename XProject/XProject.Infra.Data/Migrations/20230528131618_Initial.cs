using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XProject.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: ""),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Views",
                columns: new[] { "Id", "IsVisible", "Name" },
                values: new object[,]
                {
                    { "68d362ad-2775-43ca-ba29-e41512aa45e3", true, "RandomPage" },
                    { "732b776f-44f2-4124-b89a-f9917ae6cbd7", true, "Home" },
                    { "741eb342-f4da-46d7-ae0d-092ab7b9fda6", true, "PageManagement" },
                    { "7b7055f1-600e-4ced-8ab7-51a08cf34407", true, "Privacy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Views");
        }
    }
}
