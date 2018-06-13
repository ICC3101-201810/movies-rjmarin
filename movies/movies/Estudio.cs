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
    class Estudio
    {
        public string nombre;
        public string direccion;
        public DateTime fechaDeApertura;

        public Estudio(string nombre, string direccion, DateTime fechaDeApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaDeApertura = fechaDeApertura;
        }
        public string Info()
        {
            string info = "nombre: " + nombre + "   direccion;" + direccion + "\n";
            return info;
        }
        public string Info(List<Pelicula> peliculas)
        {
            BaseDeDatos bsd = BaseDeDatos.Deserialize_("batos.bin");
            string info = "nombre: " + nombre + "\ndireccion;" + direccion + "\nfecha de apertura: " + fechaDeApertura + " \n";
            info += "--------------------------\n";
            info += "peliculas que ha producido:\n";
            foreach (Pelicula p in bsd.peliculas)
            {
                if (p.estudio.direccion == this.direccion)
                {
                    info += "nombre de la pelicula: " + p.nombre + "\n Descripcion: " + p.descripcion + "\n";
                    info += "--------------------------\n";

                }
            }
            
            return info;
        }
    }
}
