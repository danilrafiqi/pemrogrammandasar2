using System;
using System.Collections.Generic;

using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1, y = 1, z = 1;

            Console.Write("jumlah bilangan Fibonasi yang ingin ditampilkan =");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.ReadLine();

        }
    }
}