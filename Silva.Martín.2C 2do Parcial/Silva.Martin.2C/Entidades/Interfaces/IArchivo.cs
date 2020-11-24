using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {
        #region Metodos
        /// <summary>
        /// Aquí se encontrarán los métodos para guardar y leer que serán implementados para los casos Binario y TXT.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        bool Leer(string archivo, out T dato);
        #endregion
    }
}
