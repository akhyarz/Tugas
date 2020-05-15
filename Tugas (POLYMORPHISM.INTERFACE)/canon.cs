using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism2
{
    public class Canon : Iinterface
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension is : 9.5*12");
        }

        public void Print()
        {
            Console.WriteLine("*Canon printer is now printing. . . .");
        }
    }
}