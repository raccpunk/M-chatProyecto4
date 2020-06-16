using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Preguntas
    {
        public Preguntas()
        {
            Respuestas = new HashSet<Respuestas>();
        }

        public int IdPregunta { get; set; }
        public byte[] Critica { get; set; }
        public int IdCuestionario { get; set; }

        public virtual Cuestionario IdCuestionarioNavigation { get; set; }
        public virtual ICollection<Respuestas> Respuestas { get; set; }
    }
}
