using System;
using System.Collections.Generic;
using System.Text;

namespace angkaulang
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,tampil,tampill;
            Console.Write("Masukkan Jumlah angka ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("====================");
            for (b = a; b >= 1; b--)
            {
                tampil=b;
                tampill = b;
                for (c = 1; c <= b; c++)
                {
                    Console.Write(tampil+"     ");
                    tampil = tampill+tampil;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}















        
