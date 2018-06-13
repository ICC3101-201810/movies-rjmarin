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
    class Person
    {
        public string nombre;
        public string apellido;
        public DateTime fechaDeNacimiento;
        public string biografia;
        public string profesion;

        public Person(string nombre, string apellido, DateTime fechaDeNacimiento, string biografia, string profesion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.biografia = biografia;
            this.profesion = profesion;
        }
        public string Info()
        {
            string info = "nombre: " + nombre + " " + apellido + "   profesion: " + profesion + "\n";
            return info;
        }
        public string Info(List<PeliculaActor> peliculaActors, List<PeliculaProductor> peliculaProductors)
        {
            string info = "nombre: " + nombre + " " + apellido + "\nprofesion: " + profesion + "\n" + "fecha de nacimiento " +
               fechaDeNacimiento + "\biografia: " + biografia +"\n";
            info += "--------------------------\n";
            
            if (this.profesion=="productor")
            {
               
                foreach (PeliculaProductor p in peliculaProductors)
                {
                    if (p.productor == this)
                    {
                        info += "nombre de la pelicula: " + p.pelicula.nombre + "\n Descripcion: " + p.pelicula.descripcion + "\n";
                        info += "--------------------------\n";

                    }
                }
            }

            if (this.profesion == "actor")
            {
                foreach (PeliculaActor p in peliculaActors)
                {
                    info += "peliculas en las que ha actuado:\n";
                    if (p.actor == this)
                    {
                        info += "nombre de la pelicula: " + p.pelicula.nombre + "\n Descripcion: " + p.pelicula.descripcion + "\n";
                        info += "--------------------------\n";

                    }
                }

            }
            

            return info;
        }
    }
}
