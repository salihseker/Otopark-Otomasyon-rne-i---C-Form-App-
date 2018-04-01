namespace OTOPARK_OTOMASYON
{
    partial class aracgiris_guncelle
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
            this.txtKayitTarihi = new System.Windows.Forms.Label();
            this.lblGirisId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgAracGiris = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAboneId = new System.Windows.Forms.Label();
            this.dpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAboneAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAracGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.AutoSize = true;
            this.txtKayitTarihi.Location = new System.Drawing.Point(143, 166);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.Size = new System.Drawing.Size(0, 13);
            this.txtKayitTarihi.TabIndex = 50;
            // 
            // lblGirisId
            // 
            this.lblGirisId.AutoSize = true;
            this.lblGirisId.Location = new System.Drawing.Point(188, 39);
            this.lblGirisId.Name = "lblGirisId";
            this.lblGirisId.Size = new System.Drawing.Size(0, 13);
            this.lblGirisId.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Giriş Id : ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(674, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 70);
            this.btnSil.TabIndex = 47;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(527, 110);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 70);
            this.btnTemizle.TabIndex = 46;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(389, 109);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 70);
            this.btnKaydet.TabIndex = 45;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgAracGiris
            // 
            this.dgAracGiris.AllowUserToAddRows = false;
            this.dgAracGiris.AllowUserToDeleteRows = false;
            this.dgAracGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAracGiris.Location = new System.Drawing.Point(34, 214);
            this.dgAracGiris.Name = "dgAracGiris";
            this.dgAracGiris.Size = new System.Drawing.Size(777, 299);
            this.dgAracGiris.TabIndex = 44;
            this.dgAracGiris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAracGiris_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kayıt Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Plaka :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 60);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(235, 20);
            this.txtAdSoyad.TabIndex = 59;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(125, 94);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(235, 20);
            this.txtPlaka.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Abone Id : ";
            // 
            // lblAboneId
            // 
            this.lblAboneId.AutoSize = true;
            this.lblAboneId.Location = new System.Drawing.Point(586, 63);
            this.lblAboneId.Name = "lblAboneId";
            this.lblAboneId.Size = new System.Drawing.Size(0, 13);
            this.lblAboneId.TabIndex = 49;
            // 
            // dpGirisTarihi
            // 
            this.dpGirisTarihi.CustomFormat = "dd.MM.yyyy HH.mm";
            this.dpGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpGirisTarihi.Location = new System.Drawing.Point(125, 122);
            this.dpGirisTarihi.Name = "dpGirisTarihi";
            this.dpGirisTarihi.Size = new System.Drawing.Size(235, 20);
            this.dpGirisTarihi.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Giriş Tarihi :";
            // 
            // btnAboneAra
            // 
            this.btnAboneAra.Location = new System.Drawing.Point(375, 58);
            this.btnAboneAra.Name = "btnAboneAra";
            this.btnAboneAra.Size = new System.Drawing.Size(98, 22);
            this.btnAboneAra.TabIndex = 58;
            this.btnAboneAra.Text = "Abone Ara";
            this.btnAboneAra.UseVisualStyleBackColor = true;
            this.btnAboneAra.Click += new System.EventHandler(this.btnAboneAra_Click);
            // 
            // aracgiris_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 542);
            this.Controls.Add(this.dpGirisTarihi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnAboneAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKayitTarihi);
            this.Controls.Add(this.lblAboneId);
            this.Controls.Add(this.lblGirisId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgAracGiris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "aracgiris_guncelle";
            this.Text = "aracgiris_guncelle";
            this.Load += new System.EventHandler(this.aracgiris_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAracGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtKayitTarihi;
        private System.Windows.Forms.Label lblGirisId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgAracGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpGirisTarihi;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblAboneId;
        private System.Windows.Forms.Button btnAboneAra;
        public System.Windows.Forms.TextBox txtAdSoyad;
    }
}