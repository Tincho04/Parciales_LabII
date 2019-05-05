using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region "Atributos"
        private string apellido;
        private string documento;
        private string nombre;
        #endregion

        #region "Propiedades"
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
                this.documento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region "Constructores"
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }
        #endregion

        #region "Metodos"
        public virtual string ExponerDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Nombre: {0}\nApellido: {1}\nDocumento: {2}", this.Nombre, this.Apellido, this.Documento);
            return s.ToString();
        }

        public abstract bool ValidarDocumentacion(string doc);
        #endregion

    }
}
