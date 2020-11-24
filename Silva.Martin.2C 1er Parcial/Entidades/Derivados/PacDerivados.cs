using System;
using System.Collections.Generic;

namespace Entidades
{
    public class PacDerivados
    {
        #region Atributos
        private int id;
        private string apellido;
        private string nombre;
        private int edad;
        private string sexo;
        private string direccion;
        private string obraSocial;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        #endregion

        #region Constructores
        public PacDerivados()
        {
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método que llamará a la lectura en XML para cargar la lista de pacientes que han sido derivados
        /// </summary>
        /// <returns></returns>
        public static List<PacDerivados> Leer()
        {
            XML<PacDerivados> xml = new XML<PacDerivados>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\PacientesSegundaClinica.xml";
            xml.Leer(archivo, out List<PacDerivados> pacienteDerivado);
            return pacienteDerivado;
        }
        #endregion
    }
}
