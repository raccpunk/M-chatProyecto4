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
        public string Clave { get; set; }
        [Required]
        [Display(Name = "Respuesta1")]
        [MaxLength(2)]
        public string Respuesta1 { get; set; }
        [Required]
        [Display(Name = "Respuesta2")]
        [MaxLength(2)]
        public string Respuesta2 { get; set; }
        [Required]
        [Display(Name = "Respuesta3")]
        [MaxLength(2)]
        public string Respuesta3 { get; set; }
        [Required]
        [Display(Name = "Respuesta4")]
        [MaxLength(2)]
        public string Respuesta4 { get; set; }
        [Required]
        [Display(Name = "Respuesta5")]
        [MaxLength(2)]
        public string Respuesta5 { get; set; }
        [Required]
        [Display(Name = "Respuesta6")]
        [MaxLength(2)]
        public string Respuesta6 { get; set; }
        [Required]
        [Display(Name = "Respuesta7")]
        [MaxLength(2)]
        public string Respuesta7 { get; set; }
        [Required]
        [Display(Name = "Respuesta8")]
        [MaxLength(2)]
        public string Respuesta8 { get; set; }
        [Required]
        [Display(Name = "Respuesta9")]
        [MaxLength(2)]
        public string Respuesta9 { get; set; }
        [Required]
        [Display(Name = "Respuesta10")]
        [MaxLength(2)]
        public string Respuesta10 { get; set; }
        [Required]
        [Display(Name = "Respuesta11")]
        [MaxLength(2)]
        public string Respuesta11 { get; set; }
        [Required]
        [Display(Name = "Respuesta12")]
        [MaxLength(2)]
        public string Respuesta12 { get; set; }
        [Required]
        [Display(Name = "Respuesta13")]
        [MaxLength(2)]
        public string Respuesta13 { get; set; }
        [Required]
        [Display(Name = "Respuesta14")]
        [MaxLength(2)]
        public string Respuesta14 { get; set; }
        [Required]
        [Display(Name = "Respuesta15")]
        [MaxLength(2)]
        public string Respuesta15 { get; set; }
        [Required]
        [Display(Name = "Respuesta16")]
        [MaxLength(2)]
        public string Respuesta16 { get; set; }
        [Required]
        [Display(Name = "Respuesta17")]
        [MaxLength(2)]
        public string Respuesta17 { get; set; }
        [Required]
        [Display(Name = "Respuesta18")]
        [MaxLength(2)]
        public string Respuesta18 { get; set; }
        [Required]
        [Display(Name = "Respuesta19")]
        [MaxLength(2)]
        public string Respuesta19 { get; set; }
        [Required]
        [Display(Name = "Respuesta20")]
        [MaxLength(2)]
        public string Respuesta20 { get; set; }
        [Display(Name = "Respuesta21")]
        [MaxLength(2)]
        public string Respuesta21 { get; set; }
        [Display(Name = "Respuesta22")]
        [MaxLength(2)]
        public string Respuesta22 { get; set; }
        [Display(Name = "Respuesta23")]
        [MaxLength(2)]
        public string Respuesta23 { get; set; }
    }
}
