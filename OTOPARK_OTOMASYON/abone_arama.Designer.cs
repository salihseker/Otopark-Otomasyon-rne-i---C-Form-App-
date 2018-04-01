namespace OTOPARK_OTOMASYON
{
    partial class abone_arama
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dataGridViewAbone = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad Ara :";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(117, 20);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(652, 20);
            this.txtArama.TabIndex = 1;
            this.txtArama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArama_KeyPress);
            // 
            // dataGridViewAbone
            // 
            this.dataGridViewAbone.AllowUserToAddRows = false;
            this.dataGridViewAbone.AllowUserToDeleteRows = false;
            this.dataGridViewAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbone.Location = new System.Drawing.Point(23, 63);
            this.dataGridViewAbone.Name = "dataGridViewAbone";
            this.dataGridViewAbone.Size = new System.Drawing.Size(746, 365);
            this.dataGridViewAbone.TabIndex = 2;
            this.dataGridViewAbone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAbone_CellClick);
            // 
            // abone_arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.dataGridViewAbone);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Name = "abone_arama";
            this.Text = "abone_arama";
            this.Load += new System.EventHandler(this.abone_arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dataGridViewAbone;
    }
}