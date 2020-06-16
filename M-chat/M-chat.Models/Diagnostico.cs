using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public string Resultado { get; set; }
        public int IdRespuesta { get; set; }

        public virtual Respuestas IdRespuestaNavigation { get; set; }
    }
}
