using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace movies
{
    [Serializable]
    class BaseDeDatos
    {
        public List<Person> personas = new List<Person>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<Estudio> estudios = new List<Estudio>();
        public List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();

        public BaseDeDatos()
        {
            this.Fill();
        }

        public void  Fill(){
            Random random = new Random();
            List<string> nombres = new List<string>();
            List<string> apellidos = new List<string>();
            List<string> direccions = new List<string>();
            List<string> descripcions = new List<string>();
            List<String> profes = new List<string>();
            List<string> nom_peli = new List<string>();
            nombres.Add("jaime");
            nombres.Add("peter");
            nombres.Add("rai");
            nombres.Add("hugo");
            nombres.Add("tomas");
            nombres.Add("sergio");
            nombres.Add("camila");
            nombres.Add("andrea");
            apellidos.Add("marin");
            apellidos.Add("de la fuente");
            apellidos.Add("marcahnt");
            apellidos.Add("olivares");
            apellidos.Add("fuchs");
            apellidos.Add("grand");
            direccions.Add("basel");
            direccions.Add("calle parque");
            direccions.Add("nueva provi");
            direccions.Add("berna");
            direccions.Add("peor es nada");
            direccions.Add("calma");
            direccions.Add("pernicues");
            descripcions.Add("mala");
            descripcions.Add("buena");
            direccions.Add("honguito");
            descripcions.Add("super mala");
            descripcions.Add("super buena");
            descripcions.Add("piola");
            descripcions.Add("pa chuparse los mocos");
            descripcions.Add("un manjar de dios");
            profes.Add("actor");
            profes.Add("director");
            profes.Add("productor");
            nom_peli.Add("harry ");
            nom_peli.Add("potter");
            nom_peli.Add("los increibles");
            nom_peli.Add("persia");
            nom_peli.Add("mammut");
            nom_peli.Add("shrek");
            nom_peli.Add("iron man");
            nom_peli.Add("avengers");
            nom_peli.Add("hulk");
            nom_peli.Add("thor");



            for (int i = 0; i < 25; i++)
            {
                
                string name = nombres[random.Next(nombres.Count())];
                string appellido1 = apellidos[random.Next(apellidos.Count())];
                string prof = profes[random.Next(profes.Count())];
                string bio = descripcions[random.Next(descripcions.Count())];
                int año = random.Next(40) + 1966;
                int mes = random.Next(11)+1;
                int dia = random.Next(27)+1;

                Person p = new Person(name, appellido1,new DateTime(año , mes ,dia) , bio, prof);
                personas.Add(p);
                string name1 = nombres[random.Next(nombres.Count())];
                int año1 = random.Next(55) + 1966;
                int mes1 = random.Next(11)+1;
                int dia1 = random.Next(27)+1;
                string direc = direccions[random.Next(direccions.Count())];
                Estudio estu = new Estudio(name1, direc, new DateTime(año1, mes1, dia1));
                estudios.Add(estu);




 
            }
            for (int i = 0; i < 40; i++)
            {
                string nomm = nom_peli[random.Next(nom_peli.Count())];
                Person pp = personas[random.Next(personas.Count())];
                while (pp.profesion!= "director")
                {
                     pp = personas[random.Next(personas.Count())];
                }

                Estudio est = estudios[random.Next(estudios.Count())];
                int año1 = random.Next(55) + 2000;
                int mes1 = random.Next(11)+1;
                int dia1 = random.Next(27)+1;
                long pres = random.Next(999999000) + 10000000000000;
                string bio = descripcions[random.Next(descripcions.Count())];
                Pelicula peli = new Pelicula(nomm, pp, new DateTime(año1, mes1, dia1), bio, pres, est);
                peliculas.Add(peli);



            }

            for (int i = 0; i < peliculas.Count; i++)
            {
                int rando = random.Next(7);
                for (int k = 0; k < rando; k++)
                {
                    Pelicula pp = peliculas[random.Next(peliculas.Count())];
                    Person pers = personas[random.Next(personas.Count())];
                    while (pers.profesion != "actor")
                    {
                        pers = personas[random.Next(personas.Count())];
                    }
                    PeliculaActor pa = new PeliculaActor(pp, pers);
                    peliculaActors.Add(pa);

                }
                int rand = random.Next(3);
                for (int j = 0; j < rand; j++)
                {
                    Pelicula pp = peliculas[random.Next(peliculas.Count())];
                    Person pers = personas[random.Next(personas.Count())];
                    while (pers.profesion != "productor")
                    {
                        pers = personas[random.Next(personas.Count())];
                    }
                    PeliculaProductor pa = new PeliculaProductor(pp, pers);
                    peliculaProductors.Add(pa);

                }


            }

        }

        public BaseDeDatos(List<Person> personas, List<Pelicula> peliculas, List<Estudio> estudios, List<PeliculaActor> peliculaActors, List<PeliculaProductor> peliculaProductors)
        {
            this.personas = personas;
            this.peliculas = peliculas;
            this.estudios = estudios;
            this.peliculaActors = peliculaActors;
            this.peliculaProductors = peliculaProductors;
        }
        public static void Serialize_Base(string file_name, BaseDeDatos bsd)
        {
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, bsd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static BaseDeDatos Deserialize_(string file_name)
        {
            BaseDeDatos output;
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    output = (BaseDeDatos)bin.Deserialize(stream);
                }
                return output;
            }
            catch (Exception )
            {
                output = new BaseDeDatos();
                return output;
            }

        }
    }
}
