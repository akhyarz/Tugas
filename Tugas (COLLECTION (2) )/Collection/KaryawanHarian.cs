using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class KaryawanHarian: Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double GajiPerjam { get; set; }
        public double JamKerja { get; set; }
        public override double Gaji()
        {
            return JamKerja * GajiPerjam;
        }
    }
}
