using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {

        List<Pelicula> listaPeliculas = new List<Pelicula>();
        public Form2()
        {
            InitializeComponent();
        }

        public void CargarlistaPeliculas() {
            listaPeliculas.Add(new Pelicula("Reino Prohibido",(decimal)1.25));
            listaPeliculas.Add(new Pelicula("Avatar", (decimal)8.85));

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 next = new Form1();
            next.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelicula pelicula = (Pelicula)cBoxPeliculas.SelectedItem;
            tBoxPrecio.Text = pelicula.PrecioPelicula.ToString("#.##");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarlistaPeliculas();
            cBoxPeliculas.DataSource = listaPeliculas;
            cBoxPeliculas.DisplayMember = "NombrePelicula";
            cBoxPeliculas.ValueMember = "NombrePelicula";
        }
    }
}
