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
        static int valorHora;

        #region Métodos

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHoraNuevo) : this(patente,modelo)
        {
            valorHora = valorHoraNuevo;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(this.ToString());
            datos.AppendFormat("Modelo: {0} ",this.modelo.ToString());
            datos.AppendFormat("Valor hora: ${0} ", valorHora.ToString());

            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is PickUp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder("");
            TimeSpan horas = DateTime.Now - this.ingreso;

            datos.AppendFormat("TICKET: {0} ",base.ImprimirTicket());
            datos.AppendFormat("COSTO: ${0} ", Convert.ToString(((int)(horas.Hours) * valorHora)));
            datos.AppendLine(this.ConsultarDatos());

            return datos.ToString();
        }
        #endregion

    }
}
