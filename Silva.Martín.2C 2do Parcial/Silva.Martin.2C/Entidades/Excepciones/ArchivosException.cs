using System;

namespace Entidades
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Excepción a raiz de un problema con el archivo, mediante innerException
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) : base("Surgio un problema con el archivo", innerException)
        {
            Texto texto = new Texto();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
            texto.Guardar(route, innerException.Message);
        }
    }
}
