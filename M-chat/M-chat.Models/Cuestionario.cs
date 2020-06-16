using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Cuestionario
    {
        public Cuestionario()
        {
            Preguntas = new HashSet<Preguntas>();
        }

        public int IdCuestionario { get; set; }
        public string Descripccion { get; set; }
        public DateTime FechaAplicacion { get; set; }

        public virtual ICollection<Preguntas> Preguntas { get; set; }
    }
}
