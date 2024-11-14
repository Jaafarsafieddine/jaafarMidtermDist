using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init213333445671298009988 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_OwnerId",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "car",
                newName: "person_Id");

            migrationBuilder.RenameIndex(
                name: "IX_car_OwnerId",
                table: "car",
                newName: "IX_car_person_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_person_Id",
                table: "car",
                column: "person_Id",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_person_Id",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "person_Id",
                table: "car",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_car_person_Id",
                table: "car",
                newName: "IX_car_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_OwnerId",
                table: "car",
                column: "OwnerId",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
