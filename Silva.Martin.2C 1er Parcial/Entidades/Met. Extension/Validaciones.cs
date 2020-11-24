using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Método de extensión que nos permite validar que el dato string no se encuentre vacío.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidarString(this string texto)
        {
            return (texto != string.Empty);
        }

        public static bool ValidarDerivado(string deriva)
        {

            return false;
        }
    }
}
