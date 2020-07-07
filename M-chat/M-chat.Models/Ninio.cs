using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class Ninio
    {
        public Ninio()
        {
            cuestionario = new HashSet<Cuestionario>();
            diagnosticos = new HashSet<Diagnostico>();
        }
        [Key]
        //propiedad que sirve para que la campo no sea autoincremental
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "Curp")]
        public string Curp { get; set; }
        [ForeignKey("Tutor")]
        [Display(Name = "EmailTutor")]
        [Required]
        public string Email { get; set; }
        [NotMapped]
        public Tutor tutor { get; set; }
        [Display(Name = "FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Genero")]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [ForeignKey("CentroEducativo")]
        public string ClaveEscuela { get; set; }
        [NotMapped]
        public CentroEducativo centroEducativo { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        //Relacion con respuestas many to many
        public ICollection<Cuestionario> cuestionario { get; set; }
        public ICollection<Diagnostico> diagnosticos { get; set; }
    }
}
