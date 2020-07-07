using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_chat.Models
{
    public partial class CentroEducativo
    {
        [Key]
        [Display(Name = "Clave")]
        [Required]
        //propiedad que sirve para que la campo no sea autoincremental
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Clave { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        [Display(Name = "NivelEducativo")]
        [Required]
        public string NivelEducativo { get; set; }
        [Display(Name = "Direccion")]
        [Required]
        public string Direccion { get; set; }
        [Display(Name = "Representante")]
        [Required]
        public string Representante { get; set; }
        [NotMapped]
        //Relacion con ninios one to many
        public virtual ICollection<Ninio> Ninio { get; set; }
    }
}
