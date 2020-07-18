using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class Diagnostico
    {
        [Key]
        [Display(Name ="ID")]
        public int IdDiagnostico { get; set; }
        [ForeignKey("Ninio")]
        [Display(Name ="curpninio")]
        [Required]
        public string ninio { get; set; }
        [Required]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }
        
    }
}
