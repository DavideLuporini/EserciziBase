using System.Security.Cryptography.X509Certificates;

namespace Crucipuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            // definisco la tavola di gioco
            char[,] matrix = new char[,]
            {
            {'M', 'A', 'T', 'E', 'C'},
            {'O', 'E', 'N', 'O', 'A'},
            {'M', 'E', 'L', 'O', 'N'},
            {'E', 'C', 'O', 'A', 'E'},
            {'S', 'S', 'O', 'A', 'I'}
            };



            //stampare la griglia



            GenerateGrill(matrix);
            string InputWord = string.Empty;

            
            //! PERCHE' MI STAMPA ANCHE "EXIT NON TROVATA" 
            while ( InputWord != "EXIT")
            {
                if (InputWord == "EXIT") return;
                else
                {
                    Console.WriteLine("Inserisci una parola da cercare nella griglia");
                    InputWord = Console.ReadLine().ToUpper();
                    ScanInputWord(InputWord, matrix);
                }

            }





            
           
               
            
        }


        //metodo per generare la griglia
        public static void GenerateGrill(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void ScanInputWord(string inputWord, char[,] matrix)
        {

            bool found = false;

            // Scandiamo ogni cella della matrice
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Cerchiamo la parola in orizzontale
                    if (j + inputWord.Length <= matrix.GetLength(1) &&
                        string.Join("", GetRow(matrix, i, j, inputWord.Length)) == inputWord)
                    {
                        Console.WriteLine("{0} trovata in orizzontale alle coordinate ({1},{2})", inputWord, i, j);
                        found = true;
                    }

                    // Cerco la parola in verticale
                    if (i + inputWord.Length <= matrix.GetLength(0) &&
                        string.Join("", GetColumn(matrix, i, j, inputWord.Length)) == inputWord)
                    {
                        Console.WriteLine("{0} trovata in verticale alle coordinate ({1},{2})", inputWord, i, j);
                        found = true;
                    }

                    // Cerco la parola in diagonale
                    if (i + inputWord.Length <= matrix.GetLength(0) &&
                        j + inputWord.Length <= matrix.GetLength(1) &&
                        string.Join("", GetDiagonal(matrix, i, j, inputWord.Length)) == inputWord)
                    {
                        Console.WriteLine("{0} trovata in diagonale alle coordinate ({1},{2})", inputWord, i, j);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("{0} non trovata", inputWord);
            }


            // ìCerco nella riga
            static char[] GetRow(char[,] matrix, int i, int j, int length)
            {
                char[] row = new char[length];
                for (int k = 0; k < length; k++)
                {
                    row[k] = matrix[i, j + k];
                }
                return row;
            }

            // cerco nella colonna
            static char[] GetColumn(char[,] matrix, int i, int j, int length)
            {
                char[] column = new char[length];
                for (int k = 0; k < length; k++)
                {
                    column[k] = matrix[i + k, j];
                }
                return column;
            }

            // cerco nella diagonale
            static char[] GetDiagonal(char[,] matrix, int i, int j, int length)
            {
                char[] diagonal = new char[length];
                for (int k = 0; k < length; k++)
                {
                    diagonal[k] = matrix[i + k, j + k];
                }
                return diagonal;
            }

        }

    }

}