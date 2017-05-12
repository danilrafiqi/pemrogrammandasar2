using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDanilRafiqi
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,batas,temp,j;
            

            Console.Write("Masukan Panjang Array = ");
            batas = int.Parse(Console.ReadLine());
            int[] angka = new int[batas];
            for (i = 0; i < angka.Length; i++)
            {
                Console.Write("Array ke [{0}] = ", i);
                angka[i] = int.Parse(Console.ReadLine());
            }

            for (i = (angka.Length - 1); i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    {
                        if (angka[j - 1] > angka[j])
                        {
                            temp = angka[j - 1];
                            angka[j - 1] = angka[j];
                            angka[j] = temp;
                        }
                    }
                }
            } 
            Console.WriteLine(" ");
                Console.WriteLine("HASIL SORTING :");
                for (i = 0; i < angka.Length; i++)
                {
                    Console.Write("{0}  ", angka[i]);
                }
                Console.ReadLine();
            

        }
    }
}
