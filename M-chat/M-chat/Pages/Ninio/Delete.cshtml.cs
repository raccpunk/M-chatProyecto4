using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M_chat.Models;
using M_chat.Services;

namespace M_chat.Pages.Ninio
{
    public class DeleteModel : PageModel
    {
        private readonly M_chat.Services.AppBDContext _context;

        public DeleteModel(M_chat.Services.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Ninio Ninio { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ninio = await _context.Ninio.FirstOrDefaultAsync(m => m.Curp == id);

            if (Ninio == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ninio = await _context.Ninio.FindAsync(id);

            if (Ninio != null)
            {
                _context.Ninio.Remove(Ninio);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("../InicioUsuario", Ninio.Email);
        }
    }
}
