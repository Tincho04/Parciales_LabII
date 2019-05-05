using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if(this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        #endregion

        #region Métodos

        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("\nNombre: {0} - Apellido: {1} - Documento: {2}", this.Nombre, this.Apellido, this.Documento);

            return datos.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public abstract bool ValidarDocumentacion(string documentacion);
        
        #endregion
    }
}
