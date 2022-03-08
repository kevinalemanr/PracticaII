using System;

namespace Programa04
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arreglo;
            int objLenght;
            Console.WriteLine("Digite la dimension del arreglo");
            objLenght = int.Parse(Console.ReadLine());

            arreglo = new int[objLenght];

            

            for (int i = 0; i < objLenght; i++)
            {
                Console.Write("Ingrese el valor de la celda {0} :", i);
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            GenericsObjects collection = new GenericsObjects();
            collection.ReverseWithQueue(arreglo);
            collection.ReverseWithList(arreglo);
            collection.ReverseWithDict(arreglo);




        }
    }
}
