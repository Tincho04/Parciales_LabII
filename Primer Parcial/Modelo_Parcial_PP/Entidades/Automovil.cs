using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        /// <summary>
        /// constructor de clase que setea el valor hora
        /// </summary>
        static Automovil()
        {
            valorHora = 50;
        }

        /// <summary>
        /// constructor con los parametros patente y color
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            this.color = color;
        }

        /// <summary>
        /// constructor con los parametros patente, color y valor hora
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        /// <param name="valorH"></param>
        public Automovil(string patente, ConsoleColor color, int valorH):base(patente)
        {
            this.color = color;
            valorHora = valorH;
        }

        /// <summary>
        /// Metodo para mostrar los datos del automovil
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.color.ToString());
            sb.AppendLine(valorHora.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que imprime el ticket de la estadia del automovil. Calcula el precio
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now - base.ingreso;
            int estadia = ts.Hours;
            int precio = estadia * valorHora;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendFormat("Precio: {0}", precio);

            return sb.ToString();
        }
    }
}
