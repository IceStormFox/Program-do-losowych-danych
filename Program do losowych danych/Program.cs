using System;

namespace Program_do_losowych_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            int wylosowana = new int();
            int i = new int();
            int[] tbl = new int[200000];
            int ileliczb = new int();
            ileliczb = 200000;
            var rnd = new Random();
            wylosowana = rnd.Next(1, 1000000);

            using (System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"E:\Studia\Sortowanie bąbelkowe\danelosowee.txt"))
            {
                for (i = 0; i < ileliczb; i++)
                {
                    wylosowana = rnd.Next(1, 1000000);
                    tbl[i] = wylosowana;
                    file2.WriteLine(tbl[i]);
                }

            }
            Console.WriteLine("Koniec programu. Wciśnij cokolwiek by kontynuować.");
            Console.ReadKey();
        }
    }
}
