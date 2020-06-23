using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 - Polymorphsim, Inheritance, Abstraction & Collection Bagian 2";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "12312312";
            karyawanTetap.Nama = "Tinezai Ayu";
            karyawanTetap.GajiBulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "32132132";
            karyawanHarian.Nama = "Mardha Nouval";
            karyawanHarian.JumlahJamKerja = 15;
            karyawanHarian.UpahPerJam = 250000;

            Sales sales = new Sales();
            sales.Nik = "10201201";
            sales.Nama = "Afney Tira";
            sales.JumlahPenjualan = 42;
            sales.Komisi = 40000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}