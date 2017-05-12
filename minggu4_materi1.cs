using System;
using System.Collections.Generic;
using System.Text;

namespace angka
{
    class Program
    {
        static void Main(string[] args)
        {
            //program pertambahan angka
            //by danilr
            int angka, tambah=1, sebelah=1;
            Console.Write("masukkan angka");
            angka = int.Parse(Console.ReadLine());
           
                for (int j=1; j <= angka; j++)
                {
                   
                    Console.Write(tambah+" "+sebelah);
                    tambah += 1;
                    sebelah = sebelah + tambah;
                    Console.WriteLine();
                } 
            Console.ReadLine();
        }
    }
}

