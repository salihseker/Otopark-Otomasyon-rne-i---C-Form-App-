namespace OTOPARK_OTOMASYON
{
    partial class aracgiriscikis_rapor
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
            this.dgGirisCikis = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnExceleAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGirisCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGirisCikis
            // 
            this.dgGirisCikis.AllowUserToAddRows = false;
            this.dgGirisCikis.AllowUserToDeleteRows = false;
            this.dgGirisCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGirisCikis.Location = new System.Drawing.Point(12, 63);
            this.dgGirisCikis.Name = "dgGirisCikis";
            this.dgGirisCikis.Size = new System.Drawing.Size(754, 365);
            this.dgGirisCikis.TabIndex = 5;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(106, 20);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(143, 20);
            this.txtArama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaka No :";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(271, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(381, 20);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(118, 23);
            this.btnExceleAktar.TabIndex = 7;
            this.btnExceleAktar.Text = "Excel e Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // aracgiriscikis_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dgGirisCikis);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Name = "aracgiriscikis_rapor";
            this.Text = "aracgiriscikis_rapor";
            this.Load += new System.EventHandler(this.aracgiriscikis_rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGirisCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGirisCikis;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnExceleAktar;
    }
}