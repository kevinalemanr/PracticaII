using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03
{
    class Passwords
    {
        public string name {get; set;}
        public string keyValue { get; set; }
        public int kIndex { get; set; }

        public Passwords(int indice, string nombre, string keyValue)
        {
            this.kIndex = indice;
            this.keyValue = keyValue;
            this.name = nombre;
        }



    }
}
