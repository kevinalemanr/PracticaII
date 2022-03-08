using System;

namespace Programa02
{
    class Program
    {
        static void Main(string[] args)
        {

            Metros valor1 = new Metros(1);
            Pies pie1 = valor1;
            Console.WriteLine("El valor en pies es: {0} ", pie1.distancia);

            Pies valor2 = new Pies(1);
            Metros metro1 = valor2;
            Console.WriteLine("El valor en metros es: {0}", metro1.distancia);
        
        }
    }
}
