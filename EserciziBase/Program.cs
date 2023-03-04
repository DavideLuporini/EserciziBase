namespace ListaNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("inserisci il numero di elementi ");
            int n = int.Parse(Console.ReadLine());

            int[] sequenza = new int[n];
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1} numero");
                sequenza[i] = int.Parse(Console.ReadLine());
            }

            CalcoloNumeriPositivi(sequenza);
            CalcoloNumeriNulli(sequenza);
            CalcoloNumeriNegativi(sequenza);
            DefineOrder(sequenza);
            Console.WriteLine(DefineOrder(sequenza));
        }

        public static void CalcoloNumeriPositivi(int[] sequenza)
        {
            Console.WriteLine("I numeri positivi sono:");
            foreach (var i in sequenza)
            {
                if (i > 0) Console.Write(i + " ");
            }
        }
        public static void CalcoloNumeriNulli(int[] sequenza)
        {
            Console.WriteLine("I numeri nulli sono:");
            foreach (var i in sequenza)
            {
                if (i == 0) Console.Write(i + " ");
            }
        }

        public static void CalcoloNumeriNegativi(int[] sequenza)
        {
            Console.WriteLine("I numeri Negativi sono:");
            foreach (var i in sequenza)
            {
                if (i < 0) Console.Write(i + " ");
            }
        }

        public static string DefineOrder(int[] sequenza)
        {
            if (sequenza.Length == 0) return "la lista non è ne crescente ne decrescente";


            bool isCrescente = true;
            bool isDecrescente = true;

            for(int i = 0; i < sequenza.Length - 1; i++)
            {
                if (sequenza[i] > sequenza[i+1])
                {
                isCrescente = false;
                }else if (sequenza[i] < sequenza[i + 1])
                {
                    isDecrescente = false;
                }
            }


            //verifico in che caso siamo
            if (isCrescente) return "la sequenza è crescente";
            else if (isDecrescente) return "la sequenza è decrescente";
            else return "la sequenza non è ne crescente ne decrescente";
        }
    }
}