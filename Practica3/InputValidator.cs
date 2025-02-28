using System;
using System.Collections.Generic;
using System.Linq; // Esta libreria se utiliza en el caso 2 para verificar 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    internal class InputValidator
    {
        // CASO 1: Verifacion mediante KeyChar
        public bool EsSoloNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                return false;
            }
            return true;
        }

        public bool EsSoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122))
            {
                e.Handled = true;
                return false;
            }
            return true;
        }

        // CASO 2: Verificacion mediante metodos con LINQ

        //public bool EsSoloNumeros(string texto)
        //{
        //    if (string.IsNullOrWhiteSpace(texto))
        //    {
        //        return false;
        //    }
        //
        //    return texto.All(char.IsDigit);
        //}
        //public bool EsSoloLetras(string texto)
        //{
        //    if (string.IsNullOrWhiteSpace(texto))
        //    {
        //        return false;
        //    }
        //
        //   return texto.All(char.IsLetter);
        //}
        //
        //
        //
        // CASO 3: Verificación mediante ASCII sin interfaces gráficas
        // public bool EsSoloNumeros(string texto)
        //{
        //    if (string.IsNullOrWhiteSpace(texto))
        //    {
        //        return false;
        //    }
        //
        //    for (int i = 0; i < texto.Length; i++)
        //    {
        //        if (texto[i] < 48 || texto[i] > 57)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //
        //public bool EsSoloLetras(string texto)
        //{
        //   if (string.IsNullOrWhiteSpace(texto))
        //        return false;
        //
        //    for (int i = 0; i < texto.Length; i++)
        //    {
        //        if ((texto[i] < 65 || texto[i] > 90) && (texto[i] < 97 || texto[i] > 122))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
