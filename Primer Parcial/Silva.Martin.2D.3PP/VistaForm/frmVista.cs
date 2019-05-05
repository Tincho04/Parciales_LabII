using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmVista : Form
    {
        Curso nuevoCurso;
        Profesor nuevoProfesor;
        Alumno nuevoAlumno;
        Divisiones divisionCurso;
        Divisiones divisionAlumno;

        public frmVista()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out divisionCurso);
            nuevoProfesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);
            nuevoCurso = new Curso((short)(nudAnioCurso.Value), divisionCurso, nuevoProfesor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(nuevoCurso is Curso)
            {
                rtbDatos.Text = (string)nuevoCurso;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje de error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out divisionAlumno);
            nuevoAlumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)(nudAnio.Value), divisionAlumno);
                
            nuevoCurso += nuevoAlumno;
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }
    }
}
