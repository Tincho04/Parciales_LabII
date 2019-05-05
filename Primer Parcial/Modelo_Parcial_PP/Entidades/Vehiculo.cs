using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{///
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="patente"></param>
        /// 
        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        /// <summary>
        /// Propiedad de lectura/escritura del atributo patente
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }

            set
            {
                if (value.Length == 6)
                    this.patente = value;
                else
                    this.patente ="";
            }
        }
        /// <summary>
        /// Metodo abstracto que muestra los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public abstract string ConsultarDatos();

        /// <summary>
        /// Sobreescritura del metodo ToString() que muestra la patente del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string patenteAux = String.Format("Patente {0}", this.patente);
            return patenteAux;
        }

        /// <summary>
        /// Metodo virtual que muestra la patente y el ingreso del vehiculo al estacionamiento
        /// </summary>
        /// <returns></returns>
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine(this.ingreso.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si coinciden su patente y su tipo
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return ((v1.Patente == v2.Patente) && (v1.GetType() == v2.GetType()));
        }

        public static bool operator != (Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


       


    }
}
