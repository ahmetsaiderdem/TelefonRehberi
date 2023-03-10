using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Islemler : Kisiler
    {
       // Dictionary<int, Kisiler> KisilerListesi = new Dictionary<int, Kisiler>();
        List<Kisiler> KisilerListesi = new List<Kisiler>();
        
        
        public void KisiBilgileriniGetir()
        {
            
            foreach (var item in KisilerListesi)
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
                Console.WriteLine("4.Kişi Arama");
                int secenek = Convert.ToInt32(Console.ReadLine());
                if (secenek == 1)
                {
                    NumaraKayıt();

                }
                else if (secenek == 2)
                {

                    KisiBilgileriniGetir();
                }
                else if (secenek == 3)
                {
                    NumaraSil();
                }
                else if (secenek == 4)
                {
                    Arama();
                }
            }
      
        }
        public void NumaraKayıt()
        {
            Kisiler Kisi = new Kisiler();
            Console.Write("Ad girin");
            Kisi.Ad = Console.ReadLine();
            Kisi.Soyad = Console.ReadLine();
            Kisi.Numara = Console.ReadLine();

            KisilerListesi.Add(Kisi);
            
            
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
            Console.WriteLine("Aramak istediğiniz kişinin adını yazınız");
            string ara = Console.ReadLine();
            foreach (var item in KisilerListesi)
            {
                if (item.Ad.Contains(ara))
                {
                    Console.WriteLine(item.Numara);
                }
                
            }

        }
    }
}
