using System;
namespace TugasInheritance
{
    public class Student : Person

    {
        public Student(string nama, int umur, string idsiswa, string email)
        : base(nama, umur)
        {
            StudentId = idsiswa;
            Email = email;
        }

        public string StudentId { get; set; }
        public string Email { get; set; }

    }
}
