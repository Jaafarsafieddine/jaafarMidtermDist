using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init21333344 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Owner",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "car");
        }
    }
}
