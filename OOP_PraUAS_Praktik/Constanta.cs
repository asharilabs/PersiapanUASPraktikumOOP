using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_PraUAS_Praktik
{
    class Constanta
    {
        public static void Cover()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("SELAMAT DATANG DI APLIKASI INI");
            Console.WriteLine("------------------------------");
        }

        public static void TampilDataApoteker(List<Apoteker> apotekers)
        {
            Console.WriteLine("Daftar Apoteker");
            for (int i = 0; i < apotekers.Count; i++)
            {
                Console.WriteLine("Apoteker #" + (i + 1));
                Console.WriteLine("Nama: " + apotekers[i].Nama);
                Console.WriteLine("Alamat: " + apotekers[i].Alamat);
                Console.WriteLine("NoHP: " + apotekers[i].NoHP);
                Console.WriteLine("kode Karyawan: " + apotekers[i].KodeKaryawan);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Environment.NewLine);
        }
        public static void TampilDataObat(List<Obat> obats)
        {
            Console.WriteLine("Daftar Obat");
            for (int i = 0; i < obats.Count; i++)
            {
                Console.WriteLine("Obat #" + (i + 1));
                Console.WriteLine("Kode: " + obats[i].KodeObat);
                Console.WriteLine("Nama: " + obats[i].NamaObat);
                Console.WriteLine("Expired: " + obats[i].ExpiredDate);                
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Environment.NewLine);
        }
        public static void TampilDataPasien(List<Pasien> pasiens)
        {
            Console.WriteLine("Daftar Pasien");
            for (int i = 0; i < pasiens.Count; i++)
            {
                Console.WriteLine("Pasien #" + (i + 1));
                Console.WriteLine("Nama: " + pasiens[i].Nama);
                Console.WriteLine("Alamat: " + pasiens[i].Alamat);
                Console.WriteLine("NoHP: " + pasiens[i].NoHP);
                Console.WriteLine("kode Berobat: " + pasiens[i].KodeBerobat);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
