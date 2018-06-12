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
        int fechaDeNacimiento;
        string biografia;
        public string profesion;

        public Person(string nombre, string apellido, int fechaDeNacimiento, string biografia,string profsion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.biografia = biografia;
            this.profesion = profesion;
        }
    }
}
