using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Islemler:Kisiler
    {
        public void KisiBilgileriniGetir()
        {
            Console.WriteLine("Kişi Bilgileri");
            Console.WriteLine("Adı   : {0}", this.Ad);
            Console.WriteLine("Soyad   : {0}", this.Soyad);
            Console.WriteLine("Numara   : {0}", this.Numara);
        }

        public void NumaraKayıt()
        {
            List<Kisiler> KisilerListesi = new List<Kisiler>();
            Kisiler KisilerN = new Kisiler();
            KisilerN.Ad = Console.ReadLine();
            KisilerN.Soyad = Console.ReadLine();
            KisilerN.Numara = Convert.ToInt32(Console.ReadLine());
            KisilerListesi.Add(KisilerN);
        }
        public void NumaraSil() 
        {

        }
        public void NumaraGüncelle()
        {

        }
        public void Listeleme()
        {

        }
        public void Arama()
        {


        }

    }
}
