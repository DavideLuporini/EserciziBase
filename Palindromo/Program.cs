namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola per verificare che sia palindroma");
            string Word = Console.ReadLine();
            //3.Un palindromo è una stringa che, da sinistra a destra e da destra verso sinistra, si legge nello stesso modo.
            //Scrivere un programma che dato una stringa determini se si tratta o no di un palindromo.


            isPalindrom(Word);

        }

            public static void isPalindrom(string word)
        {
            bool isPalindrom = true;
            for (int i = 0; i < word.Length / 2; i++) 
            {
                if (word[i] != word[word.Length - 1 - i]) isPalindrom= false;
            }

            if (isPalindrom) Console.WriteLine($"la parola {word} è palindroma");
            else Console.WriteLine($"a parola {word} non è palindroma");
        }
    }
}