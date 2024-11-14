using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init213333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_ownerid",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "ownerid",
                table: "car",
                newName: "person_id");

            migrationBuilder.RenameIndex(
                name: "IX_car_ownerid",
                table: "car",
                newName: "IX_car_person_id");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car",
                column: "person_id",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "person_id",
                table: "car",
                newName: "ownerid");

            migrationBuilder.RenameIndex(
                name: "IX_car_person_id",
                table: "car",
                newName: "IX_car_ownerid");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_ownerid",
                table: "car",
                column: "ownerid",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
