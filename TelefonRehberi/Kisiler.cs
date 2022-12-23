using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Kisiler
    {
        private string ad;
        private string soyad;
        private int numara;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Numara { get => numara; set => numara = value; }
        public Kisiler(string ad, string soyad, int numara)
        {
            Ad = ad;
            Soyad = soyad;
            Numara = numara;
        }
        public Kisiler()
        {
            if (Ad==null || Soyad==null || Numara==null)
            {
                Console.WriteLine("Eksik Bilgi girdiniz");
            }
        }


    }
}
