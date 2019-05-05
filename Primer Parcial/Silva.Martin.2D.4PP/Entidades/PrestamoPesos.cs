using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        #region Propiedad

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        #endregion

        #region Métodos

        private float CalcularInteres()
        {
            return (this.Monto * this.porcentajeInteres) / 100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan nuevoPlazo = nuevoVencimiento - this.Vencimiento;

            this.porcentajeInteres = (25 * Convert.ToInt32(nuevoPlazo.Days)) / 100;
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.Mostrar());
            datos.AppendFormat("Porcentaje interes: {0}", this.porcentajeInteres);
            datos.AppendFormat("Interes: {0}",this.Interes.ToString());

            return datos.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres) 
        {
            
        }
        #endregion
    }
}

