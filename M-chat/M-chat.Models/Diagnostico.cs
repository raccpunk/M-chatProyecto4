using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace M_chat.Models
{
    public partial class Diagnostico
    {
        [Key]
        [Display(Name ="ID")]
        public int IdDiagnostico { get; set; }
        [Required]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }
    }
}
