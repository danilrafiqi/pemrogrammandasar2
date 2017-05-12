using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuhamadDanilRafiqi_UAP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, j;
            Console.Write("Masukkan Jumlah Baris Bintang ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            for (i = 0; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 0; i <= a; i++)
            {
                for (j = i; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
