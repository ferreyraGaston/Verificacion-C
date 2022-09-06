namespace ActivParcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtNombre = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.Label();
            this.TxtNac = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextDni = new System.Windows.Forms.TextBox();
            this.TextFecha = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Lbn_Resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.AutoSize = true;
            this.TxtNombre.Location = new System.Drawing.Point(46, 52);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(44, 13);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Text = "Nombre";
            // 
            // TxtDni
            // 
            this.TxtDni.AutoSize = true;
            this.TxtDni.Location = new System.Drawing.Point(46, 103);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(29, 13);
            this.TxtDni.TabIndex = 1;
            this.TxtDni.Text = "DNI:";
            // 
            // TxtNac
            // 
            this.TxtNac.AutoSize = true;
            this.TxtNac.Location = new System.Drawing.Point(46, 151);
            this.TxtNac.Name = "TxtNac";
            this.TxtNac.Size = new System.Drawing.Size(63, 13);
            this.TxtNac.TabIndex = 2;
            this.TxtNac.Text = "Fecha Nac:";
            // 
            // TxtEdad
            // 
            this.TxtEdad.AutoSize = true;
            this.TxtEdad.Location = new System.Drawing.Point(99, 222);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(35, 13);
            this.TxtEdad.TabIndex = 3;
            this.TxtEdad.Text = "Edad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Btn_Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Btn_Edad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(149, 52);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(196, 20);
            this.TextNombre.TabIndex = 6;
            // 
            // TextDni
            // 
            this.TextDni.Location = new System.Drawing.Point(149, 100);
            this.TextDni.Name = "TextDni";
            this.TextDni.Size = new System.Drawing.Size(196, 20);
            this.TextDni.TabIndex = 7;
            this.TextDni.Validating += new System.ComponentModel.CancelEventHandler(this.TextDni_Validating);
            // 
            // TextFecha
            // 
            this.TextFecha.Location = new System.Drawing.Point(149, 148);
            this.TextFecha.Name = "TextFecha";
            this.TextFecha.Size = new System.Drawing.Size(196, 20);
            this.TextFecha.TabIndex = 8;
            this.TextFecha.Validating += new System.ComponentModel.CancelEventHandler(this.TextFecha_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Lbn_Resultado
            // 
            this.Lbn_Resultado.AutoSize = true;
            this.Lbn_Resultado.Location = new System.Drawing.Point(201, 222);
            this.Lbn_Resultado.Name = "Lbn_Resultado";
            this.Lbn_Resultado.Size = new System.Drawing.Size(37, 13);
            this.Lbn_Resultado.TabIndex = 9;
            this.Lbn_Resultado.Text = "..........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 301);
            this.Controls.Add(this.Lbn_Resultado);
            this.Controls.Add(this.TextFecha);
            this.Controls.Add(this.TextDni);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNac);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.TxtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtNombre;
        private System.Windows.Forms.Label TxtDni;
        private System.Windows.Forms.Label TxtNac;
        private System.Windows.Forms.Label TxtEdad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextDni;
        private System.Windows.Forms.TextBox TextFecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Lbn_Resultado;
    }
}

