using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjectPenjualan
{
    public abstract class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public abstract Double Nota();
        public abstract string Costumer { get; set; }
        public abstract string Tanggal { get; set; }
        public abstract char Jenis { get; set; }
        public abstract Double Total();
    }
}
