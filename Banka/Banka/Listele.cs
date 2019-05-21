using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHocaTekrar
{
    class Listele
    {
        public void HesapYazma(Hesap hesap)
        {
            string hesapstring = string.Format("{0},{1},{2},{3},{4}", hesap.kisi.Isim, hesap.kisi.SoyIsim, hesap.kisi.TcNo, hesap.HesapNo, hesap.Bakiye);
            File.AppendAllText(@"C:\Users\Kemal\Desktop\PROJELER\Banka\HesapListe.txt", hesapstring + Environment.NewLine);
        }
        public Hesap[] HesapOkuma(Hesap[] hesaplar)
        {
            string[] butunkisiler = File.ReadAllLines(@"F:\07.02.2019\BankaHocaTekrar\HesapListe.txt");
            for (int i = 0; i < butunkisiler.Length; i++)
            {
                Array.Resize(ref hesaplar, hesaplar.Length + 1);
                hesaplar[i] = new Hesap(butunkisiler[i]);          
            }
            return hesaplar;
        }
    }
}

