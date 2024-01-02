using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2task.Server.Migrations
{
    /// <inheritdoc />
    public partial class Yasir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiabetesInputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Hypertension = table.Column<bool>(type: "bit", nullable: false),
                    HeartDisease = table.Column<bool>(type: "bit", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    HbA1cLevel = table.Column<double>(type: "float", nullable: false),
                    BloodGlucose = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabetesInputs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiabetesInputs");
        }
    }
}
