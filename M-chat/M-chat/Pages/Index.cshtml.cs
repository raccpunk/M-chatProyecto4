using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_chat.Models;
using M_chat.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace M_chat.Pages
{
    public class IndexModel : PageModel
    {
        public string Msg;
        private readonly ILogger<IndexModel> _logger;
        AppBDContext BD = new AppBDContext();
        [BindProperty]
        public Tutor tutor { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            tutor = new Tutor();
        }
 
        public IActionResult OnPost()
        {
            var _tutor = login(tutor.Email, tutor.Contraseña);
            if (_tutor == null)
            {
                return RedirectToPage("ErrorInicio");
            }
            else
            {
                HttpContext.Session.SetString("email", tutor.Email);
                return RedirectToPage("InicioUsuario");
            }
        }
        private Tutor login(string email, string contraseña)
        {
            var tuTor = BD.Tutor.SingleOrDefault(a => a.Email.Equals(email));
            if (tuTor != null)
            {
                if (BCrypt.Net.BCrypt.Verify(contraseña, tuTor.Contraseña))
                {
                    return tuTor;
                }  
            }
            return null;
        }
        public IActionResult OnGetLogout()
        {

            HttpContext.Session.Remove("email");
            return RedirectToPage("Index");
        }
    }
}
    
    
    

