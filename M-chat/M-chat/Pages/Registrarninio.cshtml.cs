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
        AppBDContext BD = new AppBDContext();
        private readonly ILogger<PrivacyModel> _logger;
        [BindProperty]
        public Ninio ninio { get; set; }
        public RegistrarninioModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public IEnumerable<CentroEducativo> centroEducativos { get; set; }

      
        public async Task OnPost()
        {
            centroEducativos= await BD.CentroEducativo.ToListAsync();
            BD.Ninio.Add(ninio);
            BD.SaveChanges();
        }
        public async Task<IActionResult> OnGetAsync()
        {
            centroEducativos = await BD.CentroEducativo.ToListAsync();
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