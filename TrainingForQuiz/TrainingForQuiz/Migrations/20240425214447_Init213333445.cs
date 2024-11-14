using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForQuiz.Migrations
{
    /// <inheritdoc />
    public partial class Init213333445 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "car");

            migrationBuilder.AlterColumn<int>(
                name: "person_id",
                table: "car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car",
                column: "person_id",
                principalTable: "Persons",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car");

            migrationBuilder.AlterColumn<int>(
                name: "person_id",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Owner",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_car_Persons_person_id",
                table: "car",
                column: "person_id",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
