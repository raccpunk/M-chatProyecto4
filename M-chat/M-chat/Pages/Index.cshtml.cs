using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_chat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace M_chat.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public void OnGet()
        //{
        //    public class pageModel : IndexModel
        //{
        //    private readonly Ilogin secion;
        //    public IndexModel(Ilogin secion)
        //    {
        //        this.secion = secion;
        //    }
            public void OnGet()
            {
            }
        }
        }
    //}
    
    

