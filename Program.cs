using SIBKMNet.Models;
using System;

namespace SIBKMNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            Console.Write("Masukan Nama Karyawan: ");
            Nama = Console.ReadLine();
            Console.WriteLine("Selamat datang di website fasilitas yang didapat di PT. Dr. Project {0}", Nama);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();


            // impelementasi desicion
            int lamakerja;
            Console.WriteLine("Lama Bekerja: "+"(dalam bulan)");
            lamakerja = int.Parse(Console.ReadLine());
            if (lamakerja >= 3)
            {
                Console.WriteLine("Karyawan Tetap");
            }
            else if (lamakerja <= 3)
            {
                Console.WriteLine("Karyawan Training");
            }
            else
            {
                Console.WriteLine("Bukan Karyawan");
            }

            KaryawanTetap karyawan = new KaryawanTetap(1, "Yunia", 3, false);
            karyawan.Kuota();
            karyawan.UangMakan();
            //karyawan.Work("Karyawan Tetap");
            karyawan.Living("rumah", "mess");
            karyawan.Salary ("Karyawan Tetap");

            for (; ; )
            {
                Console.Write("Apakah anda ingin melanjutkan? [Ya/Tidak] : ");
                string pilihan = Console.ReadLine();

                if (pilihan.ToLower() == "ya") continue;
                Console.Write(pilihan);
                if (pilihan.ToLower() == "tidak");
                {
                    break;
                }
            }

        }
    }
}
