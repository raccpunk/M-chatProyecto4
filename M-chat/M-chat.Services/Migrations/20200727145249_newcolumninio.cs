using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class newcolumninio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuestionario_Ninio_NinioCurp",
                table: "Cuestionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnostico_Ninio_NinioCurp",
                table: "Diagnostico");

            migrationBuilder.DropIndex(
                name: "IX_Diagnostico_NinioCurp",
                table: "Diagnostico");

            migrationBuilder.DropIndex(
                name: "IX_Cuestionario_NinioCurp",
                table: "Cuestionario");

            migrationBuilder.DropColumn(
                name: "NinioCurp",
                table: "Diagnostico");

            migrationBuilder.DropColumn(
                name: "NinioCurp",
                table: "Cuestionario");

            migrationBuilder.AddColumn<bool>(
                name: "diagnotiscado",
                table: "Ninio",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diagnotiscado",
                table: "Ninio");

            migrationBuilder.AddColumn<string>(
                name: "NinioCurp",
                table: "Diagnostico",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NinioCurp",
                table: "Cuestionario",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_NinioCurp",
                table: "Diagnostico",
                column: "NinioCurp");

            migrationBuilder.CreateIndex(
                name: "IX_Cuestionario_NinioCurp",
                table: "Cuestionario",
                column: "NinioCurp");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuestionario_Ninio_NinioCurp",
                table: "Cuestionario",
                column: "NinioCurp",
                principalTable: "Ninio",
                principalColumn: "Curp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnostico_Ninio_NinioCurp",
                table: "Diagnostico",
                column: "NinioCurp",
                principalTable: "Ninio",
                principalColumn: "Curp",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
