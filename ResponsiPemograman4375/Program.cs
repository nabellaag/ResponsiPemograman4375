using System;

namespace ResponsiPemograman4375 // project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek karyawan
            Karyawan k1 = new Karyawan();
            Karyawan k2 = new Karyawan();


            k1.Nama = "Nabella";
            k1.NIK = "21114375";
            k1.GajiBulanan = 5000000;

            k2.Nama = "Nabella";
            k2.NIK = "21114375";
            k2.GajiBulanan = 5000000;


            k1.daftar();
            k2.daftar();

            Console.ReadKey();



        }
    }
}
