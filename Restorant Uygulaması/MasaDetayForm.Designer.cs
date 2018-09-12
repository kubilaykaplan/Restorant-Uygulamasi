namespace Restorant_Uygulaması
{
    partial class MasaDetayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.Location = new System.Drawing.Point(12, 9);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(103, 29);
            this.lblMasaNo.TabIndex = 0;
            this.lblMasaNo.Text = "MasaNo";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(17, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(221, 268);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyatı";
            this.columnHeader2.Width = 62;
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(17, 101);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(140, 21);
            this.cmbUrun.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(163, 101);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTutar);
            this.groupBox1.Location = new System.Drawing.Point(121, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Tutar";
            // 
            // lblTutar
            // 
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(6, 27);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(105, 29);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "0TL";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MasaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblMasaNo);
            this.Name = "MasaDetayForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MasaDetayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTutar;
    }
}