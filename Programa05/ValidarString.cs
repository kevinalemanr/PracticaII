using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05
{
    class ValidarString
    {

        public string cadena;
        char[] str;


        public ValidarString(string a)
        {
            this.cadena = a;
        }

        public bool ValidarCadena()
        {
            str = cadena.ToCharArray();
            string reversa =string.Empty;
            Stack<char> chain = new Stack<char>();

            for(int i=0; i < str.Length; i++)
            {
                chain.Push(str[i]);
            }


            while (chain.Count > 0)
                reversa+= chain.Pop();

            if (reversa.Equals(cadena))
            {
                return true;
            }
            else
            {
                return false;
            }
            

            
        }




    }
}
