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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double primer = 0.0;
            double segundo = 0.0;   
            double resultado = 0.0;

            primer = Convert.ToDouble(txtPrimero.Text);
            segundo = Convert.ToDouble(txtSegundo.Text);

            if (rbSumar.Checked == true) {
                resultado = primer + segundo;
            }
            else if (rbResta.Checked == true)
            {
                resultado = primer - segundo;
            }
            else if (rbMultiplica.Checked == true)
            {
                resultado = primer * segundo;
            }
            else if (rbDivide.Checked == true)
            {
                if (segundo == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;   
                }
                resultado = primer / segundo;
            }
            else if (rbPotencia.Checked == true)
            {
                resultado = Math.Pow(primer, segundo);
            }


            lblResultado.Text = resultado.ToString();
        }
    }
}
