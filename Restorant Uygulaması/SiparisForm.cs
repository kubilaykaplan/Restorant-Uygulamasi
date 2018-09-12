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
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            foreach (Salon salon in Salon.Salonlar)
            {
                flowLayoutPanel1.Controls.Add(salon);
                salon.Click += salon_Click;
            }
        }
        void salon_Click(object sender, EventArgs e)
        {
            Salon s = (Salon)sender;
            MasaListeForm msl = new MasaListeForm();
            msl.MdiParent = this.MdiParent;
            msl.Salon = s;
            msl.Show();
        }

        private void SiparisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
