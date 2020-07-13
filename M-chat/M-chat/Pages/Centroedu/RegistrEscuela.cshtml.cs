using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_chat.Models;
using M_chat.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace M_chat.Pages
{
    public class RegistrEscuelaModel : PageModel
    {
        AppBDContext BD;
        private readonly ILogger<RegistrEscuelaModel> _logger;
        [BindProperty]
        public CentroEducativo centroeducativo { get; set; }
        [BindProperty(SupportsGet = true)]
        public string email { get; set; }
        public RegistrEscuelaModel(ILogger<RegistrEscuelaModel> logger, AppBDContext appBD )
        {
            _logger = logger;
            BD = appBD;
        }
        public void OnPost()
        {
            BD.CentroEducativo.Add(centroeducativo);
            BD.SaveChanges();
        }
      
        public IActionResult OnGet(string email)
        {
            if (HttpContext.Session.GetString("Nombre") == null)
            {
                this.email = email;
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}