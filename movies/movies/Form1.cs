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
        BaseDeDatos bsd = BaseDeDatos.Deserialize_("batos.bin");
        List<Person> personas = new List<Person>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<Estudio> estudios = new List<Estudio>();
        List<PeliculaActor> peliculaActors = new List<PeliculaActor>();
        List<PeliculaProductor> peliculaProductors = new List<PeliculaProductor>();
        


        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            
            

        }

      

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            
           if(texSearch.Text.Length > 2)
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
                            InfoSearch.Items.Add(p.Info());
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
                            InfoSearch.Items.Add(p.Info());
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
                            InfoSearch.Items.Add(p.Info());
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
                            InfoSearch.Items.Add(p.Info());
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
                            InfoSearch.Items.Add(p.Info());
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
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach  (Pelicula p in this.bsd.peliculas)
            {
                InfoSearch.Items.Add(p.Info());
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
                    InfoSearch.Items.Add(p.Info());
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
                    InfoSearch.Items.Add(p.Info());
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
                    InfoSearch.Items.Add(p.Info());
                }

            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            InfoSearch.Items.Clear();
            InfoSearch.Visible = true;
            foreach (Estudio p in this.bsd.estudios)
            {   
                InfoSearch.Items.Add(p.Info());
            }
        }

        private void texSearch_Click(object sender, EventArgs e)
        {
            texSearch.Clear();
            InfoSearch.Items.Clear();
        }

        private void InfoSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoItem.Text = " ";
            
            foreach (Pelicula item in this.bsd.peliculas)
            {
                
                if (InfoSearch.SelectedItem.ToString() ==(item.Info()))
                {
                    
                    string inf = item.Info(peliculaActors, peliculaProductors);
                    InfoItem.Text += inf;
                }

              
            }
            foreach (Person item in this.bsd.personas)
            {
           
                    
                    if (InfoSearch.SelectedItem.Equals(item.Info()))
                    {
                        string inf= item.Info(peliculaActors, peliculaProductors);
                        InfoItem.Text += inf;
                    }

            
            }
            foreach (Estudio item in this.bsd.estudios)
            {
            
                    
                    if (InfoSearch.SelectedItem.Equals(item.Info()))
                    {
                        string inf = item.Info(peliculas);
                        InfoItem.Text += inf;
                    }

            
            }


        }
    }
}
