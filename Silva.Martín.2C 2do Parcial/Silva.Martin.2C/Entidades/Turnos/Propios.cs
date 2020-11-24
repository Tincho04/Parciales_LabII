using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Propios : Turnos
    {
        #region Atributos
        private string resultadoConsulta;
        Dictionary<int, string> Consultas = new Dictionary<int, string>()
        {
            {1, "Chequeo de rutina"},
            {2, "Creación de apto médico"},
            {3, "Renovación de receta"},
            {4, "Revisión de estudios"},
            {5, "Internación"},
            {6, "Monitoreo"},
            {7, "Consulta"},
            {8, "Se requerirá una nueva consulta"},
            {9, "Se deriva a intervención"},
        };
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad del resultado de la Consulta
        /// </summary>
        public string ResultadoConsulta
        {
            get { return ObtenerConsulta(); }
            set { resultadoConsulta = value; }
        }
        #endregion

        #region Constructor
        public Propios(int idPaciente, int idEspecialista) : base(idPaciente, idEspecialista)
        {
            this.resultadoConsulta = ResultadoConsulta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método que obtendrá el resultado de la consulta de manera random
        /// </summary>
        /// <returns></returns>
        private string ObtenerConsulta()
        {
            Random random = new Random();
            string resultadoConsulta;
            Consultas.TryGetValue(random.Next(1, 9), out resultadoConsulta);
            return resultadoConsulta;
        }
        #endregion
    }
}
