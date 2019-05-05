using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        #region Propiedades

        public string AnioDivision
        {
            get
            {
                StringBuilder anioDivision = new StringBuilder("");

                anioDivision.AppendFormat("División: {0}°{1}", this.anio, this.division);

                return anioDivision.ToString();
            }
        }

        #endregion

        #region Métodos

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.ExponerDatos());
            datos.AppendFormat(this.AnioDivision);

            return datos.ToString();
        }

        public override bool ValidarDocumentacion(string documento)
        {
            //XX - XXXX - X
            char[] arrayDocumento = documento.ToArray<char>();

            for (int i = 0; i < arrayDocumento.Length; i++)
            {
                if (arrayDocumento[i] < 0 && arrayDocumento[i] > 9 || (arrayDocumento[2] != '-' || arrayDocumento[7] != '-'))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
