using System;
using System.Xml.Linq;

namespace Vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4.Scrivere un programma che crei un vettore di 100 interi contenente numeri casuali compresi tra 1 - 100 
            //    e un algoritmo per contare gli elementi pari compresi tra 10 e 20

            int[] vector = new int[100];
            generateNumbers(vector);
            Console.WriteLine(CountNumbersBetween10and20(vector));
        }

        public static void generateNumbers(int[] vector)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var num = rnd.Next(10, 101);
                vector[i] = num;

            }
        }

        public static int CountNumbersBetween10and20(int[] vector)
        {
            var count = 0;
            foreach (int num in vector)
            {
                if (num > 10 && num < 20) count++;
            }

            return count;
        }

    }
}