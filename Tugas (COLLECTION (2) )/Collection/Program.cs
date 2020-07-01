using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> karyawanTetap = new List<KaryawanTetap>();
            List<KaryawanHarian> karyawanHarian = new List<KaryawanHarian>();
            List<Sales> sales = new List<Sales>();

           
            
           Menu:
            Console.WriteLine("|=========MENU KARYAWAN==========|");
            Console.WriteLine("|1. Input Data karyawan          |");
            Console.WriteLine("|2. Data Karyawan                |");
            Console.WriteLine("|3. Hapus Data Karyawan          |");
            Console.WriteLine("|4. Keluar Program               |");
            Console.WriteLine("|================================|");
            Console.Write(    " > Pilih Menu : ");
            int pilihan;
            int pilih;
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan==1)
            {
                Console.WriteLine("|=========Menu Input==========|");
                Console.WriteLine("|1. Input Karyawan Tetap      |");
                Console.WriteLine("|2. Input Karyawan Harian     |");
                Console.WriteLine("|3. Input Sales               |");
                Console.WriteLine("|=============================|");
                Console.Write(    "> Pilih Menu : ");
                pilih = int.Parse(Console.ReadLine());

                if (pilih==1) 
                {
                    string Nik,Nama;
                    Double GajiBulanan;
                    Console.Write("> Masukkan NIK  :");
                    Nik = Console.ReadLine();
                    Console.Write("> Masukkan NAMA :");
                    Nama = Console.ReadLine();
                    Console.Write("> Masukkan Gaji Bulanan :");
                    GajiBulanan = int.Parse(Console.ReadLine());

                    karyawanTetap.Add(new KaryawanTetap() {Nik=Nik,Nama=Nama,GajiBulanan=GajiBulanan });
                }
                else if (pilih==2)
                {
                    string Nik, Nama;
                    Double Jam;
                    Double Gaji;
                    Console.Write("> Masukkan NIK  :");
                    Nik = Console.ReadLine();
                    Console.Write("> Masukkan NAMA :");
                    Nama = Console.ReadLine();
                    Console.Write("> Masukkan Jam  :");
                    Jam = int.Parse(Console.ReadLine());
                    Console.Write("> Masukkan Gaji :");
                    Gaji = int.Parse(Console.ReadLine());

                    karyawanHarian.Add(new KaryawanHarian() { Nik = Nik, Nama = Nama, JamKerja = Jam, GajiPerjam = Gaji });
                }
                else if (pilih==3)
                {
                    string Nik, Nama;
                    Double Jumlah;
                    Double Komisi;
                    Console.Write("> Masukkan NIK  :");
                    Nik = Console.ReadLine();
                    Console.Write("> Masukkan NAMA :");
                    Nama = Console.ReadLine();
                    Console.Write("> Masukkan Jumlah penjualan :");
                    Jumlah = int.Parse(Console.ReadLine());
                    Console.Write("> Masukkan Komisi :");
                    Komisi = int.Parse(Console.ReadLine());

                    sales.Add(new Sales() { Nik = Nik, Nama = Nama, JumlahPenjualan = Jumlah, Komisi = Komisi });
                }
                    Console.WriteLine("Tekan Enter Untuk Kembali....");
                    Console.ReadKey(true);
                    Console.Clear();
                    goto Menu;
            }
            else if (pilihan==2)
            {
                Console.WriteLine("Data Karyawan : ");
                Console.WriteLine();
                int No = 1;
                foreach (Karyawan karyawan in karyawanTetap)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, <Karyawan Tetap>",
                    No, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    No++;
                }
                foreach (Karyawan karyawan in karyawanHarian)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, <Karyawan Harian>",
                    No, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    No++;
                }
                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, < Sales >",
                    No, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    No++;
                }
                    Console.WriteLine("Tekan Enter Untuk Kembali....");
                    Console.ReadKey(true);
                    Console.Clear();
                    goto Menu;
            }
            else if (pilihan==3)
            {
                Console.WriteLine("Hapus Karyawan : ");
                Console.WriteLine();
                string hapus;
                Console.Write("> Masukkan Nik Yg ingin di hapus : ");
                hapus = Console.ReadLine();
                int i = 0;

                foreach (Karyawan karyawan in karyawanTetap)
                {
                  if (hapus==karyawan.Nik)
                    {
                        karyawanTetap.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in karyawanHarian)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karyawanHarian.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in sales)
                {
                    if (hapus == karyawan.Nik)
                    {
                        sales.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                Console.WriteLine("Data berhasil di hapus ");
                Console.WriteLine("Tekan Enter Untuk Kembali....");
                Console.ReadKey(true);
                Console.Clear();
                goto Menu;
            }
            else
            {
                Console.WriteLine("Terima Kasih ");
            }
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
