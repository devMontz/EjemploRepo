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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.Show();
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(tBoxClave.Text);
            lista.SubItems.Add(tBoxNombre.Text);
            lista.SubItems.Add(tBoxApellido.Text);
            listView1.Items.Add(lista);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems) {
                lista.Remove();
            } 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
