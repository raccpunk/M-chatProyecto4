using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using M_chat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_chat.Services;

namespace M_chat.Pages
{
    public class CuestionarioModel : PageModel
    {
        AppBDContext context;
        [BindProperty]
        public Respuestas Respuestas { get; set; }
        [BindProperty]
        public Cuestionario cuestionario { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Email { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Curp { get; set; }
        public CuestionarioModel(AppBDContext _context)
        {
            context = _context;
        }
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
        public void OnPost()
        {
            var tutorem = from e in context.Ninio select e;
            cuestionario.RespuestasId = Respuestas.IdRespuesta;
            context.Respuestas.Add(Respuestas);
            cuestionario.Curpninio = Curp;
            cuestionario.Email = Email;
            cuestionario.FechaAplicacion = DateTime.Now; ;
            context.Cuestionario.Add(cuestionario);
            context.SaveChanges();
        }
        private bool NinioExists(int id)
        {
            return context.Respuestas.Any(e => e.IdRespuesta == id);
        }
    }
}