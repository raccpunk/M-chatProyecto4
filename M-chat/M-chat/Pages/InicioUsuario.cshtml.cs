using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_chat.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using M_chat.Models;
using System.Net.Mail;
using Microsoft.AspNetCore.Hosting;

namespace M_chat.Pages
{
    public class InicioUsuarioModel : PageModel
    {
        AppBDContext Bd;
        IWebHostEnvironment hostEnviroment;
        public InicioUsuarioModel(IWebHostEnvironment _hostEnviroment, AppBDContext _context)
        {
            hostEnviroment = _hostEnviroment;
            Bd = _context;
        }
        [BindProperty(SupportsGet =true)]
        public string email { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Curp { get; set; }
        public IList<Models.Ninio> ninios { get; set; }
        public IList<Cuestionario> Quest { get; set; }
        public Respuestas respuestas { get; set; }
        public Diagnostico diagnostico { get; set; }
        public async Task<IActionResult> OnGet(string email)
        {
            if (HttpContext.Session.GetString("Nombre") == null)
            {
                
                return RedirectToPage("Index");
            }
            else
            {
                //esta variable recibe el email del tutor que es enviado por el post del inicio de sesion
                //para esto le quita los 10 caractares que no son del correo
                if (email==null)
                {
                    email = Request.QueryString.Value.Remove(0, 9);
                }
                this.email = email;
                ninios = await (Bd.Ninio.Where(c => c.Email == email)).ToListAsync();
                return Page();
            }
            
        }
        public IActionResult OnGetReenviar(string curp,string email, string nombre)
        {
            respuestas = Bd.Respuestas.Where(r => r.Clave.Contains(curp)).FirstOrDefault();
            diagnostico = Bd.Diagnostico.Where(d => d.ninio == curp).FirstOrDefault();
            var ServicioDeCorreo = new CorreoDelSistema();
            var File = new Attachment(CrearPDF.CrearPdf(nombre, respuestas, hostEnviroment.WebRootPath, diagnostico.Criticas,diagnostico.Normales), $"Resultados de {nombre}.pdf");
            if (diagnostico.Resultado == "Posible autismo")
            {
                ServicioDeCorreo.EnviarCorreo(
                        Asunto: "MChat: Deteccion del Autismo",
                        Cuerpo: $"Su hijo {nombre} tiene probabilidad de autismo",
                        Destinatarios: new List<string> { email },
                        File
                        );
            }
            else
            {
                ServicioDeCorreo.EnviarCorreo(
                    Asunto: "MChat: Deteccion del Autismo",
                    Cuerpo: $"Su hijo {nombre} no tiene probabilidad de autismo",
                    Destinatarios: new List<string> { email },
                    File
                    );
            }
            return RedirectToPage("/ExitoReenviarCorreo",email);
        }

    }
}