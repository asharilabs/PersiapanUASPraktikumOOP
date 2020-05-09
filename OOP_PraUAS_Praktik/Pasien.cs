using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    // Pasien di inherit dari class Person
    class Pasien : Person
    {
        private string kodeBerobat;
        private Pembelian pembelian;

        public string KodeBerobat { get { return this.kodeBerobat; } set { this.kodeBerobat = value; } }
        public Pembelian _Pembelian { get { return this.pembelian; } set { this.pembelian = value; } }

        public Pasien(string _nama, string _alamat, string _noHP, string _kodeBerobat)
        {
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.NoHP = _noHP;
            this.kodeBerobat = _kodeBerobat;
        }

        // fungsi untuk membeli obat
        public void MembeliObat(Pembelian _pembelian)
        {
            this.pembelian = _pembelian;
        }

        public void TampilkanInformasi()
        {
            Console.WriteLine("informasi pasien");
            Console.WriteLine("nama: " + this.Nama);
            Console.WriteLine("alamat: " + this.Alamat);
            Console.WriteLine("noHP: " + this.NoHP);
            Console.WriteLine("kodeberobat: " + this.kodeBerobat);
            Console.WriteLine("PEMBELIAN");
            Console.WriteLine("tgl: " + this.pembelian.Tanggal);
            Console.WriteLine("tgl: " + this.pembelian.NoFaktur);
            Console.WriteLine("tgl: " + this.pembelian.Apoteker.Nama);
            Console.WriteLine("DAFTAR OBAT YANG DIBELI");
            for (int i = 0; i < this.pembelian.DaftarObat.Count; i++)
            {
                Console.WriteLine("nama: " + this.pembelian.DaftarObat[i].NamaObat);
            }
        }
    }
}