using System;
using System.Collections.Generic;
using System.Text;

namespace persegipanjang
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang, lebar, luas;
            Console.Write("masukkan nilai panjang :");
            panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan nilai lebar :");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            luas = Convert.ToInt32(panjang * lebar);
            Console.WriteLine("luasnya adalah ={0} ", luas);
            Console.Read();
        }
    }
}
