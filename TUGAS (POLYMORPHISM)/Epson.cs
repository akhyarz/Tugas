using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism
{
    public class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension is: 10*11 ");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer is now printing. . . .");
        }
    }
}
