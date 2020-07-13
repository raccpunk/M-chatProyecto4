using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M_chat.Models;
using M_chat.Services;

namespace M_chat.Pages.Tutor
{
    public class ProfileModel : PageModel
    {
        private readonly AppBDContext _context;

        public ProfileModel(AppBDContext context)
        {
            _context = context;
        }

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
    }
}
