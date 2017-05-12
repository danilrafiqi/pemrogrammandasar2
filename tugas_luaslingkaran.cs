using System;
using System.Collections.Generic;
using System.Text;

namespace lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            double fi = 3.14, r, luas;
            Console.Write("Masukkan Panjang jari jari");
            r = Convert.ToDouble(Console.ReadLine());
            luas = fi * r * r;
            Console.Write("Luas Lingkaran Adalah = " + luas);
            Console.ReadLine();
        }
    }
}
