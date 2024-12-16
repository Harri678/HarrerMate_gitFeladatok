﻿using System;

namespace gitGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
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



    }
}
