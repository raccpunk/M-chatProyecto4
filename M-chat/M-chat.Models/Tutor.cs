using System;
using System.Collections.Generic;

namespace M_chat.Models
{
    public partial class Tutor
    {
        public Tutor()
        {
            Respuestas = new HashSet<Respuestas>();
        }

        public string Email { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Curp { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string CurpNiño { get; set; }

        public virtual Niño CurpNiñoNavigation { get; set; }
        public virtual ICollection<Respuestas> Respuestas { get; set; }
    }
}
