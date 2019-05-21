using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHocaTekrar
{
    class Kisi
    {
        private string _isim;
        private string _soyİsim;
        private string _tcNo;

        public string Isim
        {
            get
            {
                return _isim;
            }
            set
            {
                _isim = value;
            }
        }
        public string SoyIsim
        {
            get
            {
                return _soyİsim;
            }
            set
            {
                _soyİsim = value;
            }
        }
        public string TcNo
        {
            get
            {
                return _tcNo;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("Tc numarası 11 haneli olmalıdır");
                }
                else if (value[0] == '0')
                {
                    throw new Exception("Tcno nun ilk hanesi sıfır olamaz");
                }
                _tcNo = value;
            }
        }
    }
}
