namespace OTOPARK_OTOMASYON
{
    partial class tarifeler_guncelle
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
            this.lblTarifeId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgTarifeler = new System.Windows.Forms.DataGridView();
            this.dpSonSaat = new System.Windows.Forms.DateTimePicker();
            this.dpIlkSaat = new System.Windows.Forms.DateTimePicker();
            this.txtTarifeUcreti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTarifeler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.AutoSize = true;
            this.txtKayitTarihi.Location = new System.Drawing.Point(155, 187);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.Size = new System.Drawing.Size(0, 13);
            this.txtKayitTarihi.TabIndex = 33;
            // 
            // lblTarifeId
            // 
            this.lblTarifeId.AutoSize = true;
            this.lblTarifeId.Location = new System.Drawing.Point(165, 48);
            this.lblTarifeId.Name = "lblTarifeId";
            this.lblTarifeId.Size = new System.Drawing.Size(0, 13);
            this.lblTarifeId.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tarife Id : ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(673, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 70);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(526, 103);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 70);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(388, 102);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 70);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgTarifeler
            // 
            this.dgTarifeler.AllowUserToAddRows = false;
            this.dgTarifeler.AllowUserToDeleteRows = false;
            this.dgTarifeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTarifeler.Location = new System.Drawing.Point(46, 222);
            this.dgTarifeler.Name = "dgTarifeler";
            this.dgTarifeler.Size = new System.Drawing.Size(741, 184);
            this.dgTarifeler.TabIndex = 26;
            this.dgTarifeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTarifeler_CellClick);
            // 
            // dpSonSaat
            // 
            this.dpSonSaat.CustomFormat = "HH";
            this.dpSonSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpSonSaat.Location = new System.Drawing.Point(158, 101);
            this.dpSonSaat.Name = "dpSonSaat";
            this.dpSonSaat.ShowUpDown = true;
            this.dpSonSaat.Size = new System.Drawing.Size(72, 20);
            this.dpSonSaat.TabIndex = 25;
            // 
            // dpIlkSaat
            // 
            this.dpIlkSaat.CustomFormat = "HH";
            this.dpIlkSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpIlkSaat.Location = new System.Drawing.Point(158, 76);
            this.dpIlkSaat.Name = "dpIlkSaat";
            this.dpIlkSaat.ShowUpDown = true;
            this.dpIlkSaat.Size = new System.Drawing.Size(72, 20);
            this.dpIlkSaat.TabIndex = 24;
            // 
            // txtTarifeUcreti
            // 
            this.txtTarifeUcreti.Location = new System.Drawing.Point(158, 129);
            this.txtTarifeUcreti.Name = "txtTarifeUcreti";
            this.txtTarifeUcreti.Size = new System.Drawing.Size(72, 20);
            this.txtTarifeUcreti.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kayıt Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ücreti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Son Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "İlk Saat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Aktif :";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(158, 160);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(15, 14);
            this.chkAktif.TabIndex = 35;
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "TL";
            // 
            // tarifeler_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKayitTarihi);
            this.Controls.Add(this.lblTarifeId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgTarifeler);
            this.Controls.Add(this.dpSonSaat);
            this.Controls.Add(this.dpIlkSaat);
            this.Controls.Add(this.txtTarifeUcreti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "tarifeler_guncelle";
            this.Text = "tarifeler_guncelle";
            this.Load += new System.EventHandler(this.tarifeler_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTarifeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtKayitTarihi;
        private System.Windows.Forms.Label lblTarifeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgTarifeler;
        private System.Windows.Forms.DateTimePicker dpSonSaat;
        private System.Windows.Forms.DateTimePicker dpIlkSaat;
        private System.Windows.Forms.TextBox txtTarifeUcreti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Label label6;
    }
}