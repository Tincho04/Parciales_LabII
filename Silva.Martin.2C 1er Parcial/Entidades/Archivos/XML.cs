using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class XML<T>
    {
        #region Metodos
        /// <summary>
        /// Método de escritura de datos para archivo formato XML
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    serializer.Serialize(writer, datos);
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
        /// Método de lectura del archivo XML para traer la lista de pacientes derivados
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        public void Leer(string archivo, out List<PacDerivados> datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);

            datos = new List<PacDerivados>();
            bool flag = true;
            try
            {
                while (reader.Read())
                {
                    PacDerivados derivado = new PacDerivados();
                    #region ValidacionTipoDeDato
                    #region ValidaID
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Id")
                    {
                        if (int.TryParse(reader.ReadElementString(), out int id))
                        {
                            derivado.Id = id;
                        }
                        else
                        {
                            flag = false;
                        }

                        #endregion
                        #region ValidaApellido
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Apellido")
                        {
                            derivado.Apellido = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaNombre
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Nombre")
                        {
                            derivado.Nombre = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaEdad
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Edad")
                        {
                            if (int.TryParse(reader.ReadElementString(), out int edad))
                            {
                                derivado.Edad = edad;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                        #endregion
                        #region ValidaSexo
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Sexo")
                        {
                            derivado.Sexo = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaDireccion
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Direccion")
                        {
                            derivado.Direccion = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaObraSocial
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "ObraSocial")
                        {
                            derivado.ObraSocial = reader.ReadElementString();
                        }
                        #endregion
                        #endregion
                        if (flag == true)
                        {
                            datos.Add(derivado);
                        }
                    }
                }
            }
            catch (ArchivosException a)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, a.Message);
            }
            catch (XmlException e)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, e.Message);
            }
        }

        /// <summary>
        /// método de lectura del archivo XML para traer la lista de especialistas derivados
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        public void Leer(string archivo, out List<EspDerivados> datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);

            datos = new List<EspDerivados>();
            bool flag = true;
            try
            {
                while (reader.Read())
                {
                    EspDerivados especialista = new EspDerivados();
                    #region ValidacionTipoDeDato
                    #region ValidaID
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Id")
                    {
                        if (int.TryParse(reader.ReadElementString(), out int id))
                        {
                            especialista.Id = id;
                        }
                        else
                        {
                            flag = false;
                        }

                        #endregion
                        #region ValidaApellido
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Apellido")
                        {
                            especialista.Apellido = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaNombre
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Nombre")
                        {
                            especialista.Nombre = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaEdad
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Edad")
                        {
                            if (int.TryParse(reader.ReadElementString(), out int edad))
                            {
                                especialista.Edad = edad;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                        #endregion
                        #region ValidaSexo
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Sexo")
                        {
                            especialista.Sexo = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaDireccion
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Direccion")
                        {
                            especialista.Direccion = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaObraSocial
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Campo")
                        {
                            especialista.Campo = reader.ReadElementString();
                        }
                        #endregion
                        #endregion
                        if (flag == true)
                        {
                            datos.Add(especialista);
                        }
                    }
                }
            }
            catch (System.IO.FileNotFoundException a)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, a.Message);
            }
        }

        /// <summary>
        /// método de lectura del archivo xml para filtrar los especialistas derivados por su especialidad
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <param name="filtro"></param>
        public void Leer(string archivo, out List<EspDerivados> datos, string filtro)
        {
            XmlTextReader reader = new XmlTextReader(archivo);

            datos = new List<EspDerivados>();
            bool flag = true;
            bool especialidad = false;
            try
            {
                while (reader.Read())
                {
                    EspDerivados especialista = new EspDerivados();
                    #region ValidacionTipoDeDato
                    #region ValidaID
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Id")
                    {
                        if (int.TryParse(reader.ReadElementString(), out int id))
                        {
                            especialista.Id = id;
                        }
                        else
                        {
                            flag = false;
                        }

                        #endregion
                        #region ValidaApellido
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Apellido")
                        {
                            especialista.Apellido = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaNombre
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Nombre")
                        {
                            especialista.Nombre = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaEdad
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Edad")
                        {
                            if (int.TryParse(reader.ReadElementString(), out int edad))
                            {
                                especialista.Edad = edad;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                        #endregion
                        #region ValidaSexo
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Sexo")
                        {
                            especialista.Sexo = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaDireccion
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Direccion")
                        {
                            especialista.Direccion = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaObraSocial
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Campo")
                        {
                            if (reader.ReadElementString() == filtro)
                            {
                                especialista.Campo = filtro;
                                especialidad = true;
                            }
                        }
                        #endregion
                        #endregion
                        if ((flag == true) && (especialidad == true))
                        {
                            datos.Add(especialista);
                            especialidad = false;
                        }
                    }
                }

            }
            catch (System.IO.FileNotFoundException a)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, a.Message);
            }
        }

        /// <summary>
        /// Método de lectura del archivo xml de los turnos
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        public void Leer(string archivo, out TurnoXML datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);
            string fechaAux = string.Empty;
            string apellidoAux = string.Empty;
            string nombreAux = string.Empty;
            datos = new TurnoXML();

            bool flag = true;
            try
            {
                while (reader.Read())
                {
                    PacDerivados derivado = new PacDerivados();
                    #region ValidacionTipoDeDato
                    #region ValidaFecha
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Fecha")
                    {
                        fechaAux = reader.ReadElementString();

                        #endregion
                        #region ValidaApellido
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Apellido")
                        {
                            apellidoAux = reader.ReadElementString();
                        }
                        #endregion
                        #region ValidaNombre
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Nombre")
                        {
                            nombreAux = reader.ReadElementString();
                        }
                        #endregion
                        #endregion
                        if (flag == true)
                        {
                            datos = new TurnoXML(fechaAux, apellidoAux, nombreAux);
                        }
                    }
                }
            }
            catch (ArchivosException a)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, a.Message);
            }
            catch (XmlException e)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, e.Message);
            }
        }
        #endregion
    }
}