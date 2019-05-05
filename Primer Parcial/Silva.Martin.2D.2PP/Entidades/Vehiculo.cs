using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        #region Propiedades

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length == 6 && value != null)
                {
                    this.patente = value;
                }
            }
        }

        #endregion

        #region Métodos

        public abstract string ConsultarDatos();

        /// <summary>
        /// Retorna el horario de ingreso y patente del vehiculo
        /// </summary>
        /// <returns>Retorna los datos en un solo string</returns>
        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(this.ToString());
            datos.AppendFormat("Fecha: {0} \n",this.ingreso.Date.ToString());
            datos.AppendLine(this.ToString());

            return datos.ToString();
        }


        public override string ToString()
        {
            // "Patente {0}"
            return String.Format("Patente {0} ",this.Patente);
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        #endregion

        #region Operadores

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return !(vehiculoUno == vehiculoDos);
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            if (vehiculoUno.Equals(vehiculoDos) && vehiculoUno.Patente == vehiculoDos.Patente)
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
