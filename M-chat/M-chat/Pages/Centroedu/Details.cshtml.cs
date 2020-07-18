using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M_chat.Models;
using M_chat.Services;

namespace M_chat.Pages.Centroedu
{
    public class DetailsModel : PageModel
    {
        private readonly AppBDContext _context;

        public DetailsModel(AppBDContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string email { get; set; }
        public CentroEducativo CentroEducativo { get; set; }

        public async Task<IActionResult> OnGetAsync(string id, string Email)
        {
            if (id == null)
            {
                return NotFound();
            }

            CentroEducativo = await _context.CentroEducativo.FirstOrDefaultAsync(m => m.Clave == id);
            email = Email;
            if (CentroEducativo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
