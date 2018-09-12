namespace Restorant_Uygulaması
{
    partial class MasaListeForm
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 392);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.Location = new System.Drawing.Point(12, 9);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(79, 18);
            this.lblSalonAdi.TabIndex = 2;
            this.lblSalonAdi.Text = "Salon Adı";
            // 
            // MasaListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalonAdi);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MasaListeForm";
            this.Text = "MasaListeForm";
            this.Load += new System.EventHandler(this.MasaListeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblSalonAdi;
    }
}