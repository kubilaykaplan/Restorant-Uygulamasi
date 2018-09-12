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
    public partial class MasaListeForm : Form
    {
        public MasaListeForm()
        {
            InitializeComponent();
        }
        public Salon Salon { get; set; }

        private void MasaListeForm_Load(object sender, EventArgs e)
        {
            lblSalonAdi.Text = Salon.Adi;
            foreach  (Masa m in Salon.Masalar)
            {
                m.Click += masa_Click;
                flowLayoutPanel2.Controls.Add(m);
            }

        }

        private void masa_Click(object sender, EventArgs e)
        {
            MasaDetayForm mdf = new MasaDetayForm();
            mdf.Masa = (Masa)sender;
            mdf.MdiParent = this.MdiParent;
            mdf.Show();
        }
    }
}
