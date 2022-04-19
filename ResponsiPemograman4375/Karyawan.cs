using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4375
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }

        public void daftar()
        {

            Console.WriteLine(" Nama : {0}", Nama);
            Console.WriteLine(" NIK : {0}", NIK);
            Console.WriteLine(" Gaji Bualanan : {0}", GajiBulanan);

           

        }

        public void gaji()
        {
            if (GajiBulanan > 0)
            {
                Console.WriteLine(" Gaji Bualanan : {0}", (GajiBulanan*1.1));
            }
            

            
        }
        
        

    }
}
