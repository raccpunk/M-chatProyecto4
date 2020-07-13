using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class newcolums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuestionario_Ninio_ninioCurp",
                table: "Cuestionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuestionario_Tutor_tutorEmail",
                table: "Cuestionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Ninio_CentroEducativo_centroEducativoClave",
                table: "Ninio");

            migrationBuilder.DropForeignKey(
                name: "FK_Ninio_Tutor_tutorEmail",
                table: "Ninio");

            migrationBuilder.DropForeignKey(
                name: "FK_Respuestas_Cuestionario_CuestionarioIdCuestionario",
                table: "Respuestas");

            migrationBuilder.DropIndex(
                name: "IX_Respuestas_CuestionarioIdCuestionario",
                table: "Respuestas");

            migrationBuilder.DropIndex(
                name: "IX_Ninio_centroEducativoClave",
                table: "Ninio");

            migrationBuilder.DropIndex(
                name: "IX_Ninio_tutorEmail",
                table: "Ninio");

            migrationBuilder.DropIndex(
                name: "IX_Cuestionario_tutorEmail",
                table: "Cuestionario");

            migrationBuilder.DropColumn(
                name: "CuestionarioIdCuestionario",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "centroEducativoClave",
                table: "Ninio");

            migrationBuilder.DropColumn(
                name: "tutorEmail",
                table: "Ninio");

            migrationBuilder.DropColumn(
                name: "tutorEmail",
                table: "Cuestionario");

            migrationBuilder.RenameColumn(
                name: "ninioCurp",
                table: "Cuestionario",
                newName: "NinioCurp");

            migrationBuilder.RenameIndex(
                name: "IX_Cuestionario_ninioCurp",
                table: "Cuestionario",
                newName: "IX_Cuestionario_NinioCurp");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta1",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta10",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta11",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta12",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta13",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta14",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta15",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta16",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta17",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta18",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta19",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta2",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta20",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta21",
                table: "Respuestas",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Respuesta22",
                table: "Respuestas",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Respuesta23",
                table: "Respuestas",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Respuesta3",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta4",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta5",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta6",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta7",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta8",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Respuesta9",
                table: "Respuestas",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ninio",
                table: "Respuestas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RespuestasId",
                table: "Cuestionario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuestionario_Ninio_NinioCurp",
                table: "Cuestionario",
                column: "NinioCurp",
                principalTable: "Ninio",
                principalColumn: "Curp",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuestionario_Ninio_NinioCurp",
                table: "Cuestionario");

            migrationBuilder.DropColumn(
                name: "Respuesta1",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta10",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta11",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta12",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta13",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta14",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta15",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta16",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta17",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta18",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta19",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta2",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta20",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta21",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta22",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta23",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta3",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta4",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta5",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta6",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta7",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta8",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "Respuesta9",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "ninio",
                table: "Respuestas");

            migrationBuilder.DropColumn(
                name: "RespuestasId",
                table: "Cuestionario");

            migrationBuilder.RenameColumn(
                name: "NinioCurp",
                table: "Cuestionario",
                newName: "ninioCurp");

            migrationBuilder.RenameIndex(
                name: "IX_Cuestionario_NinioCurp",
                table: "Cuestionario",
                newName: "IX_Cuestionario_ninioCurp");

            migrationBuilder.AddColumn<int>(
                name: "CuestionarioIdCuestionario",
                table: "Respuestas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Respuesta",
                table: "Respuestas",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "centroEducativoClave",
                table: "Ninio",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tutorEmail",
                table: "Ninio",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tutorEmail",
                table: "Cuestionario",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Respuestas_CuestionarioIdCuestionario",
                table: "Respuestas",
                column: "CuestionarioIdCuestionario");

            migrationBuilder.CreateIndex(
                name: "IX_Ninio_centroEducativoClave",
                table: "Ninio",
                column: "centroEducativoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Ninio_tutorEmail",
                table: "Ninio",
                column: "tutorEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Cuestionario_tutorEmail",
                table: "Cuestionario",
                column: "tutorEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuestionario_Ninio_ninioCurp",
                table: "Cuestionario",
                column: "ninioCurp",
                principalTable: "Ninio",
                principalColumn: "Curp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuestionario_Tutor_tutorEmail",
                table: "Cuestionario",
                column: "tutorEmail",
                principalTable: "Tutor",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ninio_CentroEducativo_centroEducativoClave",
                table: "Ninio",
                column: "centroEducativoClave",
                principalTable: "CentroEducativo",
                principalColumn: "Clave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ninio_Tutor_tutorEmail",
                table: "Ninio",
                column: "tutorEmail",
                principalTable: "Tutor",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Respuestas_Cuestionario_CuestionarioIdCuestionario",
                table: "Respuestas",
                column: "CuestionarioIdCuestionario",
                principalTable: "Cuestionario",
                principalColumn: "IdCuestionario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
