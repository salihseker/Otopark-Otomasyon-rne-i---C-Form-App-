namespace OTOPARK_OTOMASYON
{
    partial class aktif_abone_rapor
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
            this.dgAktifAbone = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAktifAbone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(13, 14);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(84, 24);
            this.btnExceleAktar.TabIndex = 14;
            this.btnExceleAktar.Text = "Excel e Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // dgAktifAbone
            // 
            this.dgAktifAbone.AllowUserToAddRows = false;
            this.dgAktifAbone.AllowUserToDeleteRows = false;
            this.dgAktifAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAktifAbone.Location = new System.Drawing.Point(12, 54);
            this.dgAktifAbone.Name = "dgAktifAbone";
            this.dgAktifAbone.Size = new System.Drawing.Size(720, 366);
            this.dgAktifAbone.TabIndex = 13;
            // 
            // aktif_abone_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 441);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.dgAktifAbone);
            this.Name = "aktif_abone_rapor";
            this.Text = "aktif_abone_rapor";
            this.Load += new System.EventHandler(this.aktif_abone_rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAktifAbone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.DataGridView dgAktifAbone;
    }
}