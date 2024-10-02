using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormIMC = new FrmIMC();
            FormIMC.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormCal = new FrmCalculadora();
            FormCal.Show();
        }
    }
}
