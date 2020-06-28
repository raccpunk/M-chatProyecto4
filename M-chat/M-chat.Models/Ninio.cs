using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Ninio
    {
        public string CurpNinio { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimientoNinio { get; set; }
        public string GeneroNinio { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Apellidos { get; set; }


        public virtual CentroEducativo ClaveNavigation { get; set; }
        public virtual Tutor EmailNavigation { get; set; }
    }
}
