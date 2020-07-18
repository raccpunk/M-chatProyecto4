using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class ChangeKeyRespuestas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "IdRespuesta",
                table: "Respuestas");

            migrationBuilder.AddColumn<string>(
                name: "Clave",
                table: "Respuestas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "RespuestasId",
                table: "Cuestionario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas",
                column: "Clave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Clave",
                table: "Respuestas");

            migrationBuilder.AddColumn<int>(
                name: "IdRespuesta",
                table: "Respuestas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "RespuestasId",
                table: "Cuestionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas",
                column: "IdRespuesta");
        }
    }
}
