using System;
using System.Collections.Generic;
using System.Text;

namespace tugashotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int ktp, lama, menu, harga, jenis, diskon, totalbayar;
            Console.WriteLine("============Hotel Melati============");
            Console.Write("Masukkan Nama \t\t\t: ");
            nama = Console.ReadLine();
            Console.Write("Masukkan No KTP \t\t: ");
            ktp = int.Parse(Console.ReadLine());
            Console.Write("Berapa lama anda menginap ? \t: ");
            lama = int.Parse(Console.ReadLine());

            Console.WriteLine("\n============Daftar Harga============");
            Console.WriteLine("1.VIP \t\t= 500000/malam");
            Console.WriteLine("2.Utama \t= 400000/malam");
            Console.WriteLine("3.Standar \t= 200000/malam");
            Console.Write("Masukkan Pilihan");

            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    jenis = 500000;


                    harga = lama * jenis;
                    if (harga > 1500000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else if (harga > 1000000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else
                    {
                        diskon = 0;
                    }

                    totalbayar = harga - diskon;
                    Console.WriteLine("\n============Data Pelanggan============");
                    Console.WriteLine("Nama Pelanggan \t\t: " + nama);
                    Console.WriteLine("No KTP \t\t\t: " + ktp);
                    Console.WriteLine("Lama Inap \t\t: " + lama);
                    Console.WriteLine("Harga Sebelum Diskon \t: " + harga);
                    Console.WriteLine("Diskon \t\t\t: " + diskon);
                    Console.WriteLine("Total Bayar \t\t: " + totalbayar);
                    Console.ReadKey();
                    break;
                case 2:
                    jenis = 400000;

                    harga = lama * jenis;
                    if (harga > 1500000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else if (harga > 1000000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else
                    {
                        diskon = 0;
                    }

                    totalbayar = harga - diskon;
                    Console.WriteLine("\n============Data Pelanggan============");
                    Console.WriteLine("Nama Pelanggan \t\t: " + nama);
                    Console.WriteLine("No KTP \t\t\t: " + ktp);
                    Console.WriteLine("Lama Inap \t\t: " + lama);
                    Console.WriteLine("Harga Sebelum Diskon \t: " + harga);
                    Console.WriteLine("Diskon \t\t\t: " + diskon);
                    Console.WriteLine("Total Bayar \t\t: " + totalbayar);
                    Console.ReadKey();
                    break;

                case 3:
                    jenis = 200000;

                    harga = lama * jenis;
                    if (harga > 1500000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else if (harga > 1000000)
                    {
                        diskon = harga * 10 / 100;
                    }
                    else
                    {
                        diskon = 0;
                    }

                    totalbayar = harga - diskon;
                    Console.WriteLine("\n============Data Pelanggan============");
                    Console.WriteLine("Nama Pelanggan \t\t: " + nama);
                    Console.WriteLine("No KTP \t\t\t: " + ktp);
                    Console.WriteLine("Lama Inap \t\t: " + lama);
                    Console.WriteLine("Harga Sebelum Diskon \t: " + harga);
                    Console.WriteLine("Diskon \t\t\t: " + diskon);
                    Console.WriteLine("Total Bayar \t\t: " + totalbayar);
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Inputan Anda Salah, masukkan angka 1-3");
                    Console.ReadKey();
                    break;
            }
        }
    }

}
