using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region "Atributos"
        private short anio;
        private Divisiones division;
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
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        #endregion

        #region "Metodos"
        public override string ExponerDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(base.ExponerDatos());
            s.AppendLine(this.AnioDivision);
            return s.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            bool flag = false;
            bool returnAux = false;
            int contadorGuiones = 0;

            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                for (int i = 0; i < doc.Length; i++)
                {
                    if (doc[i] != '-' || !char.IsDigit(doc[0]))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        if (doc[2] == '-')
                        {
                            contadorGuiones++;
                        }
                    }
                }
                if (contadorGuiones == 2 && flag == false)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }
        #endregion
    }
}
