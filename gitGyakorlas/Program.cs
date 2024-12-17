using System;

namespace gitGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            F01(szamok);
            F05(szamok);
        }

        static void F01(int[] tomb)
        {
            Random random = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 51);
            }
        }

        static int F02(int[] tomb)
        {
            int count = 0;

            for (int i = 0; i <= tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0) { count++; }
            }
            return count;
        }

        static double F03(int[] tomb)
        {
            double atlag = 0;

            for (int i = 0;i <= tomb.Length; i++)
            {
                atlag += tomb[i];
            }
            atlag /= tomb.Length;

            return atlag;
        }

        static int[] F04(int[] tomb)
        {
            int[] paratlanok = new int[10];

            for (int i = 0; i < tomb.Length; i++) 
            {
                if (tomb[i] % 2 == 0)
                {
                    paratlanok[i] = tomb[i] + 1;
                }
                else
                {
                    paratlanok[i] = tomb[i];
                }
            }
            return paratlanok;
        }

        static void F05(int[] tomb)
        {
            Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {F02(tomb)}");
            Console.WriteLine($"A tömb elemeinek átlaga: {F03(tomb)}");

            Console.Write("A tömbből alkotott páratlan számok: ");
            int[] paratlan = F04(tomb);
            foreach (int num in paratlan)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();

        }
    }
}
