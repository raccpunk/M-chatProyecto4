using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M_chat.Models;
using M_chat.Services;

namespace M_chat.Pages
{
    public class DiagnosticoModel : PageModel
    {
        private readonly M_chat.Services.AppBDContext _context;

        public DiagnosticoModel(M_chat.Services.AppBDContext context)
        {
            _context = context;
        }

        public Cuestionario Cuestionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cuestionario = await _context.Cuestionario.FirstOrDefaultAsync(m => m.IdCuestionario == id);

            if (Cuestionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
