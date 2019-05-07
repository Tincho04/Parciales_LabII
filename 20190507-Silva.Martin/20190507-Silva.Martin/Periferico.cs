using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190507_Silva.Martin
{
    public abstract class Periferico
    {
        protected Econector conector;
        protected string marca;
        protected string modelo;

        #region Métodos

        explicit operator (Periferico p)
            {
            StringBuilder datos = new StringBuilder("");

        datos.AppendLine(base.Modelo.ToString().ToString());
        datos.AppendLine(base.Marca.ToString());
        datos.AppendLine(base..ToString());

            return datos.ToString();
        }
}

        abstract string ExponerDatos();

        bool operator !=(Periferico p1, Periferico P2);

        bool operator ==(Periferico p1, Periferico P2);

        Periferico(string marca, string modelo, Econector conector);

        #endregion
    }
}
