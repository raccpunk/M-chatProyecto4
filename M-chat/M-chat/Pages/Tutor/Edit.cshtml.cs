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

namespace M_chat.Pages.Tutor
{
    public class EditModel : PageModel
    {
        private readonly M_chat.Services.AppBDContext _context;

        public EditModel(M_chat.Services.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Tutor Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor = await _context.Tutor.FirstOrDefaultAsync(m => m.Email == id);

            if (Tutor == null)
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
            Tutor.Contrasenia = BCrypt.Net.BCrypt.HashPassword(Tutor.Contrasenia);
            _context.Attach(Tutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorExists(Tutor.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Profile");
        }

        private bool TutorExists(string id)
        {
            return _context.Tutor.Any(e => e.Email == id);
        }
    }
}
