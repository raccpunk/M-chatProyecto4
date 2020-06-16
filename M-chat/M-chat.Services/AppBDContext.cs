using System;
using M_chat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace M_chat.Services
{
    public partial class AppBDContext : DbContext
    {
        public AppBDContext()
        {
        }

        public AppBDContext(DbContextOptions<AppBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CentroEducativo> CentroEducativo { get; set; }
        public virtual DbSet<Cuestionario> Cuestionario { get; set; }
        public virtual DbSet<Diagnostico> Diagnostico { get; set; }
        public virtual DbSet<Niño> Niño { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
        public virtual DbSet<Tutor> Tutor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A0815E2\\SQLEXPRESS01; Initial Catalog=Prueba2; User ID=rogercastillo; Password=pelana69; Connect Timeout=15");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentroEducativo>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PK2")
                    .IsClustered(false);

                entity.ToTable("Centro educativo");

                entity.Property(e => e.Clave)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NivelEducativo)
                    .IsRequired()
                    .HasColumnName("Nivel_Educativo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCentroEducativo)
                    .IsRequired()
                    .HasColumnName("Nombre_CentroEducativo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentanteInstitucion)
                    .IsRequired()
                    .HasColumnName("Representante_Institucion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cuestionario>(entity =>
            {
                entity.HasKey(e => e.IdCuestionario)
                    .HasName("PK5")
                    .IsClustered(false);

                entity.Property(e => e.IdCuestionario).HasColumnName("id_Cuestionario");

                entity.Property(e => e.Descripccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion)
                    .HasColumnName("Fecha_aplicacion")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.IdDiagnostico)
                    .HasName("PK11")
                    .IsClustered(false);

                entity.Property(e => e.IdDiagnostico).HasColumnName("id_Diagnostico");

                entity.Property(e => e.IdRespuesta).HasColumnName("id_Respuesta");

                entity.Property(e => e.Resultado)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdRespuestaNavigation)
                    .WithMany(p => p.Diagnostico)
                    .HasForeignKey(d => d.IdRespuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefRespuestas15");
            });

            modelBuilder.Entity<Niño>(entity =>
            {
                entity.HasKey(e => e.CurpNiño)
                    .HasName("PK4")
                    .IsClustered(false);

                entity.Property(e => e.CurpNiño)
                    .HasColumnName("Curp_Niño")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimientoNiño)
                    .HasColumnName("Fecha_Nacimiento_Niño")
                    .HasColumnType("date");

                entity.Property(e => e.GeneroNiño)
                    .IsRequired()
                    .HasColumnName("Genero_Niño")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClaveNavigation)
                    .WithMany(p => p.Niño)
                    .HasForeignKey(d => d.Clave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefCentro_educativo21");
            });

            modelBuilder.Entity<Preguntas>(entity =>
            {
                entity.HasKey(e => e.IdPregunta)
                    .HasName("PK6")
                    .IsClustered(false);

                entity.Property(e => e.IdPregunta)
                    .HasColumnName("id_Pregunta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Critica)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdCuestionario).HasColumnName("id_Cuestionario");

                entity.HasOne(d => d.IdCuestionarioNavigation)
                    .WithMany(p => p.Preguntas)
                    .HasForeignKey(d => d.IdCuestionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefCuestionario14");
            });

            modelBuilder.Entity<Respuestas>(entity =>
            {
                entity.HasKey(e => e.IdRespuesta)
                    .HasName("PK7")
                    .IsClustered(false);

                entity.Property(e => e.IdRespuesta)
                    .HasColumnName("id_Respuesta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPregunta).HasColumnName("id_Pregunta");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Respuestas)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefTutor10");

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.Respuestas)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefPreguntas11");
            });

            modelBuilder.Entity<Tutor>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK1")
                    .IsClustered(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurpNiño)
                    .IsRequired()
                    .HasColumnName("Curp_Niño")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_Nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Genero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CurpNiñoNavigation)
                    .WithMany(p => p.Tutor)
                    .HasForeignKey(d => d.CurpNiño)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefNiño22");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
