using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism
{
    class Program
    {
       static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("========MENU========");
            Console.WriteLine("Pilih printer : ");
            Console.WriteLine("1.Epson ");
            Console.WriteLine("2.Cannon");
            Console.WriteLine("3.LaserJet");
            Console.WriteLine("=====================");
            Console.WriteLine("No. Printer [1][2][3]");
            int NoPrint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            if (NoPrint == 1)
                printer = new Epson();
            else if (NoPrint == 2)
                printer = new Cannon();
            else
                printer = new LaserJet();


            printer.show();
            printer.print();
            Console.ReadKey();
        }
    }
}