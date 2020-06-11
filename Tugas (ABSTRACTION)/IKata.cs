using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas__ABSTRACTION_
{
    public interface IKata
    {
        void view();
    }

    class Kata : IKata
    {
        public void view()
        {
            Console.WriteLine("*Berikut contoh kalimat Dalam berbagai bahasa ");
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine();
        }
    }
}
