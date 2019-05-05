using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        #region Propiedades

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        #endregion

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamos)
        {
            float intereses = 0;

            switch (tipoPrestamos)
            {
                case TipoDePrestamo.Dolares:
                    foreach (Prestamo prestamo in this.ListaDePrestamos)
                    {
                        if (prestamo is PrestamoDolar)
                        {
                            intereses += ((PrestamoDolar)(prestamo)).Interes;
                        }
                    }
                    break;
                case TipoDePrestamo.Pesos:
                    foreach (Prestamo prestamo in this.ListaDePrestamos)
                    {
                        if (prestamo is PrestamoPesos)
                        {
                            intereses += ((PrestamoPesos)(prestamo)).Interes;
                        }
                    }
                    break;
                case TipoDePrestamo.Todos:
                    intereses += this.InteresesEnPesos + this.InteresesEnDolares;
                    break;
            }
            return intereses;
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        #region Operadores

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("\nRazon social: {0}",financiera.RazonSocial);
            datos.AppendFormat("\nIntereses en dólares: {0}", financiera.InteresesEnDolares);
            datos.AppendFormat("\nIntereses en pesos: {0}", financiera.InteresesEnPesos);
            datos.AppendFormat("\nIntereses totales: {0}", financiera.InteresesTotales);

            foreach(Prestamo prestamo in financiera.ListaDePrestamos)
            {
                if(prestamo is PrestamoPesos)
                {
                    datos.AppendLine(prestamo.Mostrar());
                    datos.Append(TipoDePrestamo.Pesos);
                }
                else
                {
                    datos.AppendLine(prestamo.Mostrar());
                    datos.Append(TipoDePrestamo.Dolares);
                }
            }
            return datos.ToString();
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
           if(financiera.ListaDePrestamos.Contains(prestamo))
            {
                return true;  
            }
            return false;
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if(financiera != prestamo)
            {
                financiera.listaDePrestamos.Add(prestamo);
            }
            return financiera;
        }

        #endregion


    }
}
