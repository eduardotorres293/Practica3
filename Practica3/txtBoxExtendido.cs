using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class txtBoxExtendido : UserControl
    {
        public txtBoxExtendido()
        {
            InitializeComponent();
            textBox1.KeyPress += TxtInput_KeyPress;
        }

        public enum valor
        {
            NumbersOnly, WordsOnly, Both
        }

        private valor modoElegido = valor.Both;

        [Category("Behavior")]
        [Description("Define si solo se aceptan números, letras o ambos")]
        [DefaultValue(valor.Both)]

        // Esta parte la deje en español para que sea fácil de diferenciar entre las otras
        public valor ModoDeEntrada
        {
            get { return modoElegido; }
            set { modoElegido = value; }
        }

        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esInvalido = false;
            switch (modoElegido)
            {
                case valor.NumbersOnly:
                    if ((e.KeyChar >= 65 && e.KeyChar <= 122) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        esInvalido = true;
                    }
                    break;
                case valor.WordsOnly:
                    if (!(e.KeyChar >= 65 && e.KeyChar <= 122) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        esInvalido = true;
                    }
                    break;
                case valor.Both:
                    break;
            }
            if (esInvalido)
            {
                textBox1.BackColor = Color.LightPink;
                textBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                textBox1.BackColor = default(Color);
                textBox1.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
