using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movies
{
    class PeliculaActor
    {
        public Pelicula pelicula;
        public Person actor;

        public PeliculaActor(Pelicula pelicula, Person actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
