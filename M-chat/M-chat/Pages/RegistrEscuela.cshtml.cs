using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_chat.Models;
using M_chat.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace M_chat.Pages
{
    public class RegistrEscuelaModel : PageModel
    {
        AppBDContext BD = new AppBDContext();
        private readonly ILogger<RegistrEscuelaModel> _logger;
        [BindProperty]
        public CentroEducativo centroeducativo { get; set; }
        public RegistrEscuelaModel(ILogger<RegistrEscuelaModel> logger)
        {
            _logger = logger;
        }
        public void OnPost()
        {
            BD.CentroEducativo.Add(centroeducativo);
            BD.SaveChanges();
        }
        public void OnGet()

        {

        }
    }
}