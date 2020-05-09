using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    class Obat
    {
        private string kodeObat;
        private string namaObat;
        private string expiredDate;

        public string KodeObat { get { return this.kodeObat; } set { this.kodeObat = value; } }
        public string NamaObat { get { return this.namaObat; } set { this.namaObat= value; } }
        public string ExpiredDate { get { return this.expiredDate; } set { this.expiredDate= value; } }

        public Obat(string _kode, string _nama, string _expired)
        {
            this.kodeObat = _kode;
            this.namaObat = _nama;
            this.expiredDate = _expired;
        }
    }
}