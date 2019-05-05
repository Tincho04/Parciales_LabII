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
        static int valorHora;

        #region Métodos

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHoraNuevo) : this(patente,color)
        {
            valorHora = valorHoraNuevo;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(this.ToString());
            datos.AppendFormat("Color: {0} ", this.color.ToString());
            datos.AppendFormat("Valor hora: {0} ", valorHora.ToString());

            return datos.ToString();
          }

        public override bool Equals(object obj)
        {
            if(obj is Automovil)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * El método ImprimirTicket de las siguientes clases agregará a la información descripta en Vehiculo el
            costo de la estadía, siendo este el resultado de la cantidad de horas desde su ingreso hasta ahora *
            el valor de la hora. 
         * */
        public override string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder("");
            TimeSpan horas = DateTime.Now - this.ingreso;

            datos.AppendFormat("TICKET: {0} ", base.ImprimirTicket());
            datos.AppendFormat("COSTO: ${0} ", Convert.ToString(((int)(horas.Hours) * valorHora)));
            datos.AppendLine(this.ConsultarDatos());

            return datos.ToString();
        }
        #endregion

    }
}
