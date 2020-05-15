using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism2
{
    public class LaserJet : Iinterface
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension is : 12*12");
        }

        public void Print()
        {
            Console.WriteLine("*LaserJet printer is now printing. . . .");
        }
    }
}