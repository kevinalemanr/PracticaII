using System;
using System.Diagnostics;


namespace Programa03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch reloj = new Stopwatch();

            Passwords[] P = new Passwords[1000000];
            Keyword[] K = new Keyword[10000000];
           
            reloj.Start();

            for(int k = 0; k<1000000; k++) 
            {
                P[k] = new Passwords(k, "nombre", "pass");
            }

            reloj.Stop();
            TimeSpan elapsedTimeClass = reloj.Elapsed;

            string execTimeClass = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            elapsedTimeClass.Hours, elapsedTimeClass.Minutes, elapsedTimeClass.Seconds,
                                            elapsedTimeClass.Milliseconds / 10);

            Console.WriteLine("El timepo de ejecucion para la clase es: " + execTimeClass);

            reloj.Restart();

            reloj.Start();
            for (int j = 0; j < 1000000; j++)
            {
                K[j] = new Keyword(j, "nombre", "pass");
            }

            reloj.Stop();
            TimeSpan elapsedTimeStruct = reloj.Elapsed;

            string execTimeStruct = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            elapsedTimeStruct.Hours, elapsedTimeStruct.Minutes, elapsedTimeStruct.Seconds,
                                            elapsedTimeStruct.Milliseconds / 10);

            Console.WriteLine("El timepo de ejecucion para el struct es: " + execTimeStruct);






        }
    }
}
