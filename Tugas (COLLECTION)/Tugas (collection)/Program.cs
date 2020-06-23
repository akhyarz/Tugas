using System;
using System.Collections;
using System.Collections.Generic;


namespace Tugas__collection_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas lab 8 (Collections)";

            //membuat objek untuk semua karyawan
            
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19112892";
            karyawanTetap.Nama = "M.Muh.Akhyar.Z";
            karyawanTetap.GajiBulanan = 1000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "28921911";
            karyawanHarian.Nama = "Claude";
            karyawanHarian.JumlahJamKerja = 9;
            karyawanHarian.UpahPerjam = 150000;

            Sales sales = new Sales();
            sales.Nik   = "11289219";
            sales.Nama = "Granger";
            sales.JumlahPenjualan = 3;
            sales.Komisi = 500000;

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int Nourut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}.NIK: {1}\t,NAMA: {2}\t,GAJI:\tRp. {3:0}",
                                   Nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                Nourut++;
            }
            Console.ReadKey();
        }
    }
}
