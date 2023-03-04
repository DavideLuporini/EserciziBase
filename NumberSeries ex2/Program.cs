namespace SerieNumerica
{


    internal class Program
    {

        //2.Generare una serie di numeri tra 1 e 40 casuali.
        //La serie termina quando la somma dei numeri generati è maggiore o uguale a 100 
        //oppure quando è stato raggiunto il numero di tentativi stabiliti.
        //Per i numeri casuali cercare e provare a utilizzare la classe Random
        static void Main(string[] args)
        {

            var list = new List<int>();


            Console.WriteLine("con quanti numeri desideri sia generata la lista?");
            var input = int.Parse(Console.ReadLine());
            generateNumbers(list , input);
            displayList(list);


        }

        public static void generateNumbers(List<int> list , int n)
        {
            int number = 0;
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                if(number < 100)
                {
                    var num = rnd.Next(10, 40);
                    number += num;
                    list.Add(num);
                }
            }
            Console.WriteLine(number);
        }
        
        public static void displayList(List<int> list)
        {
            Console.WriteLine("la lista è composta dai seguenti numeri :");
            foreach(var item in list)
            {
                Console.Write( " " + item + " ");
            }
        }
    }
}