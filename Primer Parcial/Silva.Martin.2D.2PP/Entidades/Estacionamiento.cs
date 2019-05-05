using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        #region Métodos

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region Operadores

        public static explicit operator string(Estacionamiento estacionamiento)
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("NOMBRE: {0} ",estacionamiento.nombre);
            datos.AppendFormat("ESPACIO: {0} ",estacionamiento.espacioDisponible.ToString());

            foreach (Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                if(vehiculo != null)
                {
                    datos.AppendLine(vehiculo.ImprimirTicket());
                }
            }
            return datos.ToString();
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo auxVehiculo in estacionamiento.vehiculos)
            {
                if(auxVehiculo == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                foreach (Vehiculo auxVehiculo in estacionamiento.vehiculos)
                {
                    if (auxVehiculo == vehiculo)
                    {
                        estacionamiento.vehiculos.Remove(auxVehiculo);
                        break;
                    }
                }
                return vehiculo.ImprimirTicket();
            }
            else
            {
                return "El vehículo no es parte del estacionamiento";
            }
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente != null &&
                estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                estacionamiento.vehiculos.Add(vehiculo);
                return estacionamiento;
            }
            return estacionamiento;
        }
        #endregion
    }
}
