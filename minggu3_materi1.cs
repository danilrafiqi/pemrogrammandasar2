using System;
using System.Collections.Generic;
using System.Text;

namespace gaji
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaji, pajak;
            string nama;
            double gajibersih;
            Console.Write("Masukkan Nama Anda ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Gaji Anda ");
            gaji = int.Parse(Console.ReadLine());
            if (gaji > 5000000)
            {
                pajak =gaji* 10/100;
            }
            else if (gaji > 3000000)
            {
                pajak =gaji* 5/100;
            }
            else
            {
                pajak = 0;
            }
            gajibersih = gaji - pajak;
            Console.WriteLine("==================================================================");
            Console.WriteLine("Pajak yang harus anda bayar sebesar "+pajak);
            Console.WriteLine(nama + " mendapatkan gaji bersih sebesar " + gajibersih);
            Console.WriteLine("==================================================================");
            Console.ReadKey();
        }
    }
}