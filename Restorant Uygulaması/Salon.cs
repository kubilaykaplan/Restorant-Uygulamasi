using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Uygulaması
{
    public class Salon:Button
    {
        public Salon(string adi, int masaSayisi, string masaOnek)
        {
            this.Adi = adi;
            OnEk = masaOnek;
            for (int i = 1; i <= masaSayisi; i++)
            {
                Masa m = new Masa();
                m.Kodu = string.Format("{0}-{1}", masaOnek, i);
                this.Masalar.Add(m);
            }
            this.Text = adi;
            this.Width = 100;
            this.Height = 100;
        }
        public string Adi { get; set; }
        public string OnEk { get; set; }
        private static List<Salon> _Salonlar = new List<Salon>();
        public static List<Salon> Salonlar { get => _Salonlar; set => _Salonlar = value; }
        private List<Masa> _Masalar = new List<Masa>();
        public List<Masa> Masalar { get => _Masalar; set => _Masalar = value; }

        public ListViewItem ListOlustur()
        {
            ListViewItem li = new ListViewItem();
            li.Text = Adi;
            li.SubItems.Add(Masalar.Count.ToString());
            li.SubItems.Add(OnEk);
            return li;
        }


    }
}
