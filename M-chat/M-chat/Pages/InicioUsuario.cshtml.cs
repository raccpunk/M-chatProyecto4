using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M_chat.Pages
{
    public class InicioUsuarioModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Nombre") == null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}