using System;
using System.Collections.Generic;
using System.Text;

namespace XamApp.Models
{
    public class Burger
    {
        public int IdHamburguesa { get; set; }
        public int IdRestaurante { get; set; }
        public string NombreHamburguesa { get; set; }
        public string Categoria { get; set; }
        public decimal Calificacion { get; set; }
        public decimal Rating { get; set; }
        public bool? Favorito { get; set; }
        public string Imagen { get; set; }
    }
}
