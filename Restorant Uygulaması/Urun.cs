using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Uygulaması
{
    public class Urun
    {
        public Urun()
        {
             //Liste.Add(this);
                
        }
        public Urun(string adi, decimal fiyat)
        {
            Adi = adi;
            Fiyat = fiyat;
            Liste.Add(this);
        }
        public string Adi;
        public decimal Fiyat;

        public static List<Urun> Liste = new List<Urun>();

        public ListViewItem ListOlustur()
        {
            ListViewItem li = new ListViewItem();
            li.Text = Adi;
            li.SubItems.Add(Fiyat.ToString("C2"));
            return li;
        }
        public override string ToString()
        {
            return this.Adi;
        }
    }
}
