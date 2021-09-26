using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        [TempData]
        public string Nombre { get; set; }

        public void OnGet(int id, int pg)
        {
            Message = "Your contact page. id: " + id.ToString() + " pg: " + pg;
        }
    }
}
