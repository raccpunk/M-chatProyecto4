using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M_chat.Pages
{
    public class RegistroExitosoModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string email { get; set; }
        public void OnGet()
        {
            this.email = Request.QueryString.Value.Remove(0, 9);
        }
    }
}