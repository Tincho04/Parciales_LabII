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
    public partial class Form1 : Form
    {
        Curso curso;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);

            this.curso = new Curso((short)numAnioCurso.Value, division, new Profesor(txtNombreProfesor.Text, txtApellidoProfesor.Text, txtDniProfesor.Text));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionAlumno.SelectedValue.ToString(), out division);
            Alumno a1 = new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, txtLegajoAlumno.Text, (short)numAnioCursoAlumno.Value, division);
            this.curso += a1;
        }
    }
}
