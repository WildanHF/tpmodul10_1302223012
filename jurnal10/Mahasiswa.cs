﻿namespace jurnal10
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string Nama, string NIM)
        {
            this.Nama = Nama;
            this.NIM = NIM;
        }
    }
}