using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Formularios
{
    public partial class SaladeEspera : Form
    {
        Thread hilosecundario;
        public Queue<Turnos> listaEspera;
        Consultorios formConsultorio = new Consultorios();
        public List<Turnos> listadoEspera = new List<Turnos>();

        #region Delegado
        delegate void DelegadoParaLimpiarList(Turnos t);
        #endregion

        public SaladeEspera()
        {
            InitializeComponent();
        }

        private void SaladeEspera_Load(object sender, EventArgs e)
        {
            formConsultorio.Show();
        }

        /// <summary>
        /// Se verifica si el turno recibido se encuentra ya en la lista para poder agregarlo
        /// </summary>
        /// <param name="t"></param>
        public void CargaEspera(Turnos t)
        {
            timerEspera.Enabled = true;
            bool flag = true;

            if (listadoEspera.Count > 0)
            {
                foreach (Turnos turno in listadoEspera)
                {
                    if (turno == t)
                    {
                        flag = false;
                    }
                }
            }
            if (flag == true)
            {
                listadoEspera.Add(t);
                listEspera.Items.Add(t);
            }
        }

        /// <summary>
        /// Método que nos permite actualizar el estado del turno si este se encuentra en la sala de espera
        /// </summary>
        public void ActualizarEspera()
        {
            foreach (Turnos t in listadoEspera)
            {
                do
                {
                    if (t.Estado == Turnos.EEstado.SalaDeEspera)
                    {
                        t.Estado += 1;
                        formConsultorio.VerificarConsulta(t);
                        LimpiarList(t);
                        listadoEspera.Remove(t);
                        Thread.Sleep(100);
                    }
                } while (true);
            }
        }

        /// <summary>
        /// Método para eliminar el turno de la sala de espera al haber entrado en Consultorio.
        /// Se emplea un delegado para el eliminado del campo en el Listbox
        /// </summary>
        /// <param name="t"></param>
        public void LimpiarList(Turnos t)
        {
            if (this.listEspera.InvokeRequired)
            {
                DelegadoParaLimpiarList aux = new DelegadoParaLimpiarList(LimpiarList);
                object[] obj = new Object[] { t };
                this.Invoke(aux, obj);
            }
            else
            {
                listEspera.Items.Remove(t);
            }
        }

        /// <summary>
        /// Se emplea un Timer para la validación de los 10 segundos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEspera_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i > 10; i++)
            {
            }
            ThreadStart ts = new ThreadStart(ActualizarEspera);
            this.hilosecundario = new Thread(ts);
            hilosecundario.Start();
            timerEspera.Enabled = false;
        }

        /// <summary>
        /// Al cerrar el proceso del Turnero se verifica si el hilo secundario continua vivo para darle cierre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaladeEspera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hilosecundario.IsAlive)
            {
                hilosecundario.Abort();
            }
        }
    }
}