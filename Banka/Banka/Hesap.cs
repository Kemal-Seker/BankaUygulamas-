using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHocaTekrar
{
    class Hesap
    {
        private string _hesapNo;
        private decimal _bakiye;
        public Kisi kisi = new Kisi();

        public string HesapNo
        {
            get
            {
                return _hesapNo;
            }
            set
            {
                if (value.Length != 6)
                {
                    throw new Exception("Hesap numarası 6 haneli olmalıdır");
                }
                _hesapNo = value;
            }
        }
        public decimal Bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Bakiye degeri negatif olamaz");
                }
                _bakiye = value;
            }
        }
        public Hesap()
        {

        }
        public Hesap(string isim,string soyisim,string tcno,string hesapno,decimal bakiye )
        {
            this.kisi.Isim = isim;
            this.kisi.SoyIsim = soyisim;
            this.kisi.TcNo = tcno;
            this._hesapNo = hesapno;
            this._bakiye = bakiye;
        }
        public Hesap(string yeniKisi)
        {
            string[] gecici = yeniKisi.Split(',');
            this.kisi.Isim = gecici[0];
            this.kisi.SoyIsim = gecici[1];
            this.kisi.TcNo = gecici[2];
            this._hesapNo = gecici[3];
            this._bakiye = Convert.ToDecimal(gecici[4]);
        }
    }
}

