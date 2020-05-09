using System;
using System.Collections.Generic;

namespace OOP_PraUAS_Praktik
{
    class Program
    {
        static void Main(string[] args)
        {
            // pengisian data - inisialisasi data OBAT, APOTEKER, PASIEN
            // by user
            // 1. OBAT, buat 4 macam obat
            List<Obat> daftarObat = new List<Obat>();
            Console.WriteLine("Pengisian Daftar Obat");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("#." + (i + 1));
                Console.Write("kode: "); string _kode = Console.ReadLine();
                Console.Write("nama: "); string _nama = Console.ReadLine();
                Console.Write("expired: "); string _exp = Console.ReadLine();

                // create obat, dan masukkan ke list
                // 1. create
                Obat obat = new Obat(_kode, _nama, _exp);
                // 2. masukkan ke LIST
                daftarObat.Add(obat);
            }
            Console.WriteLine("------------------------------AKHIR PENGISIAN OBAT");
            // 2. APOTEKER, buat 2 apoteker
            Console.WriteLine("Pengisian Daftar Apoteker");
            List<Apoteker> daftarApoteker = new List<Apoteker>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("#." + (i + 1));
                Console.Write("nama: "); string _nama = Console.ReadLine();
                Console.Write("alamat: "); string _alamat = Console.ReadLine();
                Console.Write("noHP: "); string _noHP = Console.ReadLine();
                Console.Write("kodeKaryawan: "); string _kode = Console.ReadLine();
                // create apoteker, dan masukkan ke list
                // 1. create
                Apoteker apoteker = new Apoteker(_nama, _alamat, _noHP, _kode);
                // 2. masukkan ke LIST
                daftarApoteker.Add(apoteker);
            }
            Console.WriteLine("------------------------------AKHIR PENGISIAN APOTEKER");
            // 3. PASIEN, buat 3 pasien
            Console.WriteLine("Pengisian Daftar Pasien");
            List<Pasien> daftarPasien = new List<Pasien>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("#." + (i + 1));
                Console.Write("nama: "); string _nama = Console.ReadLine();
                Console.Write("alamat: "); string _alamat = Console.ReadLine();
                Console.Write("noHP: "); string _noHP = Console.ReadLine();
                Console.Write("kode Berobat: "); string _kode = Console.ReadLine();
                // create apoteker, dan masukkan ke list
                // 1. create
                Pasien pasien = new Pasien(_nama, _alamat, _noHP, _kode);
                // 2. masukkan ke LIST
                daftarPasien.Add(pasien);
            }

            Constanta.Cover();
            Console.WriteLine("selamat datang di aplikasi kami, pilih menu");
            Console.WriteLine("1. Membeli Obat");
            Console.WriteLine("2. Ganti Nama");
            Console.Write("pilih(1/2): "); string _pilih = Console.ReadLine();

            if( _pilih == "1")
            {
                Constanta.TampilDataObat(daftarObat);
                Constanta.TampilDataApoteker(daftarApoteker);
                Constanta.TampilDataPasien(daftarPasien);

                Console.Write("pilih nomor urut obat: ");
                string _pilihObat = Console.ReadLine();
                Console.Write("pilih nomor urut apoteker: ");
                string _pilihApoteker = Console.ReadLine();
                Console.Write("pilih nomor urut pasien: ");
                string _pilihPasien = Console.ReadLine();

                // pembelian obat
                List<Obat> daftarBeliObat = new List<Obat>();
                Obat obatPilihanUser = daftarObat[int.Parse(_pilihObat) - 1];      //2 ---> daftarObat[1]
                daftarBeliObat.Add(obatPilihanUser);

                // pemilihan apoteker
                Apoteker apotekerPilihanUser = daftarApoteker[int.Parse(_pilihApoteker) - 1];

                // pemilihan pasien
                Pasien pasien = daftarPasien[int.Parse(_pilihPasien) - 1];

                // objek PembelianObat
                Pembelian pembelian = new Pembelian(DateTime.Now.ToString(), "nofak 11", daftarBeliObat, apotekerPilihanUser);

                // masukin ke pasien
                pasien._Pembelian = pembelian;

                // tampilin informasi hasil pembelian obat
                pasien.TampilkanInformasi();
            }
            else if( _pilih == "2")
            {

            }
            else
            {
                Console.WriteLine("pilihan tidak ada di list");
            }

            Console.ReadKey();
        }
    }
}