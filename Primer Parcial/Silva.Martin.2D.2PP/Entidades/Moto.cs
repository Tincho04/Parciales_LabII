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
        static int valorHora;

        #region Métodos

        static Moto()
        {
            valorHora = 30;          
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHoraNuevo) :  this(patente, cilindrada, ruedas)
        {   
            valorHora = valorHoraNuevo;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("Cilindrada: {0} ", this.cilindrada.ToString());
            datos.AppendFormat("Ruedas: {0} ", this.ruedas.ToString());
            datos.AppendFormat("Valor hora: ${0} ", valorHora.ToString());

            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Moto)
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

            datos.AppendFormat("TICKET: {0} ", base.ImprimirTicket());
            datos.AppendFormat("COSTO: ${0} ", Convert.ToString(((int)(horas.Hours) * valorHora)));
            datos.AppendLine(this.ConsultarDatos());

            return datos.ToString();
        }
        #endregion

    }
}
