using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KUIS2_16753035
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            int i, j, temp,cari;



            Console.WriteLine("=====MUHAMAD DANIL RAFIQI======");
            Console.WriteLine("============KUIS2==============");
            Console.WriteLine("Masukkan Data");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write("Data ke [{0}] = ", i);
                data[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < data.Length; i++)
            {
                for (j = 0; j < data.Length-1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
            Console.WriteLine("HASIL SORTING :");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write("{0}  ", data[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Masukkan Data yang akan dicari : ");
            cari = int.Parse(Console.ReadLine());
            i = 0;
            while (i < data.Length && cari != data[i])
            {
                i++;
            }

            if (cari == data[i])
            {
                Console.WriteLine("Data ditemukan di lokasi {0}",i);
                Console.Read();
                
            }

            else if (cari != data[i])
            {
                Console.WriteLine("Data Tidak ditemukan");
            }
            Console.ReadLine();
        }
    }
}
