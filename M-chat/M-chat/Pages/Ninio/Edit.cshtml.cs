using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using M_chat.Models;
using M_chat.Services;

namespace M_chat.Pages.Ninio
{
    public class EditModel : PageModel
    {
        private readonly AppBDContext _context;

        public EditModel(AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Ninio Ninio { get; set; }

        public async Task<IActionResult> OnGetAsync(string curp)
        {
            if (curp == null)
            {
                return NotFound();
            }

            Ninio = await _context.Ninio.FirstOrDefaultAsync(m => m.Curp == curp);

            if (Ninio == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ninio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NinioExists(Ninio.Curp))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("../InicioUsuario", Ninio.Email);
        }

        private bool NinioExists(string id)
        {
            return _context.Ninio.Any(e => e.Curp == id);
        }
    }
}
