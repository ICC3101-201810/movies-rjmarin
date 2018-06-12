using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace movies
{
    [Serializable]
    class BaseDeDatos
    {
        public List<Person> personas = new List<Person>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<Estudio> estudios = new List<Estudio>();
       ´public List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();

        public BaseDeDatos(List<Person> personas, List<Pelicula> peliculas, List<Estudio> estudios, List<PeliculaActor> peliculaActors, List<PeliculaProductor> peliculaProductors)
        {
            this.personas = personas;
            this.peliculas = peliculas;
            this.estudios = estudios;
            this.peliculaActors = peliculaActors;
            this.peliculaProductors = peliculaProductors;
        }
    }
}
