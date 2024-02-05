using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Buku objbuku = new Buku("Senja", "Hani", "PT Langit Biru", 2023);

            //memberi nilai property
            // objbuku.Judul      = "Senja";
            // objbuku.Pengarang  = "Hani";
            // objbuku.Penerbit   = "PT Langit Biru";
            // objbuku.TahunTerbit= 2023;

            //mengambil nilai dengan property
            Console.WriteLine("Judul        : {0}", objbuku.Judul);
            Console.WriteLine("Pengarang    : {0}", objbuku.Pengarang);
            Console.WriteLine("Penerbit     : {0}", objbuku.Penerbit);
            Console.WriteLine("Tahun Terbit : {0}", objbuku.TahunTerbit.ToString());

            Console.ReadKey();
        }
    }
}
