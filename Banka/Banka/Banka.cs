using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHocaTekrar
{
    class Banka
    {
        
        public Hesap[] KisiEkle(Hesap[] hesaplar,Hesap hesap)
        {
            Array.Resize(ref hesaplar, hesaplar.Length +1 );
            hesaplar[hesaplar.Length-1] =hesap ;
            Listele liste = new Listele();
            liste.HesapYazma(hesap);
            return hesaplar;
        }
        public string[] KisiListele(Hesap [] hesaplar)
        {
            string[] yenidizi = new string[hesaplar.Length];
            for (int i = 0; i < hesaplar.Length; i++)
            {
                yenidizi[i]=string.Format("{0} {1} {2} {3} {4}",i+1, hesaplar[i].kisi.Isim, hesaplar[i].kisi.SoyIsim, hesaplar[i].HesapNo, hesaplar[i].Bakiye);
            }
            return yenidizi;
        }
        public void ParaYatır(Hesap[] hesaplar,int secım,decimal deger)
        {
            hesaplar[secım].Bakiye = hesaplar[secım].Bakiye + deger;
        }
        public void Havale(Hesap[] hesaplar,int kısı1,int kısı2,decimal deger)
        {
            hesaplar[kısı1].Bakiye = hesaplar[kısı1].Bakiye - deger;
            hesaplar[kısı2].Bakiye = hesaplar[kısı2].Bakiye + deger;
        }
    }
}
