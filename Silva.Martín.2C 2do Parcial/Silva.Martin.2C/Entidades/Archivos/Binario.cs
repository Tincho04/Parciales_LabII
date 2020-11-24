using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public class Binario<T> : IArchivo<T>
    {
        /// <summary>
        /// Proceso de guardado para archivo Binario
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, datos);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
        /// <summary>
        /// proceso de lectura para archivo binario
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read);
                datos = (T)formatter.Deserialize(stream);
                return true;
            }
            catch (Exception)
            {
                datos = default(T);
                return false;
            }
            finally
            {
                if (!ReferenceEquals(stream, null))
                    stream.Close();
            }
        }
    }
}
