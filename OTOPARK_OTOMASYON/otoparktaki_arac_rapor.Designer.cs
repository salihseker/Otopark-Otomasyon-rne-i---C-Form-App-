namespace OTOPARK_OTOMASYON
{
    partial class otoparktaki_arac_rapor
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
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.dgOtoparktakiAraclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtoparktakiAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(13, 11);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(84, 24);
            this.btnExceleAktar.TabIndex = 12;
            this.btnExceleAktar.Text = "Excel e Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // dgOtoparktakiAraclar
            // 
            this.dgOtoparktakiAraclar.AllowUserToAddRows = false;
            this.dgOtoparktakiAraclar.AllowUserToDeleteRows = false;
            this.dgOtoparktakiAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtoparktakiAraclar.Location = new System.Drawing.Point(12, 51);
            this.dgOtoparktakiAraclar.Name = "dgOtoparktakiAraclar";
            this.dgOtoparktakiAraclar.Size = new System.Drawing.Size(720, 366);
            this.dgOtoparktakiAraclar.TabIndex = 10;
            // 
            // otoparktaki_arac_raporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 455);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.dgOtoparktakiAraclar);
            this.Name = "otoparktaki_arac_raporu";
            this.Text = "otoparktaki_arac_raporu";
            this.Load += new System.EventHandler(this.otoparktaki_arac_raporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOtoparktakiAraclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.DataGridView dgOtoparktakiAraclar;
    }
}