using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHocaTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bitti = false;
            Hesap[] hesaplar = new Hesap[0];
            Banka banka = new Banka();
            Listele listele = new Listele();
            do
            {
                int secim = Menu();
                switch (secim)
                {
                    case 1:
                        Hesap hesapNo = new Hesap();
                        hesapNo = YeniHesap();
                        hesaplar = banka.KisiEkle(hesaplar, hesapNo);
                        break;
                    case 2:
                        string[] dizigoster = banka.KisiListele(hesaplar);
                        for (int i = 0; i < hesaplar.Length; i++)
                        {
                            Console.WriteLine(dizigoster[i]);
                        }
                        break;
                    case 3:
                        int kısısec = KısıSec(hesaplar, "para yatırılacak kısıyı secın");
                        decimal tutar = ParaYatır();
                        banka.ParaYatır(hesaplar, kısısec, tutar);
                        break;
                    case 4:
                        int kısısec1 = KısıSec(hesaplar, "para gonderen kısıyı secın");
                        int kısısec2 = KısıSec(hesaplar, "gonderılecek hesabı secın");
                        decimal tutar2 = ParaYatır();
                        banka.Havale(hesaplar, kısısec1, kısısec2, tutar2);
                        break;
                    case 5:
                        bitti = true;
                        break;
                }
            } while (bitti == false);         
        }
        static int Menu()
        {
            int secim;
            Console.WriteLine("1 - Kişi ekle");
            Console.WriteLine("2 - Kişi listeleme");
            Console.WriteLine("3 - Para yatır");
            Console.WriteLine("4 - Havale yap");
            Console.WriteLine("5 - Çıkış");
            secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
        static Hesap YeniHesap()
        {
            Hesap yenihesap = new Hesap();
            Console.Write("İsim: ");
            yenihesap.kisi.Isim = Console.ReadLine();
            Console.Write("Soyisim: ");
            yenihesap.kisi.SoyIsim = Console.ReadLine();
            Console.Write("TcNo: ");
            yenihesap.kisi.TcNo = Console.ReadLine();
            Console.Write("HesapNo: ");
            yenihesap.HesapNo = Console.ReadLine();
            Console.Write("Bakiye: ");
            yenihesap.Bakiye = Convert.ToDecimal(Console.ReadLine());
            return yenihesap;
        }
        static int KısıSec(Hesap[] hesaplar,string mesaj)
        {
            string[] yenidizi = new string[hesaplar.Length];
            for (int i = 0; i < hesaplar.Length; i++)
            {
                yenidizi[i] = string.Format("{0} {1} {2} {3} {4}", i + 1, hesaplar[i].kisi.Isim, hesaplar[i].kisi.SoyIsim, hesaplar[i].HesapNo, hesaplar[i].Bakiye);
                Console.WriteLine(yenidizi[i]);
            }
            Console.Write(mesaj);
            int yenisecim = Convert.ToInt32(Console.ReadLine());
            return yenisecim -1;
        }
        static decimal ParaYatır()
        {
            Console.Write("Miktar giriniz: ");
            decimal deger = Convert.ToDecimal(Console.ReadLine());
            return deger;
        }
    }
}
