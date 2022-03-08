using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Programa04
{
    class GenericsObjects
    {
        Stopwatch reloj = new Stopwatch();


        public GenericsObjects() 
        {
        }

        public void ReverseWithQueue(int[] T) 
        {
            Queue fila = new Queue();
            reloj.Restart();
            reloj.Start();
            for (int i = T.Length - 1; i >= 0; i--) 
            {
                fila.Enqueue(T[i]);
            }
            
            Console.WriteLine($"La forma inversa del arreglo por Queue es: \n");

            foreach (int n in fila)
            {
                Console.WriteLine(n);
            }
            reloj.Stop();

            TimeSpan elapsedTimeQueue = reloj.Elapsed;

            string execTimeQueue = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            elapsedTimeQueue.Hours, elapsedTimeQueue.Minutes, elapsedTimeQueue.Seconds,
                                            elapsedTimeQueue.Milliseconds / 10);
            Console.WriteLine("El timepo de ejecucion para el Queue es: " + execTimeQueue);
        }

        public void ReverseWithList(int[] T)
        {
            List<int> newList = new List<int>();

            reloj.Restart();
            reloj.Start();
            
            for (int i = T.Length - 1; i >= 0; i--)
            {
                newList.Add(T[i]);
            }

            Console.WriteLine($"La forma inversa del arreglo por Lista es: \n");


            foreach (int m in newList) 
            {
                Console.WriteLine(m);
            }
            reloj.Stop();

            TimeSpan elapsedTimeList = reloj.Elapsed;

            string execTimeList = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            elapsedTimeList.Hours, elapsedTimeList.Minutes, elapsedTimeList.Seconds,
                                            elapsedTimeList.Milliseconds / 10);
            Console.WriteLine("El timepo de ejecucion para la lista es: " + execTimeList);

        }

        public void ReverseWithDict(int[] T)
        {
            Dictionary<int,int> newDictionary = new Dictionary<int,int>();

            reloj.Restart();
            reloj.Start();

            for (int i = T.Length - 1; i >= 0; i--)
            {
                newDictionary.Add(i, T[i]);
            }

            Console.WriteLine($"La forma inversa del arreglo por Diccionario es: \n");

            foreach (KeyValuePair<int, int> items in newDictionary)
            {
                Console.WriteLine(items.Value);
            }

            reloj.Stop();

            TimeSpan elapsedTimeDict = reloj.Elapsed;

            string execTimeDict = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            elapsedTimeDict.Hours, elapsedTimeDict.Minutes, elapsedTimeDict.Seconds,
                                            elapsedTimeDict.Milliseconds / 10);
            Console.WriteLine("El timepo de ejecucion para el diccionario es: " + execTimeDict);
        }

    }
}
