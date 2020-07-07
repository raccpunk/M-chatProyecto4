using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class Respuestas
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        public int IdRespuesta { get; set; }
        [Required]
        [Display(Name = "Respuesta")]
        [MaxLength(2)]
        public string Respuesta { get; set; }
    }
}
