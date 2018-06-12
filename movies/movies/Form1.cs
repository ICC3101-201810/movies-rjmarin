using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;



namespace movies
{
    public partial class Form1 : Form
    {
        
        List<Person> personas = new List<Person>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<Estudio> estudios = new List<Estudio>();
        List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();
        BaseDeDatos bsd;
       
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(5000);
            label1.Visible = false;
            panel1.Visible = true;
            BinaryFormatter bif = new BinaryFormatter();
            FileStream fis = File.Open("Datos.bin", FileMode.OpenOrCreate);
            bsd = (BaseDeDatos)bif.Deserialize(fis);
            fis.Close();

        }

      

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
           if(texSearch.Text.Length > 3)
            {
                int countp = 0;
                int countpp = 0;
                int countppp = 0;
                foreach (Person p in this.bsd.personas)
                {
                    if (p.nombre.Contains(texSearch.Text))
                    {
                        if (!(InfoSearch.Items.Contains(p)))
                        {
                            InfoSearch.Items.Add(p);
                            countp++;
                        }
                        if (countp==20)
                        {
                            break;
                        }
                    }
                }
                foreach (Pelicula p in this.bsd.peliculas)
                {
                    if (p.nombre.Contains(texSearch.Text))
                    {
                        if (!(InfoSearch.Items.Contains(p)))
                        {
                            InfoSearch.Items.Add(p);
                            countpp++;
                        }
                        if (countpp == 15)
                        {
                            break;
                        }
                    }
                    else if(p.descripcion.Contains(texSearch.Text))
                    {
                        if (!(InfoSearch.Items.Contains(p)))
                        {
                            InfoSearch.Items.Add(p);
                            countpp++;
                        }
                        if (countpp == 15)
                        {
                            break;
                        }
                    }

                }
                foreach (Estudio p in this.bsd.estudios)
                {
                    if (p.nombre.Contains(texSearch.Text))
                    {
                        if (!(InfoSearch.Items.Contains(p)))
                        {
                            InfoSearch.Items.Add(p);
                            countpp++;
                        }
                        if (countppp == 15)
                        {
                            break;
                        }
                    }
                    else if (p.direccion.Contains(texSearch.Text))
                    {
                        if (!(InfoSearch.Items.Contains(p)))
                        {
                            InfoSearch.Items.Add(p);
                            countpp++;
                        }
                        if (countppp == 15)
                        {
                            break;
                        }
                    }

                }


            }
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            InfoSearch.Visible = true;
            foreach  (Pelicula p in this.bsd.peliculas)
            {
                InfoSearch.Items.Add(p);
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach (Person p in this.bsd.personas)
            {
                if(p.profesion== "actor")
                {
                    InfoSearch.Items.Add(p);
                }
                
            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach (Person p in this.bsd.personas)
            {
                if (p.profesion == "director")
                {
                    InfoSearch.Items.Add(p);
                }

            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach (Person p in this.bsd.personas)
            {
                if (p.profesion == "productor")
                {
                    InfoSearch.Items.Add(p);
                }

            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach (Estudio p in this.bsd.estudios)
            {   
                InfoSearch.Items.Add(p);
            }
        }
    }
}
