using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        #region Propiedades

        public string AnioDivision
        {
            get
            {
                StringBuilder anioDivision = new StringBuilder("");

                anioDivision.AppendFormat("{0}°{1} ", this.anio, this.division);

                return anioDivision.ToString();
            }
        }

        #endregion

        #region Métodos

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        #endregion

        #region Operadores

        public static explicit operator string(Curso curso)
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("Curso: {0}", curso.AnioDivision);
            datos.AppendFormat("Profesor: {0}", curso.profesor.ExponerDatos());

            foreach(Alumno alumno in curso.alumnos)
            {
                datos.AppendFormat(alumno.ExponerDatos());
            }
            return datos.ToString();
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            if(alumno.AnioDivision == curso.AnioDivision)
            {
                return true;
            }
            return false;
        }

        public static Curso operator +(Curso curso, Alumno alumno)
        {
            if (alumno.AnioDivision == curso.AnioDivision)
            {
                curso.alumnos.Add(alumno);
            }
            return curso;
        }   

        #endregion

    }
}
