using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Uygulaması
{
    public class Masa:Button
    {
        public Masa()
        {
            this.Width = 70;
            this.Height = 70;
        }
        private string _Kodu;
        public string Kodu
        {
            get { return _Kodu; }
            set { _Kodu =this.Text= value; }
        }
        private string _MusteriAdi;
        public string MusteriAdi
        { get { return _MusteriAdi; }
            set
            {
                if (value.Length < 0)
                    throw new Exception("İsim 3 harften küçük olamaz!");
                _MusteriAdi = value;
            }
        }
        private string _MusteriTelefonu;
        public string MusteriTelefonu
        {
            get { return _MusteriTelefonu; }
            set
            {
                if (value.Length < 7 && value.Length > 0)
                    throw new Exception("Telefon numarasını hatalı girdiniz.");
                _MusteriTelefonu = value;
            }
        }

        public bool Rezerve = false;
        public bool Dolu = false;
        List<Urun> _Urunler = new List<Urun>();
        public List<Urun> Urunler { get => _Urunler; set => _Urunler = value; }


        public decimal Tutar
        {
            get
            {
                decimal s = 0;
                foreach (Urun u in Urunler)
                {
                    s += u.Fiyat;
                }
                return s;
            }
            
 
        }


    }
}
