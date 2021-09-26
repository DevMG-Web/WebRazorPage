using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Estreno { get; set; }
        public bool EnCartelera { get; set; }
    }
}
