using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("LaserJet display dimension is: 12*12");
        }
        public override void print()
        {
            Console.WriteLine("LaserJet is now printing. . . .");
        }
    }
}
