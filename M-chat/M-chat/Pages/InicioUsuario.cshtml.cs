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

namespace M_chat.Pages
{
    public class InicioUsuarioModel : PageModel
    {
        AppBDContext Bd;
        public InicioUsuarioModel(AppBDContext _db)
        {
            Bd = _db;
        }

        public string email { get; set; }

        public IList<Models.Ninio> ninios { get; set; }
        //public async Task tutoremail() 
        //{
        //    email = await (Bd.Tutor.Where(t => t.Nombre == HttpContext.Session.GetString("Nombre")).FirstOrDefaultAsync<Models.Tutor>());
        //}
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
                
                ninios = await (Bd.Ninio.Where(c => c.Email == email)).ToListAsync<Models.Ninio>();
                return Page();
            }
        }
    }
}