using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        #region Propiedades

        public int Antiguedad
        {
            get
            {
                TimeSpan antiguedad = this.fechaIngreso - DateTime.Now;
                
                return antiguedad.Days;
            }
        }

        #endregion

        #region Métodos

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.ExponerDatos());
            datos.AppendFormat("\nFecha ingreso: {0} - Antigüedad: {1}", this.fechaIngreso.ToString(),
            this.Antiguedad.ToString());

            return datos.ToString();
        }

        public override bool ValidarDocumentacion(string documento)
        {
            if(documento.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
