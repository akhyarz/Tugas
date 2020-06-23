using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas__collection_
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double UpahPerjam { get; set;}
        public double JumlahJamKerja { get; set;}
        public override double Gaji()
        {
            return UpahPerjam*JumlahJamKerja;
        }
    }
}
