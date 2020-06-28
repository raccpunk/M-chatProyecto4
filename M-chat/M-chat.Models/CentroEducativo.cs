using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class CentroEducativo
    {
        public CentroEducativo()
        {
            Ninio = new HashSet<Ninio>();
        }

        public string Clave { get; set; }
        public string NombreCentroEducativo { get; set; }
        public string Telefono { get; set; }
        public string NivelEducativo { get; set; }
        public string Direccion { get; set; }
        public string RepresentanteInstitucion { get; set; }

        public virtual ICollection<Ninio> Ninio { get; set; }
    }
}
