using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class newcolumndiagnostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Criticas",
                table: "Diagnostico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Normales",
                table: "Diagnostico",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Criticas",
                table: "Diagnostico");

            migrationBuilder.DropColumn(
                name: "Normales",
                table: "Diagnostico");
        }
    }
}
