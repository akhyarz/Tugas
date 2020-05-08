using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism
{
    public class Cannon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Cannon display dimension is: 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Cannon printer is now printing. . . . ");
        }
    }
}
