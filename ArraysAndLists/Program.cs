using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var evens = new List<int>();

            var odds = new List<int>();




            for (int e = 1; e <= 10; e++)
            {
                if (e % 2 == 0)
                {
                    evens.Add(e);
                }
                else
                {
                    odds.Add(e);
                }
            }


            foreach (var e in evens)
            {
                Console.WriteLine("##############Even Numbers###############");
                Console.WriteLine(e);
            }
            foreach (var e in odds)
            {
                Console.WriteLine("#############Odd Numbers#################");
                Console.WriteLine(e);

            }

        }


    }
}
