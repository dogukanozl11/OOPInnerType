using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "25363351132";
            M1.isim = "Doğukan";
            M1.soyisim = "ÖZEL";
            M1.olusturmaTarih=DateTime.Now;

            //M1.musteriAdresleri = new MusteriAdres[5];
            //Asla Yapma

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "K.Çekmece",
                Adres = "Adresss..",
                adresTip = "İş Yeri"
            };
            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP001",
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunId = 1,
                Tanim = "Telefon",
                fiyat = 1500

            };



        }
    }
}
