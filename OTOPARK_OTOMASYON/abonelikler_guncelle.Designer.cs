namespace OTOPARK_OTOMASYON
{
    partial class abonelikler_guncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAboneId = new System.Windows.Forms.Label();
            this.txtAboneAdSoyad = new System.Windows.Forms.TextBox();
            this.dpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAboneUcreti = new System.Windows.Forms.TextBox();
            this.dgAbonelikler = new System.Windows.Forms.DataGridView();
            this.btnAboneAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAbonelikId = new System.Windows.Forms.Label();
            this.txtKayitTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonelikler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Abone Ücreti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kayıt Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Abone Id : ";
            // 
            // lblAboneId
            // 
            this.lblAboneId.AutoSize = true;
            this.lblAboneId.Location = new System.Drawing.Point(493, 45);
            this.lblAboneId.Name = "lblAboneId";
            this.lblAboneId.Size = new System.Drawing.Size(0, 13);
            this.lblAboneId.TabIndex = 2;
            // 
            // txtAboneAdSoyad
            // 
            this.txtAboneAdSoyad.Location = new System.Drawing.Point(150, 42);
            this.txtAboneAdSoyad.Name = "txtAboneAdSoyad";
            this.txtAboneAdSoyad.ReadOnly = true;
            this.txtAboneAdSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtAboneAdSoyad.TabIndex = 3;
            // 
            // dpBaslangicTarihi
            // 
            this.dpBaslangicTarihi.Location = new System.Drawing.Point(150, 73);
            this.dpBaslangicTarihi.Name = "dpBaslangicTarihi";
            this.dpBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dpBaslangicTarihi.TabIndex = 4;
            // 
            // dpBitisTarihi
            // 
            this.dpBitisTarihi.Location = new System.Drawing.Point(150, 98);
            this.dpBitisTarihi.Name = "dpBitisTarihi";
            this.dpBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dpBitisTarihi.TabIndex = 4;
            // 
            // txtAboneUcreti
            // 
            this.txtAboneUcreti.Location = new System.Drawing.Point(150, 126);
            this.txtAboneUcreti.Name = "txtAboneUcreti";
            this.txtAboneUcreti.Size = new System.Drawing.Size(72, 20);
            this.txtAboneUcreti.TabIndex = 3;
            // 
            // dgAbonelikler
            // 
            this.dgAbonelikler.AllowUserToAddRows = false;
            this.dgAbonelikler.AllowUserToDeleteRows = false;
            this.dgAbonelikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonelikler.Location = new System.Drawing.Point(38, 200);
            this.dgAbonelikler.Name = "dgAbonelikler";
            this.dgAbonelikler.Size = new System.Drawing.Size(721, 184);
            this.dgAbonelikler.TabIndex = 5;
            this.dgAbonelikler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbonelikler_CellClick);
            // 
            // btnAboneAra
            // 
            this.btnAboneAra.Location = new System.Drawing.Point(326, 40);
            this.btnAboneAra.Name = "btnAboneAra";
            this.btnAboneAra.Size = new System.Drawing.Size(41, 22);
            this.btnAboneAra.TabIndex = 6;
            this.btnAboneAra.Text = "Ara";
            this.btnAboneAra.UseVisualStyleBackColor = true;
            this.btnAboneAra.Click += new System.EventHandler(this.btnAboneAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(665, 99);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 70);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(518, 100);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 70);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(380, 99);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 70);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Abonelik Id : ";
            // 
            // lblAbonelikId
            // 
            this.lblAbonelikId.AutoSize = true;
            this.lblAbonelikId.Location = new System.Drawing.Point(690, 42);
            this.lblAbonelikId.Name = "lblAbonelikId";
            this.lblAbonelikId.Size = new System.Drawing.Size(0, 13);
            this.lblAbonelikId.TabIndex = 13;
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.AutoSize = true;
            this.txtKayitTarihi.Location = new System.Drawing.Point(147, 158);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.Size = new System.Drawing.Size(0, 13);
            this.txtKayitTarihi.TabIndex = 14;
            // 
            // abonelikler_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 412);
            this.Controls.Add(this.txtKayitTarihi);
            this.Controls.Add(this.lblAbonelikId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAboneAra);
            this.Controls.Add(this.dgAbonelikler);
            this.Controls.Add(this.dpBitisTarihi);
            this.Controls.Add(this.dpBaslangicTarihi);
            this.Controls.Add(this.txtAboneUcreti);
            this.Controls.Add(this.txtAboneAdSoyad);
            this.Controls.Add(this.lblAboneId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "abonelikler_guncelle";
            this.Text = "abonelikler_guncelle";
            this.Load += new System.EventHandler(this.abonelikler_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonelikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dpBitisTarihi;
        private System.Windows.Forms.TextBox txtAboneUcreti;
        private System.Windows.Forms.DataGridView dgAbonelikler;
        private System.Windows.Forms.Button btnAboneAra;
        public System.Windows.Forms.Label lblAboneId;
        public System.Windows.Forms.TextBox txtAboneAdSoyad;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAbonelikId;
        private System.Windows.Forms.Label txtKayitTarihi;
    }
}