using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Clinica : IMostrar<List<Turnos>>
    {
        #region Atributos
        private Queue<Turnos> listaTurnos;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura / escritura.
        /// </summary>
        public Queue<Turnos> ListaTurnos
        {
            get { return this.listaTurnos; }
            set { this.listaTurnos = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto que inicializa las listas
        /// </summary>
        public Clinica()
        {
            this.listaTurnos = new Queue<Turnos>();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Añade un turno a la lista de turnos si es que este no se encuentra repetido. Empleando la sobrecarga del ==
        /// </summary>
        /// <param name="c"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool SumoTurno(List<Turnos> c, Turnos t)
        {
            bool flag = true;
            if (!Equals(c, null) && !Equals(t, null))
            {
                if (c.Count > 0)
                {
                    foreach (Turnos item in c)
                    {
                        if (item == t)
                        {
                            flag = false;
                        }
                    }
                }

            }
            if (flag == true)
            {
                c.Add(t);
            }
            return flag;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// muestra los datos de los turnos
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Turnos>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Turnos turno in listaTurnos)
            {
                sb.AppendFormat("Paciente: {0} {1} para atención con {2} {3} de {4} {5}\n", turno.NombrePaciente, turno.ApellidoPaciente, turno.NombreEspecialista, turno.ApellidoEspecialista, turno.Especialidad, turno.Estado.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
