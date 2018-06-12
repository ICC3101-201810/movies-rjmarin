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
    class Pelicula
    {
        public string nombre;
        public Person director;
        int fechaDeEstreno;
        public string descripcion;
        long presupuesto;
        public Estudio estudio;

        public Pelicula(string nombre, Person director, int fechaDeEstreno, string descripcion, long presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaDeEstreno = fechaDeEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}
