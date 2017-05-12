using System;
using System.Collections.Generic;
using System.Text;

namespace nama_hari
{
    class Program
    {
        static void Main(string[] args)
        {
            int hari;
            Console.WriteLine("MASUKAN PILIHAN HARI 1 - 7 : ");
            hari = int.Parse(Console.ReadLine());
            switch (hari)
            {
                case 1:
                    Console.WriteLine("Minggu");
                    break;
                case 2:
                    Console.WriteLine("Senin");
                    break;
                case 3:
                    Console.WriteLine("Selasa");
                    break;
                case 4:
                    Console.WriteLine("Rabu");
                    break;
                case 5:
                    Console.WriteLine("Kamis");
                    break;
                case 6:
                    Console.WriteLine("Jumat");
                    break;
                case 7:
                    Console.WriteLine("Sabtu");
                    break;
                default:
                    Console.WriteLine("Salah memasukan input (1-7)");
                    break;
            }
        }
    }
}