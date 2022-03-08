using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> tupla1 = new Tuple<int, int>(2, 4);
            Tuple<int, int> tupla2 = new Tuple<int, int>(1, 3);
            Tuple<int, int> tupla3 = new Tuple<int, int>(6, 8);

            ArrayList tuplasInt = new ArrayList();
            tuplasInt.Add(tupla1);
            tuplasInt.Add(tupla2);
            tuplasInt.Add(tupla3);


            foreach (var obj in tuplasInt)
                Console.WriteLine(obj);


            Tuple<string, string, int, bool> tupla4 = new Tuple<string, string, int, bool>("Auto1", "Mazda", 1, true);
            Tuple<string, string, int, bool> tupla5 = new Tuple<string, string, int, bool>("Auto2", "Ford", 2, true);
            Tuple<string, string, int, bool> tupla6 = new Tuple<string, string, int, bool>("Auto3", "Honda", 3, true);
            Tuple<string, string, int, bool> tupla7 = new Tuple<string, string, int, bool>("Auto4", "Hyndai", 4, true);

            ArrayList tuplasM = new ArrayList();
            tuplasM.Add(tupla4);
            tuplasM.Add(tupla5);
            tuplasM.Add(tupla6);
            tuplasM.Add(tupla7);

            foreach (var counter in tuplasM)
                Console.WriteLine(counter);








        }
    }
}
