using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        #region Propiedades

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }


        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }


        #endregion

        #region Métodos

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);
        
        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("\nMonto: {0} - Vencimiento: {1}", this.Monto, this.vencimiento);

            return datos.ToString();
        }

        public static int OrdenarPorFecha(Prestamo prestamoUno, Prestamo prestamoDos)
        {
            if(prestamoUno.Vencimiento > prestamoDos.Vencimiento)
            {
                return 1;
            }
            else if(prestamoUno.Vencimiento < prestamoDos.Vencimiento)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }


        #endregion

    }
}
