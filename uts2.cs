using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuhamadDanilRafiqi_UTS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, batas,menu;
            string berhenti;
            int[] celcius = new int[5];
            int[] fah = new int[5];
            int[] ream = new int[5];
            int[] kelv = new int[5];
            int[] rupiah = new int[5];
            int[] dollar = new int[5];
            int[] yen = new int[5];
            int[] peso = new int[5];
            //int fah, ream, kelv;
            //int dollar, yen, peso;
            //int pilih;

            do{
                Console.WriteLine("1. Suhu");
                Console.WriteLine("2. Uang");
                Console.Write("Masukkan Pilihan = ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("Konversi Suhu akan dilakukan berapa kali ? = ");
                        batas = int.Parse(Console.ReadLine());
                        for (i = 1; i <= batas; i++)
                        {
                            Console.WriteLine("Konversi suhu ke " + i);
                            Console.Write("Masukkan Nilai celcius ke " + i + " = ");
                            celcius[i] = int.Parse(Console.ReadLine());
                        }

                        for (i = 1; i <= batas; i++)
                        {
                            Console.WriteLine("Hasil konversi {0}, untuk {1} celcius", i, celcius[i]);
                            //int hitfah = (9 / 3);
                            fah[i] = ((9 / 5) * celcius[i]) + 32;
                            ream[i] = ((4 / 9) * celcius[i]) - 32;
                            kelv[i] = 273 + celcius[i];
                            Console.WriteLine("Fahrenheit = " + fah[i]);
                            Console.WriteLine("Reamur = " + ream[i]);
                            Console.WriteLine("Kelvin = " + kelv[i]);
                        }
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Konversi Rupiah akan dilakukan berapa kali ? = ");
                        batas = int.Parse(Console.ReadLine());
                        for (i = 1; i <= batas; i++)
                        {
                            Console.WriteLine("Konversi rupiah ke " + i);
                            Console.Write("Masukkan Nilai Rupiah ke " + i + " = ");
                            rupiah[i] = int.Parse(Console.ReadLine());
                        }

                        for (i = 1; i <= batas; i++)
                        {
                            Console.WriteLine("Hasil konversi {0}, untuk {1} Rupiah", i, rupiah[i]);
                            //int hitfah = (9 / 3);
                            dollar[i] = rupiah[i] / 13000;
                            yen[i] = rupiah[i] / 5000;
                            peso[i] = rupiah[i] / 4000;
                            Console.WriteLine("Dollar = " + dollar[i]);
                            Console.WriteLine("Yen = " + yen[i]);
                            Console.WriteLine("Peso = " + peso[i]);
                        }
                        Console.ReadLine();
                        break;
                }
                Console.Write("\n\nLanjut atau tidak, jika ya pilih y : ");
                berhenti = Console.ReadLine();
            } 
            while (berhenti == "y");
        }
    }
}
