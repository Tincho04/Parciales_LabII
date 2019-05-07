using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190507_Silva.Martin
{
    class Teclado : Periferico
    {
        EDistribucion distribucion;

        string ExponerDatos();
        
        bool operator !=(Teclado t, EDistribucion distribucion);

        bool operator ==(Teclado t, EDistribucion distribucion);

        Teclado(string marca, string modelo, EConector conector);

        Teclado(string marca, string Modelo, EConector conector, EDistribucion region);


    }
}
