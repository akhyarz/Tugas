using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
		float a, b;
        int pilihan;

        Console.WriteLine("Pilih menu kalkulator:");

        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.WriteLine("silahkan Inputkan nomor menu[1..4]:");
        pilihan = int.Parse(Console.ReadLine());
		
		if (pilihan == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("hasil penjumlahan {0}+{1} = {2} ",a ,b ,  penjumlahan(a, b));
            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("hasil pengurangan {0}-{1}={2}", a, b, pengurangan(a, b));
            }

            else if (pilihan == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("hasil perkalian {0}*{1}={2}", a, b, perkalian(a, b));
            }

            else if (pilihan == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("hasil pembagian {0}/{1}={2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
        }

        static float penjumlahan (float a, float b)
        {
            return a + b;
        }

        static float pengurangan (float a, float b)
        {
            return a - b;
        }

        static float perkalian (float a, float b)
        {
            return a * b;
        }

        static float pembagian (float a, float b)
        {
            return a / b;
        }        
    }
}