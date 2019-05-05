using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        /// <summary>
        /// Metodo de clase que setea el valor hora
        /// </summary>
        static PickUp()
        {
            valorHora = 70;
        }

        /// <summary>
        /// Constructor con los parametros patente, modelo
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        public PickUp(string patente, string modelo):base(patente)
        {
            this.modelo = modelo;
        }
        /// <summary>
        /// Constructor con los parametros patente, modelo, valor hora
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        /// <param name="valorH"></param>
        public PickUp(string patente, string modelo, int valorH):base(patente)
        {
            this.modelo = modelo;
            valorHora = valorH;
        }

        /// <summary>
        /// Metodo para mostrar los datos de la pick up
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("\nModelo: {0}",this.modelo);
            sb.AppendFormat("\nValor Hora: {0}", valorHora.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que imprime el ticket de la estadia de la pick up. Calcula el precio
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
