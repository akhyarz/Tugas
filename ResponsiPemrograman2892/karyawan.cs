using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2892
{
    class karyawan
    {
        public string NAMA1;
        public string NIK1;
        public float GAJI1;
        public string NAMA2;
        public string NIK2;
        public float GAJI2;

        public void GAJIBULANAN()
        {
            Console.WriteLine("NO NIK/ NAMA \t\t\tGAJIBULANAN");
            Console.WriteLine("==============================");
            Console.WriteLine("1.{0} {1}\t\t{2}", NIK1, NAMA1, GAJI1);
            Console.WriteLine("1.{0} {1}\t\t{2}", NIK2, NAMA2, GAJI2);
            Console.WriteLine("   ");
        }
        public void kenaikangaji ()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Asyiiiiik kenaikana gaji 10%!! ;"
            Console.WriteLine("==============================");
            
           
        }
    }

    }
}
