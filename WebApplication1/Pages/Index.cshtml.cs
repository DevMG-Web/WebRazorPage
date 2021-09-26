using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Persona Persona { get; set; }

        [BindProperty]
        public Ciudad Ciudad { get; set; }
        
        [TempData]
        public string Nombre { get; set; }
        
        public void OnGet()
        {

        }

        public IActionResult OnPost(string param1)
        {
            Nombre = param1;
            return RedirectToPage("Contact");
        }

        public void OnPostPersona(Persona persona)
        {
            //...
        }

        public void OnPostPersonaCiudad(Persona persona, Ciudad ciudad)
        {
            //....
        }
    }

    //public class Persona
    //{
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //}

    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }
}
