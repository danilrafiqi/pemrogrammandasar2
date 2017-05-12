using System;
using System.Collections.Generic;
using System.Text;

namespace array
{
    static class konstanta
    {
       // static void Ma
        public static readonly string[] hari = {
        "Minggu", "Senin", "Selasa", "Rabu","Kamis", "Jumat", "Sabtu",
        };
        public static readonly string[] bulan = {
        "Januari", "Februari", "Maret", "April", "Mei","Juni","Juli","Agustus","September","Oktober","November","Desember"
        };
    }

    class demoarraynonkonstanta
    {
        static void Main ()
        {
        int nohari, nobulan;
        Console.Write("Masukkan No Hari ");
        nohari = int.Parse(Console.ReadLine());
        Console.Write("Masukkan No Bulan ");
        nobulan = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hari Ke - " + nohari + " adalah " + konstanta.hari[nohari - 1]);
        Console.WriteLine("Bulan Ke - " + nobulan + " adalah " + konstanta.bulan[nobulan - 1]);
        Console.ReadLine();
        }
    }
}
