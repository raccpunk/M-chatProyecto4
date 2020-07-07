using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class Cuestionario
    {
        public Cuestionario()
        {
            Respuestas = new HashSet<Respuestas>();
        }
        [Key]
        public int IdCuestionario { get; set; }
        public DateTime FechaAplicacion { get; set; }
        [Required]
        [Display(Name = "CurpNinio")]
        [ForeignKey("Ninio")]
        public string Curpninio { get; set; }
        [NotMapped]
        public Ninio ninio { get; set; }
        [ForeignKey("Tutor")]
        [Required]
        [Display(Name = "EmailTutor")]
        public string Email { get; set; }
        [NotMapped]
        public Tutor tutor { get; set; }
        public virtual ICollection<Respuestas> Respuestas { get; set; }
    }
}
