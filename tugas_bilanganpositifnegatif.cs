using System;
using System.Collections.Generic;
using System.Text;

namespace PositifNegatifangka
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka;
            string ket;

            Console.Write("Masukkan angka positif atau negatif ");
            angka = int.Parse(Console.ReadLine());

            if (angka > 0)
            {
                ket = "POSITIF";
            }
            else if (angka == 0)
            {
                ket = "NOL";
            }
            else
            {
                ket = "NEGATIF";

            }
            Console.Write(angka + "adalah bilangan" + ket);
            Console.ReadLine();
        }
    }
}
