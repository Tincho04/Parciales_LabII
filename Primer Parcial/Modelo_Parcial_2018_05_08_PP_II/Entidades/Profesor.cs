using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        #region "Atributos"
        private DateTime fechaIngreso;
        #endregion

        #region "Propiedades"
        public int Antiguedad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                return (fechaActual - fechaIngreso).Days;
            }
        }
        #endregion

        #region "Constructores"
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento) { }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        #endregion

        #region "Metodos"
        public override string ExponerDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\n{0}\n{1}", base.ExponerDatos(), this.Antiguedad);
            return s.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
        #endregion
    }
}
