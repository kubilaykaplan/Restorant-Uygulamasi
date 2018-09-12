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
    public partial class MasaDetayForm : Form
    {
        public Masa Masa { get; set; }
        public MasaDetayForm()
        {
            InitializeComponent();
        }

        private void MasaDetayForm_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = Masa.Kodu;
            lblTutar.Text = Masa.Tutar.ToString("C2");

            foreach (Urun u in Masa.Urunler)
            {
                listView1.Items.Add(u.ListOlustur());
            }

            cmbUrun.DataSource = Urun.Liste;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)cmbUrun.SelectedItem;
            Masa.Urunler.Add(u);
            listView1.Items.Add(u.ListOlustur());
            lblTutar.Text = Masa.Tutar.ToString("C2");

        }
    }
}
