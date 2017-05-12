using System;
using System.Collections.Generic;
using System.Text;

namespace harga
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, harga, rek, pakai, total, berenti;
            do
            {
                
                Console.WriteLine("============Jenis Pembayaran============");
                Console.WriteLine("1.Listrik \t= 50000");
                Console.WriteLine("2.Telepon \t= 40000");
                Console.WriteLine("3.Internet \t= 30000");
                Console.WriteLine("========================================\n");
                Console.Write("Masukkan Pilihan : ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        harga = 50000;
                        Console.Write("Masukkan No Rekening \t\t  : ");
                        rek = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Pemakaian (dalam hari)   : ");
                        pakai = int.Parse(Console.ReadLine());
                        total = harga * pakai;
                        Console.WriteLine("\n\n========================================");
                        Console.Write("Rekening anda                     : " + rek);
                        Console.Write("\nTotal Biaya yang harus anda bayar : " + total);
                     
                        break;
                    case 2:
                        harga = 40000;
                        Console.Write("Masukkan No Rekening \t\t  : ");
                        rek = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Pemakaian (dalam hari)   : ");
                        pakai = int.Parse(Console.ReadLine());
                        total = harga * pakai;
                        Console.WriteLine("\n\n========================================");
                        Console.Write("Rekening anda                     : " + rek);
                        Console.Write("\nTotal Biaya yang harus anda bayar : " + total);
                    
                        break;

                    case 3:
                        harga = 30000;
                        Console.Write("Masukkan No Rekening \t\t  : ");
                        rek = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Pemakaian (dalam hari)   : ");
                        pakai = int.Parse(Console.ReadLine());
                        total = harga * pakai;
                        Console.WriteLine("\n\n========================================");
                        Console.Write("Rekening anda                     : " + rek);
                        Console.Write("\nTotal Biaya yang harus anda bayar : " + total);
                       
                        break;
                    default:
                        Console.WriteLine("Inputan Anda Salah, masukkan angka 1-3");
                       
                        break;
                }
                Console.Write("\n\nLanjut atau tidak, jika ya pilih 1 : ");
                berenti = int.Parse(Console.ReadLine());
            }
            while (berenti == 1);
        }
    }
}
