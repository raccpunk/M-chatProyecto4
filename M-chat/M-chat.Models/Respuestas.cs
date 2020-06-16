using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Respuestas
    {
        public Respuestas()
        {
            Diagnostico = new HashSet<Diagnostico>();
        }

        public int IdRespuesta { get; set; }
        public string Respuesta { get; set; }
        public string Email { get; set; }
        public int IdPregunta { get; set; }

        public virtual Tutor EmailNavigation { get; set; }
        public virtual Preguntas IdPreguntaNavigation { get; set; }
        public virtual ICollection<Diagnostico> Diagnostico { get; set; }
    }
}
