using System;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivo<string>
    {
        #region Metodos
        /// <summary>
        ///  Proceso de guardado para archivo de Texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        /// 
        public bool Guardar(string archivo, string log)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, File.Exists(archivo)))
                    writer.WriteLine(log);
                retorno = true;
            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, ex.Message);
            }

            return retorno;
        }
        /// <summary>
        /// proceso de lectura para archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string dato)
        {
            bool retorno = false;
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    dato = reader.ReadToEnd();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            return retorno;
        }
        #endregion
    }
}
