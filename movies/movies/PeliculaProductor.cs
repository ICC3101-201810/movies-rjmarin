using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movies
{
    class PeliculaProductor
    {
        Pelicula pelicula;
        Person productor;

        public PeliculaProductor(Pelicula pelicula, Person productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
