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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Salon s = new Salon(txtAdi.Text, (int)numMasaSayisi.Value, txtOnEk.Text);

            Salon.Salonlar.Add(s);
            listView1.Items.Add(s.ListOlustur());
        }
    }
}
