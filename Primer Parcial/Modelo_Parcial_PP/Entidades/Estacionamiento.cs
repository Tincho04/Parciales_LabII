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

        /// <summary>
        /// Constructor privado que inicializa la lista de vehiculos
        /// </summary>
        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// constructor con los parametros nombre y espacio disponible
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="espacioDisponible"></param>
        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        /// <summary>
        /// Conversor de un estacionamiento a string para mostrar todos sus datos
        /// </summary>
        /// <param name="estacionamiento"></param>

        public static explicit operator string (Estacionamiento estacionamiento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Espacio disponible: {0}", estacionamiento.espacioDisponible);
            sb.AppendFormat("\nNombre: {0}", estacionamiento.nombre);
            foreach(Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                sb.AppendLine(vehiculo.ConsultarDatos());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Un estacionamiento y un vehiculo son iguales cuando el vehiculo ya se encuentra en la 
        /// lista de vehiculos del estacionamiento
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator == (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool encuentra = false;

            foreach (Vehiculo auxVehiculo in estacionamiento.vehiculos)
            {
                if(auxVehiculo == vehiculo)
                {
                    encuentra = true;
                    break; 
                }

            }
            return encuentra;
        }


        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        /// <summary>
        /// Un vehiculo puede entrar al estacionamiento cuando hay espacio disponible, cuando no se 
        /// encuentra ya en el y cuando tiene asignada la patente
        /// </summary>
        /// <param name="estacionamineto"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamineto, Vehiculo vehiculo)
        {
            if (estacionamineto.espacioDisponible <= estacionamineto.vehiculos.Count ||
                estacionamineto == vehiculo ||
                vehiculo.Patente.Length != 6)
                return estacionamineto;

            else
                estacionamineto.vehiculos.Add(vehiculo);

            return estacionamineto;
        }

        /// <summary>
        /// Al salir un auto del estacionamiento, se imprime su ticket. Solo puede salir si ya se 
        /// encuentra dentro
        /// </summary>
        /// <param name="estacionamineto"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static string operator -(Estacionamiento estacionamineto, Vehiculo vehiculo)
        {
            string mensaje;

            if (estacionamineto == vehiculo)
            {
                mensaje = vehiculo.ImprimirTicket();
                estacionamineto.vehiculos.Remove(vehiculo);
            }
            else
                mensaje = "El vehiculo no es parte del estacionamiento";

            return mensaje;
        }
    }
}
