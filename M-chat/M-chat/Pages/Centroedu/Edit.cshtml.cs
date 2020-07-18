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

namespace M_chat.Pages.Centroedu
{
    public class EditModel : PageModel
    {
        private readonly AppBDContext _context;

        public EditModel(AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CentroEducativo CentroEducativo { get; set; }
        [BindProperty(SupportsGet =true)]
        public string email { get; set; }
        public async Task<IActionResult> OnGetAsync(string id,string email)
        {
            if (id == null)
            {
                return NotFound();
            }
            this.email = email;
            CentroEducativo = await _context.CentroEducativo.FirstOrDefaultAsync(m => m.Clave == id);

            if (CentroEducativo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CentroEducativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroEducativoExists(CentroEducativo.Clave))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CentroEducativoExists(string id)
        {
            return _context.CentroEducativo.Any(e => e.Clave == id);
        }
    }
}
