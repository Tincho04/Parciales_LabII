using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;
        /// <summary>
        /// Constructor de clase que setea el valor hora
        /// </summary>
        static Moto()
        {
            valorHora = 30;
        }

        /// <summary>
        /// Constructor con los parametros patente, cilindrada
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        public Moto(string patente, int cilindrada):base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }
        /// <summary>
        /// Constructor con los parametros patente, cilindrada, ruedas
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        public Moto(string patente, int cilindrada, short ruedas):base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }

        /// <summary>
        /// Constructor con los parametros patente, cilindrada, ruedas, valor hora
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        /// <param name="valorH"></param>
        public Moto(string patente, int cilindrada, short ruedas, int valorH) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            valorHora = valorH;
        }

        /// <summary>
        /// Metodo para mostrar los datos de la moto
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("\nCilindradas: {0}", this.cilindrada);
            sb.AppendFormat("\nRuedas: {0}", this.ruedas);
            sb.AppendFormat("\nValor Hora: {0}", valorHora);
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que imprime el ticket de la estadia de la moto. Calcula el precio
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
