using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    class Pembelian
    {
        private string tgl;
        private string noFaktur;
        private List<Obat> daftarObat;
        private Apoteker apoteker;

        public string Tanggal { get { return this.tgl; } set { this.tgl = value; } }
        public string NoFaktur { get { return this.noFaktur; } set { this.noFaktur = value; } }
        public List<Obat> DaftarObat { get { return this.daftarObat; } set { this.daftarObat = value; } }
        public Apoteker Apoteker { get { return this.apoteker; } set { this.apoteker = value; } }

        public Pembelian(string _tgl, string _noFaktur, List<Obat> obat, Apoteker _apoteker)
        {
            this.tgl = _tgl;
            this.noFaktur = _noFaktur;
            this.daftarObat = obat;
            this.apoteker = _apoteker;
        }
    }
}