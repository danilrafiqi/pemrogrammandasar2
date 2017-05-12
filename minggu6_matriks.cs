using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace TUGAS_PENJUMLAHAN_MATRIKS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int baris, kolom;
            int[,] matrik_a;
            int[,] matrik_b;
            Console.Write("Jumlah Baris Matriks : ");
            baris = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Kolom Matriks : ");
            kolom = int.Parse(Console.ReadLine());
            Console.WriteLine();

            matrik_a = new int[baris, kolom];
            matrik_b = new int[baris, kolom];
            Console.Write("Matriks A\n");
            Console.WriteLine("------------");
            Console.WriteLine();

            for (a = 0; a < baris; a++)
            {
                for (b = 0; b < kolom; b++)
                {
                    Console.Write(" Matriks A [" + (a + 1) + "][" + (b + 1) + "] = ");
                    matrik_a[a, b] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.Write("Matriks B\n");
            Console.WriteLine("------------");
            Console.WriteLine();

            for (a = 0; a < baris; a++)
            {
                for (b = 0; b < kolom; b++)
                {
                    Console.Write(" Matriks B [" + (a + 1) + "][" + (b + 1) + "] = ");
                    matrik_b[a, b] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("HasilPenjumlahanMatriks A & B");
            Console.WriteLine("----------------------------------");

            for (a = 0; a < baris; a++)
            {
                for (b = 0; b < kolom; b++)
                {
                    Console.Write(matrik_a[a, b] + matrik_b[a, b] + " \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine("HasilPenguranganMatriks A & B");
            Console.WriteLine("----------------------------------");

            for (a = 0; a < baris; a++)
            {
                for (b = 0; b < kolom; b++)
                {
                    Console.Write(matrik_a[a, b] - matrik_b[a, b] + " \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("HasilPerkalianMatriks A & B");
            Console.WriteLine("----------------------------------");

            for (a = 0; a < baris; a++)
            {
                for (b = 0; b < kolom; b++)
                {
                    Console.Write(matrik_a[a, b] * matrik_b[a, b] + " \t");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}