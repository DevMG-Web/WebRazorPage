using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Pages.Tags
{
    public class FormularioModel : PageModel
    {
        [BindProperty]
        public Persona Persona { get; set; }

        public List<SelectListItem> PreguntasSeguridad
        {
            get
            {
                string escogido = Persona?.Pregunta;
                var preguntas = ObtenerPreguntasDeSeguridad();
                var opciones = new List<SelectListItem>();
                foreach (var pregunta in preguntas)
                {
                    opciones.Add(new SelectListItem()
                    {
                        Text = pregunta,
                        Value = pregunta,
                        Selected = pregunta == escogido
                    });

                }
                
                return opciones;
            }
        }

        private List<string> ObtenerPreguntasDeSeguridad()
        {
            return new List<string>()
            {
                "¿Cual es la nacionalidad de su perro?",
                "¿Pepsi o Coca cola?",
                "¿Nombre de una persona que usted no conoce?"
            };
        }

        public void OnGet()
        {
        }

        public void OnPost() { }

        [ValidateAntiForgeryToken]
        public void OnPostConToken() { }
    }
}
