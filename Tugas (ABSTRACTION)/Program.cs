using System;
using Tugas_ABSTRACTION_;

namespace Tugas__ABSTRACTION_
{
    class Program
    {
        static void Main(string[] args)
        {
          IKata kata = new Kata();
          kata.view();

          Kamus Bahasa;

            Bahasa = new Bahasa_Indonesia();
            Bahasa.Bahasa();
            Console.WriteLine();
            Bahasa = new Bahasa_Inggris();
            Bahasa.Bahasa();
            Console.WriteLine();
            Bahasa = new Bahasa_Belanda();
            Bahasa.Bahasa();
            Console.WriteLine();
            Bahasa = new Bahasa_Spanyol();
            Bahasa.Bahasa();
            Console.WriteLine();
            Bahasa = new Bahasa_Italy();
            Bahasa.Bahasa();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
