using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02
{
    class Metros: Distancia
    {
        public Metros(double valor)
        {
            distancia = valor;
        }

        public static implicit operator Pies(Metros met)
        {
            return new Pies(met.distancia * 0.3048);
        }


    }
}
