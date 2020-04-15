using System;
namespace Responsi
{
    public class Karyawan
    {
        public Karyawan(string name, int no, int nik, int gaji)
        {
            Nik = nik;
            No = no;
            Name = name;
            Gaji = gaji;
        }

        public string Name { get; set; }
        public int Gaji { get; set; }
        public int Nik { get; set; }
        public int No { get; set; }

        public void gaji()
        {
            Console.WriteLine("Karyawan has name : {o} no : {1} nik : {2} gaji {3}", Nama No, Nik, Gaji);
        }
        public void gajinaik()
        {
            Console.WriteLine("Karyawan has name : {o} no : {1} nik : {2} gaji {3}", Nama No, Nik, Gaji + (Gaji * 10 / 100));
        }


    }
}