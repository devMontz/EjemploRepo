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
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);

            lblIMC.Text = imc.ToString("F2");
            lblIMC.Visible = true;

            string clasificacion = string.Empty;
            string imagenPath = string.Empty;

            if (imc < 16.9)
            {
                clasificacion = "Muy bajo peso";
                imagenPath = @"./img/img1.jpg";
            }
            else if (imc >= 17 && imc <= 18.4) {

                clasificacion = "Bajo Peso";
                imagenPath = @"./img/img2.png";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                clasificacion = "Peso Normal";
                imagenPath = @"./img/img3.jpg";
            }
            else if (imc >= 25 && imc <= 29.9)
            {

                clasificacion = "SobrePeso";
                imagenPath = @"./img/img4.jpeg";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                clasificacion = "Obesidad grado 1";
                imagenPath = @"./img/img5.jpg";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                clasificacion = "Obesidad grado 2";
                imagenPath = @"./img/img6.jpg";
            }
            else if (imc >40)
            {
                clasificacion = "Obesidad grado 3";
                imagenPath = @"./img/img7.jpg";
            }

            lblClasificacion.Text = clasificacion;
            lblClasificacion.Visible = true;

            picbox.Image = Image.FromFile(imagenPath);
            picbox.Visible = true;

        }
    }
}
