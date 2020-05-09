using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    // Apoteker di inherit dari class Person
    class Apoteker : Person
    {
        private string kodeKaryawan;
        public string KodeKaryawan { get { return this.kodeKaryawan; } set { this.kodeKaryawan = value; } }

        public Apoteker(string _nama, string _alamat, string _noHP, string _kodeKaryawan)
        {
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.NoHP = _noHP;
            this.kodeKaryawan = _kodeKaryawan;
        }
    }
}