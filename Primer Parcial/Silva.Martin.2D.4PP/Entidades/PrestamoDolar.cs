using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        #region Propiedad

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        #endregion

        #region Métodos

        private float CalcularInteres()
        {
            switch(this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    return (this.Monto * 25) / 100;
                case PeriodicidadDePagos.Bimestral:
                    return (this.Monto * 35) / 100;
                case PeriodicidadDePagos.Trimestral:
                    return (this.Monto * 40) / 100;
            }
            return 0;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan nuevoPlazo = nuevoVencimiento - this.Vencimiento;

            this.monto += (float)(2.5 * Convert.ToInt32(nuevoPlazo.Days));
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.Mostrar());
            datos.AppendFormat("Periodicidad: {0}", this.Periodicidad);
            datos.AppendFormat("Interes: {0}", this.Interes.ToString());

            return datos.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento,periodicidad)
        {

        }
        #endregion
    }
}
