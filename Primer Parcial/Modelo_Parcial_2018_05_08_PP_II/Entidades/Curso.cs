using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region "Atributos"
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        #endregion

        #region "Propiedades"
        public string AnioDivision
        {
            get
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0}º{1}", this.anio, this.division);
                return s.ToString();
            }
        }
        #endregion

        #region "Constructores"
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        #endregion

        #region "Sobrecargas"
        public static explicit operator string(Curso c)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}\nProfesor: {1}\n", c.AnioDivision, c.profesor.ExponerDatos());
            foreach (Alumno alumno in c.alumnos)
            {
                s.AppendLine(alumno.ExponerDatos());
            }
            return s.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return a.AnioDivision == c.AnioDivision;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
        #endregion
    }
}
