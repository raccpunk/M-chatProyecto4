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
    public class PrivacyModel : PageModel
    {
        AppBDContext BD = new AppBDContext();
        private readonly ILogger<PrivacyModel> _logger;
        [BindProperty]
        public Tutor tutor { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()

        {

        }

        public void OnPost()
        {
            tutor.Contrasenia = BCrypt.Net.BCrypt.HashPassword(tutor.Contrasenia);
            BD.Tutor.Add(tutor);
            BD.SaveChanges();

        }
    }
}
