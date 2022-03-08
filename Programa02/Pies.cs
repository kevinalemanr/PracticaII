using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02
{
    class Pies: Distancia
    {
        public Pies(double valor)
        {
            distancia = valor;
        }

        public static implicit operator Metros(Pies pies)
        {
            return new Metros(pies.distancia / 0.3048);
        }
    }
}
