using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190507_Silva.Martin
{
    class Maquina
    {
        int CantidadMaxPerifericos;

        string nombre;

        List<Periferico> perifericos;

        int CantidadMaximaPerifericos
        {
            get { return CantidadMaxPerifericos; }
            set { CantidadMaxPerifericos = value; }
        }

        string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string systemInfo
        {
            get { return systemInfo; }
        }


        public enum Edistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }
    }
}
