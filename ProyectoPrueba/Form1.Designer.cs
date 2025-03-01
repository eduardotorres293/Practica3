namespace ProyectoPrueba
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExtendido1 = new Practica3.btnExtendido();
            this.txtNombre = new Practica3.txtBoxExtendido();
            this.txtTelefono = new Practica3.txtBoxExtendido();
            this.txtCorreo = new Practica3.txtBoxExtendido();
            this.txtRFC = new Practica3.txtBoxExtendido();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(190, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(190, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(190, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(190, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(319, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 420);
            this.listBox1.TabIndex = 15;
            // 
            // btnExtendido1
            // 
            this.btnExtendido1.Location = new System.Drawing.Point(12, 12);
            this.btnExtendido1.MensajeDobleClick = "Se realizó una acción de doble click, ¿Correcto?";
            this.btnExtendido1.Name = "btnExtendido1";
            this.btnExtendido1.Size = new System.Drawing.Size(159, 35);
            this.btnExtendido1.TabIndex = 20;
            this.btnExtendido1.TituloDobleClick = "Evento de doble click";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 32);
            this.txtNombre.ModoDeEntrada = Practica3.txtBoxExtendido.valor.WordsOnly;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Texto = "";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(194, 89);
            this.txtTelefono.ModoDeEntrada = Practica3.txtBoxExtendido.valor.NumbersOnly;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.Texto = "";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(194, 143);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 23;
            this.txtCorreo.Texto = "";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(194, 198);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 24;
            this.txtRFC.Texto = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnExtendido1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private Practica3.btnExtendido btnExtendido1;
        private Practica3.txtBoxExtendido txtNombre;
        private Practica3.txtBoxExtendido txtTelefono;
        private Practica3.txtBoxExtendido txtCorreo;
        private Practica3.txtBoxExtendido txtRFC;
    }
}

