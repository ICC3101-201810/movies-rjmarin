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
        int fechaDeApertura;

        public Estudio(string nombre, string direccion, int fechaDeApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaDeApertura = fechaDeApertura;
        }
    }
}
