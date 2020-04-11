using System;
namespace TugasInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person orang = new Person("Leon", 28);
            orang.GetNameAndAge();

            Teacher guru = new Teacher("Dhanny", 34, "2881", "Math");
            guru.GetNameAndAge();

            Student siswa = new Student("Ahyar", 19, "2898", "Ahyar@gmail.com");
            siswa.GetNameAndAge();
        }
    }
}
