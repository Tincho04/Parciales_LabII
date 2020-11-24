using System;
using System.Text;

namespace Entidades
{
#pragma warning disable CS0660, CS0661

    public class Turnos : IMostrar<Turnos>
    {
        #region Atributos
        private string fecha;
        private int idPaciente;
        private int idEspecialista;
        private string nombrePaciente;
        private string apellidoPaciente;
        private string nombreEspecialista;
        private string apellidoEspecialista;
        private string especialidad;
        private EEstado estado;
        private bool interno;
        #endregion

        #region Enumerado
        /// <summary>
        /// Enumerado que refleja el estado del turno
        /// </summary>
        public enum EEstado
        {
            SalaDeEspera,
            EnConsultorio,
            Atendido
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad para obtener la fecha y horario
        /// </summary>
        public string Fecha
        {
            get { return DateTime.Now.ToString("dd-MM-yyyy"); }
            set { fecha = value; }
        }

        /// <summary>
        /// Propiedad del ID del Paciente que acudió al turno
        /// </summary>
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        /// <summary>
        /// Propiedad para el nombre del paciente
        /// </summary>
        public string NombrePaciente
        {
            get { return nombrePaciente; }
            set { nombrePaciente = value; }
        }

        /// <summary>
        /// Propiedad para el apellido del paciente
        /// </summary>
        public string ApellidoPaciente
        {
            get { return apellidoPaciente; }
            set { apellidoPaciente = value; }
        }

        /// <summary>
        /// Propiedad del apellido del Especialista que atendió en el turno
        /// </summary>
        public string ApellidoEspecialista
        {
            get { return apellidoEspecialista; }
            set { apellidoEspecialista = value; }
        }

        /// <summary>
        /// Propiedad del nombre del Especialista que atendió en el turno
        /// </summary>
        public string NombreEspecialista
        {
            get { return nombreEspecialista; }
            set { nombreEspecialista = value; }
        }

        /// <summary>
        /// Propiedad de la especialidad
        /// </summary>
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        /// <summary>
        /// Propiedad del ID del Especialista que atendió en el turno
        /// </summary>
        public int IdEspecialista
        {
            get { return idEspecialista; }
            set { idEspecialista = value; }
        }

        /// <summary>
        /// Propiedad del estado del turno
        /// </summary>
        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Propiedad para saber si es habitual de la clinica o derivado
        /// </summary>
        public bool Interno
        {
            get { return interno; }
            set { interno = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// constructor que seteará la fecha de la consulta
        /// </summary>
        public Turnos()
        {
            this.fecha = Fecha;
        }

        public Turnos(string apellidoPaciente, string nombrePaciente) : this()
        {
            this.NombrePaciente = nombrePaciente;
            this.ApellidoPaciente = apellidoPaciente;
        }

        public Turnos(int idPaciente, int idEspecialista) : this()
        {
            this.IdPaciente = idPaciente;
            this.IdEspecialista = idEspecialista;
        }

        public Turnos(string nombrePaciente, string apellidoPaciente, string nombreEspecialista, string apellidoEspecialista, string especialidad, bool interno, int idPaciente, int idEspecialista) : this()
        {
            this.NombrePaciente = nombrePaciente;
            this.ApellidoPaciente = apellidoPaciente;
            this.NombreEspecialista = nombreEspecialista;
            this.ApellidoEspecialista = apellidoEspecialista;
            this.Especialidad = especialidad;
            this.Interno = interno;
            this.IdPaciente = idPaciente;
            this.IdEspecialista = idEspecialista;
            this.estado = Estado;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// muestra los datos de una instacia turno
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Turnos> elemento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Paciente: {0} {1} para atención con {2} {3} de {4}\n", NombrePaciente, ApellidoPaciente, NombreEspecialista, ApellidoEspecialista, Especialidad);
            return sb.ToString();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Dos turnos seran iguales si poseen el mismo paciente y especialista
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Turnos t1, Turnos t2)
        {
            bool retorno = false;

            if (t1.IdPaciente == t2.IdPaciente && t1.IdEspecialista == t2.IdEspecialista)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Turnos t1, Turnos t2)
        {
            return !(t1 == t2);
        }

        #endregion

        #region Sobrecarga
        /// <summary>
        /// Sobrecarga al ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion
    }
}