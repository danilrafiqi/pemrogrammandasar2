using System;
using System.Collections.Generic;
using System.Text;

namespace nilai
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, matkul, huruf;
            int na, kuis, tugas, uts, uas;
            Console.WriteLine("=====Daftar Nilai Mahasiswa=====");
            Console.Write("Masukkan Nama \t: ");
            nama = Console.ReadLine();
            Console.Write("Mata Kuliah \t: ");
            matkul = Console.ReadLine();
            Console.Write("Nilai Kuis \t: ");
            kuis = int.Parse(Console.ReadLine());
            Console.Write("Nilai Tugas \t: ");
            tugas = int.Parse(Console.ReadLine());
            Console.Write("Nilai UTS \t: ");
            uts = int.Parse(Console.ReadLine());
            Console.Write("Nilai UAS \t: ");
            uas = int.Parse(Console.ReadLine());
            //int.Parse(na);
            na = (kuis * 10 / 100) + (tugas * 10 / 100) + (uts * 30 / 100) + (uas * 50 / 100);
            if (na >= 80)
            {
                huruf = "A";
            }
            else if (na >= 70)
            {
                huruf = "B";
            }
            else if (na >= 60)
            {
                huruf = "C";
            }
            else if (na >= 50)
            {
                huruf = "D";
            }
            else
            {
                huruf = "E";
            }
            Console.WriteLine();
            Console.WriteLine("===========Daftar Nilai Mahasiswa===========");
            Console.WriteLine("Nama \t\t: "+ nama);
            Console.WriteLine("Mata Kuliah \t: " + matkul);
            Console.WriteLine("Nilai Akhir \t: " + na);
            Console.WriteLine("Huruf Mutu \t: " + huruf);
            Console.WriteLine("===========Daftar Nilai Mahasiswa===========");
            Console.ReadLine();
            }
    }
}
