using static System.Formats.Asn1.AsnWriter;
using System;
using System.Net;

namespace Appuntamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Due colleghi intendono fissare una riunione, pertanto devono identificare dei giorni nei quali
            //sono entrambi liberi da impegni. 
            //A tale scopo essi realizzano un programma che permetta a ciascuno di immettere le proprie disponibilità,
            //e che identifichi i giorni nei quali entrambi sono liberi. (ipotizzare che i giorni siano numeri interi)
            var Disponibilita = new List<int>();
            Console.WriteLine("utente 1 inserisci le tue disponibilità");
            inputDisponibilities(Disponibilita);
            Console.WriteLine("utente 2 inserisci le tue disponibilità");
            inputDisponibilities(Disponibilita);
            generateCalendar(Disponibilita);
        }

        public static void inputDisponibilities(List<int> list)
        {
            Console.WriteLine("inserisci 0 per terminare l'inserimento dei giorni disponibili");
            int input = 1;
            while(input != 0)
            {
                input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

        }

        public static void generateCalendar(List<int> list)
        {

            if (list.Count != list.Distinct().Count())
            {
                var duplicates = list.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key);
                foreach (var d in duplicates)
                    Console.WriteLine(d);
            }
        }

        
    }

}