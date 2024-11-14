using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init213333445671298 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car");

            migrationBuilder.DropIndex(
                name: "IX_car_person_id",
                table: "car");

            migrationBuilder.DropColumn(
                name: "person_id",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "car",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "modelYear",
                table: "car",
                newName: "ModelYear");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "car",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_car_OwnerId",
                table: "car",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_OwnerId",
                table: "car",
                column: "OwnerId",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_OwnerId",
                table: "car");

            migrationBuilder.DropIndex(
                name: "IX_car_OwnerId",
                table: "car");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "car");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "car",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "car",
                newName: "modelYear");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "car",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "person_id",
                table: "car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_person_id",
                table: "car",
                column: "person_id");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car",
                column: "person_id",
                principalTable: "Persons",
                principalColumn: "id");
        }
    }
}
