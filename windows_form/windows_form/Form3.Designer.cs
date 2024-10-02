namespace windows_form
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplica = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbPotencia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(190, 89);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(100, 20);
            this.txtPrimero.TabIndex = 0;
            this.txtPrimero.Text = "0";
            this.txtPrimero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(190, 156);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 1;
            this.txtSegundo.Text = "0";
            this.txtSegundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(377, 85);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 56);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(397, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(137, 31);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPotencia);
            this.groupBox1.Controls.Add(this.rbDivide);
            this.groupBox1.Controls.Add(this.rbMultiplica);
            this.groupBox1.Controls.Add(this.rbResta);
            this.groupBox1.Controls.Add(this.rbSumar);
            this.groupBox1.Location = new System.Drawing.Point(214, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rbSumar
            // 
            this.rbSumar.AutoSize = true;
            this.rbSumar.Checked = true;
            this.rbSumar.Location = new System.Drawing.Point(43, 58);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(55, 17);
            this.rbSumar.TabIndex = 0;
            this.rbSumar.TabStop = true;
            this.rbSumar.Text = "Sumar";
            this.rbSumar.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(43, 96);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(53, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMultiplica
            // 
            this.rbMultiplica.AutoSize = true;
            this.rbMultiplica.Location = new System.Drawing.Point(163, 58);
            this.rbMultiplica.Name = "rbMultiplica";
            this.rbMultiplica.Size = new System.Drawing.Size(72, 17);
            this.rbMultiplica.TabIndex = 2;
            this.rbMultiplica.Text = "Multiplicar";
            this.rbMultiplica.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(163, 96);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(54, 17);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.Text = "Dividir";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbPotencia
            // 
            this.rbPotencia.AutoSize = true;
            this.rbPotencia.Location = new System.Drawing.Point(255, 70);
            this.rbPotencia.Name = "rbPotencia";
            this.rbPotencia.Size = new System.Drawing.Size(67, 17);
            this.rbPotencia.TabIndex = 4;
            this.rbPotencia.Text = "Potencia";
            this.rbPotencia.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimero);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimero;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPotencia;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiplica;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbSumar;
    }
}