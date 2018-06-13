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
        public DateTime fechaDeEstreno;
        public string descripcion;
        long presupuesto;
        public Estudio estudio;

        public Pelicula(string nombre, Person director, DateTime fechaDeEstreno, string descripcion, long presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaDeEstreno = fechaDeEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
        public string Info()
        {
            string info = "nombre: " + nombre + "   descripcion: " + descripcion + "\n";
            return info;
        }
        public string Info(List<PeliculaActor> peliculaActors, List<PeliculaProductor> peliculaProductors)
        {
            BaseDeDatos bsd = BaseDeDatos.Deserialize_("batos.bin");
            string info = "nombre: " + nombre + "\ndescripcion: " + descripcion + "\nfecha de estreno"+fechaDeEstreno +"\n" +
                "presupuesto: " + presupuesto + "estudio: " + estudio.nombre +" \n";
            info += "-----------------------------------\n";
            info += "Director: " + director.nombre+ " " + director.apellido ;
            info += "\nproductor/es\n";
            info += "-----------------------------------\n";
            foreach (PeliculaProductor item in bsd.peliculaProductors) 
            {
                if (this.descripcion == item.pelicula.descripcion && this.nombre == item.pelicula.nombre)
                {
                    info += "nombre: " + item.productor.nombre + " " + item.productor.apellido + "\n";
                }
            }
            info += "actores\n ---------------------------------------\n";
            foreach (PeliculaActor item in bsd.peliculaActors)
            {
                if (this.descripcion == item.pelicula.descripcion && this.nombre == item.pelicula.nombre)
                {
                    info += "nombre: " + item.actor.nombre + " " + item.actor.apellido + "\n";
                }
            }
            info += "-----------------------------------\n";
            return info;

        }
    }
}
