using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AsalsayiBulmaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var kronometre = new Stopwatch();
            kronometre.Start();
            List<int> asallar = new List<int>();
            bool result = true;

            Console.WriteLine("0 ile arasında olmasını istediğin aralığı giriniz: ");
            var kacaKadar = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < kacaKadar; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.WriteLine(i + ". Ben asalım.");

                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    result = i % j == 0;
                    if (result)
                    {
                        break;
                    }

                }
                if (result == false)
                {
                    Console.WriteLine(i + ". Ben asalım.");
                    asallar.Add(i);

                }
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(asallar.Count());
        }
    }
}
