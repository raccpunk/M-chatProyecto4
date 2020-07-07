using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class Tutor
    {
        //propiedad que sirve para que la campo no sea autoincremental
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [MinLength(8)]
        [MaxLength(60)]
        [Required]
        [Display(Name = "Contrasenia")]
        public string Contrasenia { get; set; }
        [Required]
        [Display(Name = "FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [Display(Name = "Genero")]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Curp")]
        public string Curp { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [NotMapped]
        //relacion ninio one to many
        public virtual ICollection<Ninio> Ninio { get; set; }
        
    }
}
