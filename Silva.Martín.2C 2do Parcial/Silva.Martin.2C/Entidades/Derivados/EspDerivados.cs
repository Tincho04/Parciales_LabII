using System;
using System.Collections.Generic;

namespace Entidades
{
    public class EspDerivados
    {
        #region Atributos
        private int id;
        private string apellido;
        private string nombre;
        private int edad;
        private string sexo;
        private string direccion;
        private string campo;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
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
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
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

        public string Campo
        {
            get { return campo; }
            set { campo = value; }
        }

        #endregion

        #region Constructores
        public EspDerivados()
        {
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Llamador al método de lectura para archivos del tipo XML, con el cual obtendremos la lista de especialistas derivados
        /// </summary>
        /// <returns></returns>
        public static List<EspDerivados> Leer()
        {
            XML<EspDerivados> xml = new XML<EspDerivados>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\DoctoresSegundaClinica.xml";
            xml.Leer(archivo, out List<EspDerivados> especialistaDerivado);
            return especialistaDerivado;
        }

        /// <summary>
        /// Método que cargará una lista de especialidades, procurando que esta no se encuentre repetida
        /// </summary>
        /// <param name="especialistas"></param>
        /// <returns></returns>
        public static List<string> BuscarEspecialidad(List<EspDerivados> especialistas)
        {
            List<string> especialidades = new List<string>();
            foreach (EspDerivados e in especialistas)
            {
                if (!especialidades.Contains(e.Campo))
                {
                    especialidades.Add(e.Campo);
                }
            }
            return especialidades;
        }

        /// <summary>
        /// Método que devolverá un listado de especialistas filtrado por la especialidad deseada
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public static List<EspDerivados> Leer(string filtro)
        {
            XML<EspDerivados> xml = new XML<EspDerivados>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\ArchivosClinica\\DoctoresSegundaClinica.xml";
            xml.Leer(archivo, out List<EspDerivados> especialistaDerivado, filtro);
            return especialistaDerivado;
        }
        #endregion
    }
}
