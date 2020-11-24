using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Formularios
{
    public partial class Turnero : Form
    {
        public static List<Turnos> ListaTurnos;
        Thread hilosecundario;
        bool showPaciente = false;
        bool showEspecialista = false;
        public Clinica clinica;
        public Turnos turno;
        SaladeEspera formEspera = new SaladeEspera();
        Consultorios formConsulta = new Consultorios();
        delegate void DelegadoActualizaHora();
        public Turnero()
        {
            InitializeComponent();
            formEspera.Show();
        }

        private void Turnero_Load(object sender, EventArgs e)
        {
            clinica = new Clinica();
            ListaTurnos = new List<Turnos>();
            this.cmbProcedencia.DataSource = Enum.GetNames(typeof(ETipo));

            #region Parametros para el Datagrid de Paciente
            dgvPaciente.Hide();
            dgvPaciente.ReadOnly = true;
            dgvPaciente.RowHeadersVisible = false;
            dgvPaciente.ColumnHeadersVisible = true;
            dgvPaciente.ForeColor = Color.Black;
            dgvPaciente.AllowUserToAddRows = false;
            #endregion

            #region Parametros para el Datagrid de Especialista
            dgvEspecialista.Hide();
            dgvEspecialista.ReadOnly = true;
            dgvEspecialista.RowHeadersVisible = false;
            dgvEspecialista.ColumnHeadersVisible = true;
            dgvEspecialista.ForeColor = Color.Black;
            dgvEspecialista.AllowUserToAddRows = false;
            #endregion

            #region Parametros para el DateTimePicker
            ThreadStart ts = new ThreadStart(AsignarHora);
            hilosecundario = new Thread(ts);
            hilosecundario.Start();
            dtpHorario.Format = DateTimePickerFormat.Custom;
            dtpHorario.CustomFormat = "HH mm tt";
            dtpHorario.ShowUpDown = true;
            #endregion

        }

        /// <summary>
        /// Método que irá actualizando la hora, con planes a próximo sprint de incorporarlo al dar el turno
        /// </summary>
        public void AsignarHora()
        {
            do
            {
                this.ActualizaHora();
                Thread.Sleep(200);
            } while (true);
        }

        private void ActualizaHora()
        {
            if (this.dtpHorario.InvokeRequired)
            {
                DelegadoActualizaHora aux = new DelegadoActualizaHora(ActualizaHora);
                this.BeginInvoke(aux);
            }
            else
            {
                this.dtpHorario.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        /// <summary>
        /// Se genera el alta en base a los datos recibidos tras previa validación de que los datos se hayan cargado correctamente. Asímismo se valida el tipo de paciente y especialista interviniente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            bool interno;
            int idPaciente = 0;
            int idEspecialista = 0;
            if (Validaciones.ValidarString(cmbEspecialidad.Text) && Validaciones.ValidarString(cmbEspecialistasA.Text) && Validaciones.ValidarString(cmbPacientesA.Text) && Validaciones.ValidarString(cmbProcedencia.Text) && int.TryParse(dgvPaciente.CurrentCell.Value.ToString(), out idPaciente) && int.TryParse(dgvEspecialista.CurrentCell.Value.ToString(), out idEspecialista))
            {
                if (cmbProcedencia.Text == "Interno")
                {
                    interno = true;
                }
                else
                {
                    interno = false;
                }

                turno = new Turnos(cmbPacientesN.Text, cmbPacientesA.Text, cmbEspecialistasN.Text, cmbEspecialistasA.Text, cmbEspecialidad.Text, interno, idPaciente, idEspecialista);

                if (Clinica.SumoTurno(ListaTurnos, turno))
                {
                    MessageBox.Show("El turno se ha dado de alta satisfactoriamente");
                    formEspera.CargaEspera(turno);
                }
                else
                {
                    MessageBox.Show("El turno ya se encuentra registrado.");

                }

                cmbEspecialidad.BackColor = Color.White;
                cmbEspecialistasA.BackColor = Color.White;
                cmbEspecialistasN.BackColor = Color.White;
                cmbPacientesA.BackColor = Color.White;
                cmbPacientesN.BackColor = Color.White;
            }

            else
            {
                try
                {
                    string mensajeError;
                    if (!(int.TryParse(dgvPaciente.CurrentCell.Value.ToString(), out idPaciente)))
                    {
                        mensajeError = "Debe posicionarse en el ID del Paciente de la planilla";
                    }
                    else if (!(int.TryParse(dgvEspecialista.CurrentCell.Value.ToString(), out idEspecialista)))
                    {
                        mensajeError = "Debe posicionarse en el ID del Especialista de la planilla";
                    }
                    else
                    {
                        mensajeError = "Faltan completar campos";
                        if (cmbEspecialidad.Text == string.Empty) cmbEspecialidad.BackColor = Color.Red;
                        if (cmbEspecialistasA.Text == string.Empty) cmbEspecialistasA.BackColor = Color.Red;
                        if (cmbPacientesA.Text == string.Empty) cmbPacientesA.BackColor = Color.Red;
                        if (cmbEspecialistasN.Text == string.Empty) cmbEspecialistasN.BackColor = Color.Red;
                        if (cmbPacientesN.Text == string.Empty) cmbPacientesN.BackColor = Color.Red;
                    }

                    MessageBox.Show(mensajeError, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NullReferenceException ex)
                {
                    Texto texto = new Texto();
                    string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                    texto.Guardar(route, ex.Message);
                }
            }
        }
        /// <summary>
        /// Ocultará o mostrará el datagrid levantado de la base de datos o archivo xml con los datos del paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHideShowPaciente_Click(object sender, EventArgs e)
        {
            if (showPaciente == false)
            {
                dgvPaciente.Show();
                btnHideShowPaciente.Text = "Ocultar lista de pacientes";
                showPaciente = true;
            }
            else
            {
                dgvPaciente.Hide();
                btnHideShowPaciente.Text = "Mostrar lista de pacientes";
                showPaciente = false;
            }

        }

        /// <summary>
        /// Ocultará o mostrará el datagrid levantado de la base de datos o archivo xml con los datos del especialista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHideShowEspecialista_Click(object sender, EventArgs e)
        {
            if (showEspecialista == false)
            {
                dgvEspecialista.Show();
                btnHideShowEspecialista.Text = "Ocultar lista de especialistas";
                showEspecialista = true;
            }
            else
            {
                dgvEspecialista.Hide();
                btnHideShowEspecialista.Text = "Mostrar lista de especialistas";
                showEspecialista = false;
            }
        }

        /// <summary>
        /// Las siguientes opciones se encargan de rastrear y coincidir los cambios en nombres / apellidos tanto de pacientes como de especialistas para visualizar los datos de la persona seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Parametros para el enlace entre los Combobox Paciente-Especialista
        private void cmbPacientesA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPacientesN.DataSource = cmbPacientesA.DataSource;
            cmbPacientesN.DisplayMember = "nombre";
            cmbPacientesN.ValueMember = cmbPacientesA.ValueMember;
        }

        private void cmbPacienteN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPacientesA.DataSource = cmbPacientesN.DataSource;
            cmbPacientesA.DisplayMember = "apellido";
            cmbPacientesA.ValueMember = cmbPacientesN.ValueMember;
        }

        private void cmbEspecialistasA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEspecialistasN.DataSource = cmbEspecialistasA.DataSource;
            cmbEspecialistasN.DisplayMember = "nombre";
            cmbEspecialistasN.ValueMember = cmbEspecialistasA.ValueMember;
        }

        private void cmbEspecialistasN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEspecialistasA.DataSource = cmbEspecialistasN.DataSource;
            cmbEspecialistasA.DisplayMember = "apellido";
            cmbEspecialistasA.ValueMember = cmbEspecialistasN.ValueMember;
        }
        #endregion

        /// <summary>
        /// Limpia los datos de los campos visibles, excluyendo el datagrid. Para poder hacer un nuevo alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEspecialidad.BackColor = Color.White;
            cmbEspecialistasA.BackColor = Color.White;
            cmbEspecialistasN.BackColor = Color.White;
            cmbPacientesA.BackColor = Color.White;
            cmbPacientesN.BackColor = Color.White;
            cmbEspecialidad.Text = "";
            cmbEspecialistasA.Text = "";
            cmbEspecialistasN.Text = "";
            cmbPacientesA.Text = "";
            cmbPacientesN.Text = "";
        }

        /// <summary>
        /// Carga automatizada de datos del especialista en base a su Especialidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProcedencia.Text == "Interno")
                {
                    dgvEspecialista.DataSource = TurneroDAO.ConsultaEspecialidad(cmbEspecialidad.Text);

                    cmbEspecialistasA.DisplayMember = "apellido";
                    cmbEspecialistasA.ValueMember = "idEspecialista";
                }
                else if (cmbProcedencia.Text == "Derivado")
                {
                    dgvEspecialista.DataSource = EspDerivados.Leer(cmbEspecialidad.Text);
                    cmbEspecialistasA.DisplayMember = "Apellido";
                    cmbEspecialistasA.ValueMember = "Id";
                }
                cmbEspecialistasA.DataSource = dgvEspecialista.DataSource;
                cmbEspecialistasA.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbEspecialistasA.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                string route = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ".\\SegundoParcialUtn\\LogDeErrores.txt";
                texto.Guardar(route, ex.Message);
            }
        }

        /// <summary>
        /// Boton que cumple de manera manual el filtro para la carga de datos para pacientes/especialistas derivados o internos. 
        /// Este boton se incorpora debido a que automatizar el combobox generaría una demora al abrir el Form, debido a la búsqueda automática.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcedencia_Click(object sender, EventArgs e)
        {
            if (cmbProcedencia.Text == "Interno")
            {
                #region controles Pacientes
                dgvPaciente.DataSource = TurneroDAO.ConsultaGeneralPaciente();
                cmbPacientesA.DataSource = dgvPaciente.DataSource;
                cmbPacientesA.DisplayMember = "apellido";
                cmbPacientesA.ValueMember = "idPaciente";
                #endregion

                #region controles Especialistas
                cmbEspecialidad.DataSource = TurneroDAO.ConsultaGeneralEspecialidad();
                dgvEspecialista.DataSource = TurneroDAO.ConsultaGeneralEspecialista();
                cmbEspecialistasA.DataSource = dgvEspecialista.DataSource;
                cmbEspecialistasA.DisplayMember = "apellido";
                cmbEspecialistasA.ValueMember = "idEspecialista";
                #endregion

            }
            else if (cmbProcedencia.Text == "Derivado")
            {
                #region controles Pacientes
                dgvPaciente.DataSource = PacDerivados.Leer();
                cmbPacientesA.DataSource = dgvPaciente.DataSource;
                cmbPacientesA.DisplayMember = "Apellido";
                cmbPacientesA.ValueMember = "Id";
                #endregion

                #region controles Especialistas
                cmbEspecialidad.DataSource = EspDerivados.BuscarEspecialidad(EspDerivados.Leer());
                dgvEspecialista.DataSource = EspDerivados.Leer();
                cmbEspecialistasA.DataSource = dgvEspecialista.DataSource;
                cmbEspecialistasA.DisplayMember = "Apellido";
                cmbEspecialistasA.ValueMember = "Id";
                #endregion

            }

            #region Autocompletado
            cmbPacientesA.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientesA.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEspecialistasA.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbEspecialistasA.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPacientesN.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPacientesN.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEspecialistasN.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbEspecialistasN.AutoCompleteSource = AutoCompleteSource.ListItems;
            #endregion
        }
        /// <summary>
        /// Al cerrar el proceso del Turnero se verifica si el hilo secundario continua vivo para darle cierre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Turnero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hilosecundario.IsAlive)
            {
                hilosecundario.Abort();
            }
        }
    }
}
