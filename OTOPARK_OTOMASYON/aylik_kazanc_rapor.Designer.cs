namespace OTOPARK_OTOMASYON
{
    partial class aylik_kazanc_rapor
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
            this.dgKazancRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKazancRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(12, 12);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(84, 24);
            this.btnExceleAktar.TabIndex = 16;
            this.btnExceleAktar.Text = "Excel e Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // dgKazancRapor
            // 
            this.dgKazancRapor.AllowUserToAddRows = false;
            this.dgKazancRapor.AllowUserToDeleteRows = false;
            this.dgKazancRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKazancRapor.Location = new System.Drawing.Point(11, 52);
            this.dgKazancRapor.Name = "dgKazancRapor";
            this.dgKazancRapor.Size = new System.Drawing.Size(720, 366);
            this.dgKazancRapor.TabIndex = 15;
            // 
            // aylik_kazanc_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 430);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.dgKazancRapor);
            this.Name = "aylik_kazanc_rapor";
            this.Text = "aylik_kazanc_rapor";
            this.Load += new System.EventHandler(this.aylik_kazanc_rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKazancRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.DataGridView dgKazancRapor;
    }
}