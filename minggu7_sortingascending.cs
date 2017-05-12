using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Array
{
    class Program
    {
        struct Student
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            int numberOfStudents;
            Student[] names;
            string input;

            Console.Write("Masukkan Jumlah Data : ");
            input = Console.ReadLine();
            numberOfStudents = int.Parse(input);

            names = new Student[numberOfStudents];

            Console.WriteLine("Masukkan Data dengan inputan String: ");
            for (int i = 0; i < names.Length; i++)
            {
                Student s;
                Console.Write("Data ke - {0} : ", (i + 1));
                s.Name = Console.ReadLine();
                names[i] = s;
            }
            Array.Sort(names, (x, y) => String.Compare(x.Name, y.Name));

            Console.WriteLine("\nData Setelah di Sorting");
            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine(names[i].Name);
            }
            Console.ReadLine();
        }
    }
}