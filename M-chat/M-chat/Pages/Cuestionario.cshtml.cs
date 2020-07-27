using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using M_chat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_chat.Services;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using Microsoft.AspNetCore.Hosting;
using Org.BouncyCastle.Asn1.X509;

namespace M_chat.Pages
{
    public class CuestionarioModel : PageModel
    {
        private readonly IWebHostEnvironment hostEnviroment;
        public CuestionarioModel( IWebHostEnvironment _hostEnviroment, AppBDContext _context)
        {
            hostEnviroment = _hostEnviroment;
            context = _context;
        }
        
        AppBDContext context;
        [BindProperty]
        public Respuestas Respuestas { get; set; }
        [BindProperty]
        public Cuestionario cuestionario { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Email { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Curp { get; set; }
        public List<int> puntaje = new List<int>();
        public int uno { get; set; }
        public int dos { get; set; }
        [BindProperty]
        public Diagnostico diagnostico { get; set; }
        public Models.Ninio ninio { get; set; }
        public string Resultado { get; set; }
        
        public IActionResult OnGet(string curp)
        {
            var tutorem = from e in context.Ninio select e;
            if (HttpContext.Session.GetString("Nombre") == null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                Curp = curp;
                Email = tutorem.Where(s => s.Curp.Contains(curp)).FirstOrDefault().Email;
                return Page();
            }

        }
        public IActionResult OnPost()
        {
            try
            {
                ninio = context.Ninio.Where(n => n.Curp == Curp).First();
                ninio.diagnotiscado = true;
                cuestionario.Curpninio = Curp;
                cuestionario.Email = Email;
                cuestionario.FechaAplicacion = DateTime.Now;
                Respuestas.Clave = cuestionario.Email + cuestionario.Curpninio + DateTime.Now;
                cuestionario.RespuestasId = Respuestas.Clave;
                Diagnosticar();
                diagnostico.Criticas = dos / 2;
                diagnostico.Normales = uno;
                diagnostico.Resultado = Resultado;
                diagnostico.ninio = Curp;
                context.Diagnostico.Add(diagnostico);
                context.Respuestas.Add(Respuestas);
                context.Cuestionario.Add(cuestionario);
                context.Attach(ninio).State = EntityState.Modified;
                context.SaveChanges();
                correo(context.Ninio.Where(n => n.Curp == Curp).First().Nombre,Respuestas);
                return RedirectToPage("/CuestionarioExitoso",Email);
            }
            catch (Exception)
            {
                //throw;
                return RedirectToPage("/ErrorTerminarCuestionario", Email);
            }
            
        }
        public void Diagnosticar() 
        {
            if (Respuestas.Respuesta1== "No") 
            {
                puntaje.Add(1); 
            }
            if (Respuestas.Respuesta2 == "No")
            {
                puntaje.Add(2);
            }
            if (Respuestas.Respuesta3 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta4 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta5 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta6 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta7 == "No")
            {
                puntaje.Add(2);
            }
            if (Respuestas.Respuesta8 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta9 == "No")
            {
                puntaje.Add(2);
            }
            if (Respuestas.Respuesta10 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta11 == "SI")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta12 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta13 == "No")
            {
                puntaje.Add(2);
            }
            if (Respuestas.Respuesta14 == "No")
            {
                puntaje.Add(2);
            }
            if (Respuestas.Respuesta15 == "No")
            {
                puntaje.Add(2); 
            }
            if (Respuestas.Respuesta16 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta17 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta18 == "SI")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta19 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta20 == "SI")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta21 == "No")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta22 == "SI")
            {
                puntaje.Add(1);
            }
            if (Respuestas.Respuesta23 == "No")
            {
                puntaje.Add(1);
            }
            for (int i = 0; i < puntaje.Count(); i++)
            {
                if (puntaje[i]==1)
                {
                    uno+=1;
                }
                if (puntaje[i] == 2)
                {
                    dos += 1;
                }
            }
            if (uno>=3 | dos>=4)
            {
                Resultado = "Posible autismo";
            }
            else
            {
                Resultado = "Sin posibilidad de autismo";
            }
        }
        public void correo(string nombre,Respuestas respuestas)
        {
            var ServicioDeCorreo = new CorreoDelSistema();
            var File = new Attachment(CrearPDF.CrearPdf(nombre,respuestas,hostEnviroment.WebRootPath,dos/2,uno), $"Resultados de {nombre}.pdf");
            if (diagnostico.Resultado == "Posible autismo")
            {
                ServicioDeCorreo.EnviarCorreo(
                        Asunto: "Deteccion del Autismo",
                        Cuerpo: $"Su hijo {nombre} tiene probabilidad de autismo",
                        Destinatarios: new List<string> { Email },
                        File
                        );
            }
            else
            {
                ServicioDeCorreo.EnviarCorreo(
                    Asunto: "Deteccion del Autismo",
                    Cuerpo: $"Su hijo {nombre} no tiene probabilidad de autismo",
                    Destinatarios: new List<string> { Email },
                    File
                    );
            }
        }
    }
}
