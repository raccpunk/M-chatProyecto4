using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_chat.Models;
using M_chat.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace M_chat.Pages
{
    public class RegistrarninioModel : PageModel
    {
        AppBDContext BD;
        private readonly ILogger<PrivacyModel> _logger;
        [BindProperty]
        public Models.Ninio ninio { get; set; }
        [BindProperty(SupportsGet =true)]
        public string email { get; set; }
        public RegistrarninioModel(ILogger<PrivacyModel> logger, AppBDContext appBD)
        {
            _logger = logger;
            BD = appBD;
        }
        public IEnumerable<CentroEducativo> centroEducativos { get; set; }

      
        public async Task<IActionResult> OnPost()
        {
            centroEducativos= await BD.CentroEducativo.ToListAsync();
            BD.Ninio.Add(ninio);
            BD.SaveChanges();
            return RedirectToPage("RegistroExitoso",email);
        }
        public async Task<IActionResult> OnGetAsync(string email)
        {
            centroEducativos = await BD.CentroEducativo.ToListAsync();
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