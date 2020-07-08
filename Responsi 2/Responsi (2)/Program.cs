using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.WriteLine("========Menu=========");
            Console.WriteLine("1.Tambahkan Penjualan");
            Console.WriteLine("2.Hapus Penjualan    ");
            Console.WriteLine("3.Tampil Penjualan   ");
            Console.WriteLine("4.Keluar             ");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Double Nota;
            string Costumer, Tanggal, Jenis;
            Double Total;
            
            Console.WriteLine("Silahkan masukkan data....");
            Console.Write("Nota      :  "       );
            Nota = int.Parse(Console.ReadLine());
            Console.Write("Tanggal   :  "       );
            Tanggal = Console.ReadLine();
            Console.Write("Costumer  :  "       );
            Costumer = Console.ReadLine();
            Console.Write("Jenis[T/K]:  "       );
            Jenis = Console.ReadLine();
            Console.Write("Total Nota:  "       );
            Total = int.Parse(Console.ReadLine());
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.WriteLine("Data Penjualan ");
            Console.WriteLine();
            int No= 1;

            foreach(Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                No,penjualan.Tanggal,penjualan.Costumer,penjualan.Jenis,penjualan.Total()) ;
            }
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
