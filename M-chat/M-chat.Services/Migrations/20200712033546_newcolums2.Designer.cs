﻿// <auto-generated />
using System;
using M_chat.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M_chat.Services.Migrations
{
    [DbContext(typeof(AppBDContext))]
    [Migration("20200712033546_newcolums2")]
    partial class newcolums2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M_chat.Models.CentroEducativo", b =>
                {
                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEducativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Clave");

                    b.ToTable("CentroEducativo");
                });

            modelBuilder.Entity("M_chat.Models.Cuestionario", b =>
                {
                    b.Property<int>("IdCuestionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Curpninio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAplicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NinioCurp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RespuestasId")
                        .HasColumnType("int");

                    b.HasKey("IdCuestionario");

                    b.HasIndex("NinioCurp");

                    b.ToTable("Cuestionario");
                });

            modelBuilder.Entity("M_chat.Models.Diagnostico", b =>
                {
                    b.Property<int>("IdDiagnostico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NinioCurp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDiagnostico");

                    b.HasIndex("NinioCurp");

                    b.ToTable("Diagnostico");
                });

            modelBuilder.Entity("M_chat.Models.Ninio", b =>
                {
                    b.Property<string>("Curp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveEscuela")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Curp");

                    b.ToTable("Ninio");
                });

            modelBuilder.Entity("M_chat.Models.Respuestas", b =>
                {
                    b.Property<int>("IdRespuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Respuesta1")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta10")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta11")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta12")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta13")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta14")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta15")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta16")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta17")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta18")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta19")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta2")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta20")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta21")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta22")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta23")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta3")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta4")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta5")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta6")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta7")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta8")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Respuesta9")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("IdRespuesta");

                    b.ToTable("Respuestas");
                });

            modelBuilder.Entity("M_chat.Models.Tutor", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Curp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("M_chat.Models.Cuestionario", b =>
                {
                    b.HasOne("M_chat.Models.Ninio", null)
                        .WithMany("cuestionario")
                        .HasForeignKey("NinioCurp");
                });

            modelBuilder.Entity("M_chat.Models.Diagnostico", b =>
                {
                    b.HasOne("M_chat.Models.Ninio", null)
                        .WithMany("diagnosticos")
                        .HasForeignKey("NinioCurp");
                });
#pragma warning restore 612, 618
        }
    }
}
