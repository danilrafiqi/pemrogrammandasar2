using System;
using System.Collections.Generic;
using System.Text;

namespace Luassegitiga
{
    class Program
    {
        static void Main(string[] args)
        {
            double alas, tinggi,luas;
            Console.Write("Masukan nilai Alas: ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan nilai Tinggi: ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            luas = alas * tinggi / 2;
            Console.Write("Luas segtiga adalah: "+luas);
            Console.Read();
        }
    }
}
