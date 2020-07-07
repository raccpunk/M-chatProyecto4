using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M_chat.Services.Migrations
{
    public partial class TablasRecreadascondatanotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentroEducativo",
                columns: table => new
                {
                    Clave = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    NivelEducativo = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Representante = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroEducativo", x => x.Clave);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Contrasenia = table.Column<string>(maxLength: 20, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(nullable: false),
                    Curp = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Ninio",
                columns: table => new
                {
                    Curp = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    tutorEmail = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    ClaveEscuela = table.Column<string>(nullable: false),
                    centroEducativoClave = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninio", x => x.Curp);
                    table.ForeignKey(
                        name: "FK_Ninio_CentroEducativo_centroEducativoClave",
                        column: x => x.centroEducativoClave,
                        principalTable: "CentroEducativo",
                        principalColumn: "Clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ninio_Tutor_tutorEmail",
                        column: x => x.tutorEmail,
                        principalTable: "Tutor",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuestionario",
                columns: table => new
                {
                    IdCuestionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAplicacion = table.Column<DateTime>(nullable: false),
                    Curpninio = table.Column<string>(nullable: false),
                    ninioCurp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    tutorEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuestionario", x => x.IdCuestionario);
                    table.ForeignKey(
                        name: "FK_Cuestionario_Ninio_ninioCurp",
                        column: x => x.ninioCurp,
                        principalTable: "Ninio",
                        principalColumn: "Curp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuestionario_Tutor_tutorEmail",
                        column: x => x.tutorEmail,
                        principalTable: "Tutor",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostico",
                columns: table => new
                {
                    IdDiagnostico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resultado = table.Column<string>(nullable: false),
                    NinioCurp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.IdDiagnostico);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Ninio_NinioCurp",
                        column: x => x.NinioCurp,
                        principalTable: "Ninio",
                        principalColumn: "Curp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Respuestas",
                columns: table => new
                {
                    IdRespuesta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Respuesta = table.Column<string>(maxLength: 2, nullable: false),
                    CuestionarioIdCuestionario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuestas", x => x.IdRespuesta);
                    table.ForeignKey(
                        name: "FK_Respuestas_Cuestionario_CuestionarioIdCuestionario",
                        column: x => x.CuestionarioIdCuestionario,
                        principalTable: "Cuestionario",
                        principalColumn: "IdCuestionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuestionario_ninioCurp",
                table: "Cuestionario",
                column: "ninioCurp");

            migrationBuilder.CreateIndex(
                name: "IX_Cuestionario_tutorEmail",
                table: "Cuestionario",
                column: "tutorEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_NinioCurp",
                table: "Diagnostico",
                column: "NinioCurp");

            migrationBuilder.CreateIndex(
                name: "IX_Ninio_centroEducativoClave",
                table: "Ninio",
                column: "centroEducativoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Ninio_tutorEmail",
                table: "Ninio",
                column: "tutorEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Respuestas_CuestionarioIdCuestionario",
                table: "Respuestas",
                column: "CuestionarioIdCuestionario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnostico");

            migrationBuilder.DropTable(
                name: "Respuestas");

            migrationBuilder.DropTable(
                name: "Cuestionario");

            migrationBuilder.DropTable(
                name: "Ninio");

            migrationBuilder.DropTable(
                name: "CentroEducativo");

            migrationBuilder.DropTable(
                name: "Tutor");
        }
    }
}
