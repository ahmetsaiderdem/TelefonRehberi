using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Islemler : Kisiler
    {
        List<Kisiler> KisilerListesi = new List<Kisiler>();
        Kisiler KisilerGetir = new Kisiler();

        public void KisiBilgileriniGetir()
        {
            foreach (Kisiler item in KisilerListesi)
            {
                Console.WriteLine("Kişi Bilgileri");
                Console.WriteLine("Adı   : {0}", item.Ad);
                Console.WriteLine("Soyad   : {0}", item.Soyad);
                Console.WriteLine("Numara   : {0}", item.Numara);
            }
            

        }


        public void Secenek()
        {
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin");
                Console.WriteLine("1.Numara Kayıt");
                Console.WriteLine("2.Kişi bilgilerini göster");
                Console.WriteLine("3.Numara Silme");
                int secenek = Convert.ToInt32(Console.ReadLine());
                if (secenek == 1)
                {
                    NumaraKayıt();

                }
                else if (secenek == 2)
                {

                    KisiBilgileriniGetir();
                }
                else if (secenek==3)
                {
                    NumaraSil();
                }
            }
           
        }
        public void NumaraKayıt()
        {
            Console.Write("Ad girin");

            KisilerGetir.Ad = Console.ReadLine();
            KisilerGetir.Soyad = Console.ReadLine();
            KisilerGetir.Numara = Convert.ToInt32(Console.ReadLine());
            KisilerListesi.Add(KisilerGetir);


        }
        public void NumaraSil()
        {
            Console.WriteLine("Kaçıncı Numarayı silmek istersiniz");
            KisiBilgileriniGetir();
            int secim = Convert.ToInt32(Console.ReadLine());
            KisilerListesi.RemoveAt(secim-1);

            //KisilerListesi.Clear();
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
