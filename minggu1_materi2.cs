using System;
class Latihan1_3
{
    static void Main(string[] args)
    {
        ushort hari, bulan, tahun;
        Console.WriteLine("Hitung Usia");
        Console.WriteLine("-----------");
        try
        {
            Console.Write("Tanggal Lahir\t : ");
            hari = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Bulan Lahir\t : ");
            bulan = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Tahun Lahir\t : ");
            tahun = Convert.ToUInt16(Console.ReadLine());
            DateTime ultah = new DateTime(tahun,bulan,hari);
            DateTime hariIni=DateTime.Now;
            TimeSpan usia= hariIni.Subtract(ultah);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("umur kamu adalah {0} hari, {1} jam"+"{2} menit.",usia.Days, usia.Hours, usia.Minutes);
            Console.ReadLine();
        }
        catch (FormatException e)
        {
            Console.WriteLine("Data tanggal, bulan, dan tahun harus berupa angka");
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi Kesalahan : ", e.Message);
            Console.ReadLine();
        }
    }
}
