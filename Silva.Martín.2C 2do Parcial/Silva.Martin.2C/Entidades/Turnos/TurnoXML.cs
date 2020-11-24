using System;

namespace Entidades
{
    [Serializable]
    public class TurnoXML : Turnos
    {
        #region Constructores
        public TurnoXML()
        {
        }

        public TurnoXML(string apellidoPaciente, string nombrePaciente) : base(apellidoPaciente, nombrePaciente)
        {
        }

        public TurnoXML(string fecha, string apellidoPaciente, string nombrePaciente) : this(apellidoPaciente, nombrePaciente)
        {
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método que llamará al proceso de guardado para un archivo XML
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public static bool Guardar(TurnoXML turno)
        {
            bool retorno = false;
            XML<TurnoXML> xml = new XML<TurnoXML>();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TurnosClinica\\Turnos.xml";
            if (xml.Guardar(route, turno))
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Método especial que replica el guardado xml hacia una carpeta de testeo
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public static bool GuardaTestXML(TurnoXML turno)
        {
            bool retorno = false;
            XML<TurnoXML> xml = new XML<TurnoXML>();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TurnosClinica\\TurnoTest.xml";
            if (xml.Guardar(route, turno))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// método que nos permitirá disparar el proceso de guardado para archivo binario
        /// </summary>
        /// <param name="turno"></param>
        /// <returns></returns>
        public static bool GuardarBinario(TurnoXML turno)
        {
            bool retorno = false;
            XML<TurnoXML> xml = new XML<TurnoXML>();
            string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TurnosClinica\\Turnos.dat";
            if (xml.Guardar(route, turno))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Método que disparará la lectura del archivo de tipo binario para la carga de un turno
        /// </summary>
        /// <returns></returns>
        public static TurnoXML LeerBin()
        {
            Binario<TurnoXML> bin = new Binario<TurnoXML>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\PacientesSegundaClinica.dat";
            bin.Leer(archivo, out TurnoXML turnos);
            return turnos;
        }


        /// <summary>
        /// Método que ejecutará el proceso que nos permitirá leer un archivo xml para obtener un turno
        /// </summary>
        /// <returns></returns>
        public static TurnoXML Leer()
        {
            XML<TurnoXML> xml = new XML<TurnoXML>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\TurnosClinica\\Turnos.xml";
            xml.Leer(archivo, out TurnoXML turnos);
            return turnos;
        }
        #endregion
    }
}
