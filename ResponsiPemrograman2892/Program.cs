using System;

namespace ResponsiPemrograman2892
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan = new karyawan();

            karyawan.NIK1 = "1903022123";
            karyawan.NAMA1 = "bima";
            karyawan.GAJI1 = 2500000;

            karyawan.GAJIBULANAN();
            karyawan.kenaikangaji();



        }
    }
}
