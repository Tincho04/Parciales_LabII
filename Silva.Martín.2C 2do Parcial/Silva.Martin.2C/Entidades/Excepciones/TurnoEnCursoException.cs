using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TurnoEnCursoException : Exception
    {
        /// <summary>
        /// Excepcion que se dará cuando se quiera dar de alta un turno con las mismas caracteristicas al que se encuentra en la lista de turnos activos
        /// </summary>
        public TurnoEnCursoException() : base("El Paciente ya se encuentra a la espera de ser atendido")
        {           
        }
        public TurnoEnCursoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
