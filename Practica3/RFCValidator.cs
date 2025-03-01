using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica3
{
    public class RFCValidator
    {
        public bool validarRFC(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            string personaFisica = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";

            string personaMoral = @"^[A-Z]{3}\d{6}[A-Z0-9]{3}$";

            return Regex.IsMatch(texto, personaFisica) || Regex.IsMatch(texto, personaMoral);
        }
        public string CorregirRFC(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            texto = texto.ToUpper();
            return texto;
        }

        public bool esPersonaFisica(string texto)
        {
            string patronPersonaFisica = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";
            if(Regex.IsMatch(texto, patronPersonaFisica) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
