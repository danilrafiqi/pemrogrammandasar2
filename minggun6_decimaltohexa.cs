using System;
using System.Collections.Generic;

using System.Text;

namespace TUGAS_DESIMAL_KE_HEXADESIMAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber, quotient;

            int i = 1, j, temp = 0;

            char[] hexadecimalNumber = new char[100];

            char temp1;

            Console.Write("Decimal :");

            decimalNumber = int.Parse(Console.ReadLine());

            quotient = decimalNumber;

            while (quotient != 0)
            {

                temp = quotient % 16;

                if (temp < 10)

                    temp = temp + 48;

                else

                    temp = temp + 55;

                temp1 = Convert.ToChar(temp);

                hexadecimalNumber[i++] = temp1;

                quotient = quotient / 16;

            }

            Console.Write("HexaDecimal : ");

            for (j = i - 1; j > 0; j--)

                Console.Write(hexadecimalNumber[j]);

            Console.Read();
        }
    }
}