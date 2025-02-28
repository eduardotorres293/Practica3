using System;
using System.Collections.Generic;
using System.Linq; // Esta libreria se utiliza en el caso 1 para verificar 
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class InputValidator
    {
        // CASO 1: Verificacion mediante metodos con LINQ

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

        // CASO 2: Verificación mediante ASCII
        public bool EsSoloNumeros(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] < 48 || texto[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsSoloLetras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            for (int i = 0; i < texto.Length; i++)
            {
                if ((texto[i] < 65 || texto[i] > 90) && (texto[i] < 97 || texto[i] > 122))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
