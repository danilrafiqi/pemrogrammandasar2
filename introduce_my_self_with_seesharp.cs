using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong npm, umur, telepon;
            string namalengkap, namapanggilan, tempatlahir,alamat;
            Console.WriteLine("Program Perkenalan");
            Console.WriteLine("====================================================");
            Console.Write("Masukkan Nama Lengkap\t : ");
            namalengkap = Console.ReadLine();
            Console.Write("Masukkan Nama Panggilan\t : ");
            namapanggilan = Console.ReadLine();
            Console.Write("Masukkan NPM\t\t : ");
            npm = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Masukkan Umur\t\t : ");
            umur = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Masukkan Tempat Lahir\t : ");
            tempatlahir = Console.ReadLine();
            Console.Write("Masukkan Nomor Telepon\t : ");
            telepon = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Masukkan Alamat\t\t : ");
            alamat = Console.ReadLine();
            Console.Write("\n============================Intoduce My Self==================================");
            Console.Write("\nAssalamualaikum. Let me introduce my self. My name is {0}, but\nyou can call me {1}. My NPM is {2}. I was born in {3}.\nand I am {4} years old. I am very glad if you want to invite my\nhouse in {5}. So, don't forget to call me before with the number\n{6}. Thank you.", namalengkap, namapanggilan, npm, tempatlahir, umur, alamat, telepon);
            Console.ReadLine();
        }
    }
}
