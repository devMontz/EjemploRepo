using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class Pelicula
    {
        //contructor vacio

        public Pelicula( string pNombre , decimal pPrecio) {

            NombrePelicula = pNombre;
            PrecioPelicula = pPrecio;

        }

        public string NombrePelicula { get; set; }

        public decimal PrecioPelicula { get; set; }

    }
}
