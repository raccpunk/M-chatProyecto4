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
        public virtual DbSet<Ninio> Ninio { get; set; }
        public virtual DbSet<Respuestas> Respuestas { get; set; }
        public virtual DbSet<Tutor> Tutor { get; set; }

        
    }
}
