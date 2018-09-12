using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Uygulaması
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Urun u = new Urun(txtAdi.Text, txtFiyat.Value);

            //Urun.Liste.Add(u);

            lstUrun.Items.Add(u.ListOlustur());
        }
    }
}
