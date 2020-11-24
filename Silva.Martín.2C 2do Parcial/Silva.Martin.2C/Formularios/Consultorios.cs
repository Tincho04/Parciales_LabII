using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Consultorios : Form
    {
        Thread hilosecundario;
        List<Turnos> listaAconsultorio = new List<Turnos>();
        List<Turnos> listaAtendidos = new List<Turnos>();

        #region Delegados
        delegate void DelegadoParaVerificarConsulta(Turnos t);
        delegate void DelegadoParaActualizarConsulta();
        delegate void DelegadoParaLimpiarList(Turnos t);
        #endregion

        public Consultorios()
        {
            InitializeComponent();
        }

        private void Consultorios_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Verificará el estado del Turno, Actualizará la lista al dejar la sala de espera y pasar a la consulta. Si ha sido atendido pasará a ser cargado a la base de datos si es interno de la clinica o al archivo xml si es derivado
        /// </summary>
        /// <param name="t"></param>
        public void VerificarConsulta(Turnos t)
        {
            if (t.Estado == Turnos.EEstado.EnConsultorio)
            {
                if (this.listConsultorio.InvokeRequired)
                {
                    DelegadoParaVerificarConsulta aux = new DelegadoParaVerificarConsulta(VerificarConsulta);
                    object[] obj = new Object[] { t };
                    this.Invoke(aux, obj);
                }
                else
                {
                    listaAconsultorio.Add(t);
                    listConsultorio.Items.Add(t);
                    TimerConsulta.Enabled = true;
                }
            }
            else if (t.Estado == Turnos.EEstado.Atendido)
            {
                if (this.listAtendidos.InvokeRequired)
                {
                    DelegadoParaVerificarConsulta aux = new DelegadoParaVerificarConsulta(VerificarConsulta);
                    object[] obj = new Object[] { t };
                    this.Invoke(aux, obj);
                }
                else
                {
                    listaAtendidos.Add(t);
                    listAtendidos.Items.Add(t);
                    if (t.Interno == true)
                    {
                        Propios turnoInterno = new Propios(t.IdPaciente, t.IdEspecialista);
                        TurneroDAO.Insertar(turnoInterno);
                    }
                    else
                    {
                        TurnoXML turnoXml = new TurnoXML(t.ApellidoPaciente, t.NombrePaciente);
                        TurnoXML.Guardar(turnoXml);
                    }
                }
            }
        }

        /// <summary>
        /// actualiza el estado de En Consultorio a Atendido
        /// </summary>
        public void ActualizarConsulta()
        {
            foreach (Turnos t in listaAconsultorio)
            {
                do
                {
                    if (t.Estado == Turnos.EEstado.EnConsultorio)
                    {
                        t.Estado += 1;
                        VerificarConsulta(t);
                        LimpiarList(t);
                        listaAconsultorio.Remove(t);
                        Thread.Sleep(100);
                    }
                } while (true);
            }
        }

        /// <summary>
        /// Se invoca al hilo principal para actualizar la lista del consultorio
        /// </summary>
        /// <param name="t"></param>
        public void LimpiarList(Turnos t)
        {

            if (this.listConsultorio.InvokeRequired)
            {
                DelegadoParaLimpiarList aux = new DelegadoParaLimpiarList(LimpiarList);
                object[] obj = new Object[] { t };
                this.Invoke(aux, obj);
            }
            else
            {
                listConsultorio.Items.Remove(t);
            }
        }

        /// <summary>
        /// Genera una búsqueda en la base de datos para traer el historial de nuestros pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaHistorial_Click(object sender, EventArgs e)
        {
            listAtendidos.DataSource = TurneroDAO.ConsultaTurnos();
        }

        /// <summary>
        /// Se emplea un Timer para la verificación de consulta de 10 segundos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerConsulta_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i == 10; i++)
            {
            }
            ThreadStart ts = new ThreadStart(ActualizarConsulta);
            this.hilosecundario = new Thread(ts);
            hilosecundario.Start();
        }

        /// <summary>
        /// Al cerrar el proceso del Turnero se verifica si el hilo secundario continua vivo para darle cierre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consultorios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hilosecundario.IsAlive)
            {
                hilosecundario.Abort();
            }
        }
    }
}
