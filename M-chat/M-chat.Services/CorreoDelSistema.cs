

namespace M_chat.Services
{
    public class CorreoDelSistema : ServidorCorreo
    {
        public CorreoDelSistema()
        {
            Remitente = "racc2018@gmail.com";
            Password = "pelana69";
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            IniciarSmtpClient();
        }
    }
}
