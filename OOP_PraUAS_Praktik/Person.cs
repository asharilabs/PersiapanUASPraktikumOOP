using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    class Person
    {
        private string nama;
        private string alamat;
        private string nohp;

        public string Nama { get { return this.nama; } set { this.nama = value; } }
        public string Alamat { get { return this.alamat; } set { this.alamat = value; } }
        public string NoHP { get { return this.nohp; } set { this.nohp = value; } }
    }
}