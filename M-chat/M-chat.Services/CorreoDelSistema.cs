

namespace M_chat.Services
{
    public class CorreoDelSistema : ServidorCorreo
    {
        public CorreoDelSistema()
        {
            Remitente = "encuestaautismoutm@gmail.com";
            Password = "Aa@19090484";
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            IniciarSmtpClient();
        }
    }
}
