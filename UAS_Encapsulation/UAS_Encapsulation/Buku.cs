using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Encapsulation
{
    class Buku
    {
        // private variables atau field
        private string judul;
        private string pengarang;
        private string penerbit;
        private int tahunTerbit;

        // property
        public string Judul
        {
            get { return judul; }
            set { judul = value; }
        }
        public string Pengarang
        {
            get { return pengarang; }
            set { pengarang = value; }
        }
        public string Penerbit
        {
            get { return penerbit; }
            set { penerbit = value; }
        }
        public int TahunTerbit
        {
            get { return tahunTerbit; }
            set { tahunTerbit = value; }
        }

        // constructor
        // public Buku()
        // {
        //     judul = "Senja";
        //     pengarang = "Hani";
        //     penerbit = "PT Langit Biru";
        //     tahunTerbit = 2023;
        // }

        // overload constructor
        public Buku(string judul, string pengarang, string penerbit, int tahunTerbit)
        {
            this.judul = judul;
            this.pengarang = pengarang;
            this.penerbit = penerbit;
            this.tahunTerbit = tahunTerbit;
        }
    }
}
