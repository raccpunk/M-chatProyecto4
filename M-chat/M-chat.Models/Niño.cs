using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Niño
    {
        public Niño()
        {
            Tutor = new HashSet<Tutor>();
        }

        public string CurpNiño { get; set; }
        public DateTime FechaNacimientoNiño { get; set; }
        public string GeneroNiño { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public virtual CentroEducativo ClaveNavigation { get; set; }
        public virtual ICollection<Tutor> Tutor { get; set; }
    }
}
