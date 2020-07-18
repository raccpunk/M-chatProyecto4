using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class newcolumindiagnostic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ninio",
                table: "Diagnostico",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ninio",
                table: "Diagnostico");
        }
    }
}
