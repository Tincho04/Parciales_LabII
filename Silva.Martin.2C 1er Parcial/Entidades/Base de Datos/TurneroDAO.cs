using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Entidades
{
    public static class TurneroDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader lector;
        static TurneroDAO()
        {
            TurneroDAO.conexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True;");
            TurneroDAO.comando = new SqlCommand();
            TurneroDAO.comando.CommandType = CommandType.Text;
            TurneroDAO.comando.Connection = TurneroDAO.conexion;
        }
        /// <summary>
        ///  guarda los datos de los turnos en la base de datos
        /// </summary>
        /// <param name="t"></param>
        public static void Insertar(Propios t)
        {
            TurneroDAO.conexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True;");
            TurneroDAO.comando = new SqlCommand();
            TurneroDAO.comando.CommandType = CommandType.Text;
            TurneroDAO.comando.Connection = TurneroDAO.conexion;

            try
            {
                comando.CommandText = "insert into dbo.Turnos values(@idPaciente,@idEspecialista,@resultadoConsulta,@fechaTurno)";
                comando.Parameters.Add(new SqlParameter("idPaciente", t.IdPaciente));
                comando.Parameters.Add(new SqlParameter("idEspecialista", t.IdEspecialista));
                comando.Parameters.Add(new SqlParameter("resultadoConsulta", t.ResultadoConsulta));
                comando.Parameters.Add(new SqlParameter("fechaTurno", t.Fecha));

                conexion.Open();
                TurneroDAO.comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                string mensaje;
                mensaje = e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// Carga un DataTable con los valores tomados de la tabla según el método de acceso que reciba
        /// </summary>
        /// <param name="acceso"></param>
        /// <returns></returns>
        public static DataTable ConsultaGeneral(string acceso)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.CommandText = acceso;

                conexion.Open();
                lector = comando.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception e)
            {
                string mensaje;
                mensaje = e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }

        /// <summary>
        /// Llamará a la consulta para la carga del Datatable enviando como modo de acceso la tabla de Especialistas
        /// </summary>
        /// <returns></returns>
        public static DataTable ConsultaGeneralEspecialista()
        {
            return ConsultaGeneral("Select * from dbo.Especialistas");
        }

        /// <summary>
        /// Llamará a la consulta para la carga del Datatable enviando como modo de acceso la tabla de Pacientes
        /// </summary>
        /// <returns></returns>
        public static DataTable ConsultaGeneralPaciente()
        {
            return ConsultaGeneral("Select * from dbo.Pacientes");
        }

        /// <summary>
        /// Realiza una búsqueda de los especialistas que cumplan con la especialidad requerida
        /// </summary>
        /// <param name="especialidad"></param>
        /// <returns></returns>
        public static DataTable ConsultaEspecialidad(string especialidad)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.CommandText = ("Select * from dbo.Especialistas where especialidad = @especialidadFiltro");

                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("especialidadFiltro", (especialidad)));

                conexion.Open();
                lector = comando.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception e)
            {
                string mensaje;
                mensaje = e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }

        /// <summary>
        /// Realiza una consulta a la tabla de turnos para traer el historial de turnos
        /// </summary>
        /// <returns></returns>
        public static List<string> ConsultaTurnos()
        {
            List<string> listaTurnos = new List<string>();
            string auxPNombre;
            string auxPApellido;
            string auxENombre;
            string auxEApellido;
            string auxEspecialidad;
            try
            {
                comando.CommandText =
                "Select dbo.Pacientes.nombre as nombreP, dbo.Pacientes.apellido as apellidoP, dbo.Especialistas.nombre as nombreE, dbo.Especialistas.Apellido as apellidoE, dbo.Especialistas.especialidad from dbo.Turnos INNER JOIN dbo.Pacientes on dbo.Pacientes.idPaciente = dbo.Turnos.idPaciente INNER JOIN dbo.Especialistas on dbo.Especialistas.idEspecialista = dbo.Turnos.idEspecialista";
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    auxPNombre = lector["nombreP"].ToString();
                    auxPApellido = lector["apellidoP"].ToString();
                    auxENombre = lector["nombreE"].ToString();
                    auxEApellido = lector["apellidoE"].ToString();
                    auxEspecialidad = lector["especialidad"].ToString();

                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Paciente: {0} {1} para atención con {2} {3} de {4}\n", auxPNombre, auxPApellido, auxENombre, auxEApellido, auxEspecialidad);
                    listaTurnos.Add(sb.ToString());
                }
            }
            catch (Exception e)
            {
                string mensaje;
                mensaje = e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return listaTurnos;
        }

        /// <summary>
        /// Consulta en la tabla de especialistas los distintos tipos de especialidades, evitando traer la repetición de los mismos mediante la palabra reservada "distinct"
        /// </summary>
        /// <returns></returns>
        public static List<string> ConsultaGeneralEspecialidad()
        {
            List<string> listaEspecialidad = new List<string>();

            try
            {
                comando.CommandText = "Select distinct especialidad from dbo.Especialistas";

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    listaEspecialidad.Add(lector["especialidad"].ToString());
                }
            }
            catch (Exception e)
            {
                string mensaje;
                mensaje = e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return listaEspecialidad;
        }
    }
}
