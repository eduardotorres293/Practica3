using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class btnExtendido: UserControl
    {
        public btnExtendido()
        {
            InitializeComponent();
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button1.MouseDown += Button1_MouseDown;
        }
        public void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        public void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = default(Color);
        }

        public void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                DialogResult confirmacion = MessageBox.Show("Se realizó una acción de doble click, ¿Correcto?", "Evento de doble click", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("//PlaceholderYes");
                }
                else
                {
                    MessageBox.Show("//PlaceholderNo");
                }
            }
        }
    }
}
