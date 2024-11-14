using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init2112221 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_Personid",
                table: "car");

            migrationBuilder.DropIndex(
                name: "IX_car_Personid",
                table: "car");

            migrationBuilder.DropColumn(
                name: "Personid",
                table: "car");

            migrationBuilder.AddColumn<int>(
                name: "ownerid",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_car_ownerid",
                table: "car",
                column: "ownerid");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_ownerid",
                table: "car",
                column: "ownerid",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_ownerid",
                table: "car");

            migrationBuilder.DropIndex(
                name: "IX_car_ownerid",
                table: "car");

            migrationBuilder.DropColumn(
                name: "ownerid",
                table: "car");

            migrationBuilder.AddColumn<int>(
                name: "Personid",
                table: "car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_Personid",
                table: "car",
                column: "Personid");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_Personid",
                table: "car",
                column: "Personid",
                principalTable: "Persons",
                principalColumn: "id");
        }
    }
}
