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
    public class DetailsModel : PageModel
    {
        private readonly AppBDContext _context;

        public DetailsModel(AppBDContext context)
        {
            _context = context;
        }

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
    }
}
