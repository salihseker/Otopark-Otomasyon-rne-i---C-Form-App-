using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOPARK_OTOMASYON
{
    public partial class aracgiris_guncelle : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public aracgiris_guncelle()
        {
            InitializeComponent();
        }

        private void aracgiris_guncelle_Load(object sender, EventArgs e)
        {
            this.Text = "Araç Giriş Ekle";
            dpGirisTarihi.Value = DateTime.Now;
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_ARAC_GIRIS";
            dgAracGiris.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnAboneAra_Click(object sender, EventArgs e)
        {
            abone_arama abone_arama = new abone_arama();
            abone_arama.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            int id = 0;
            bool blnKaydet = false;
            string retvalue = "";

            try
            {
                SqlCommand myCommand = new SqlCommand();

                if (string.IsNullOrEmpty(txtPlaka.Text)){

                    MessageBox.Show("Plaka Bilgisi Boş Olamaz !");
                    return;
                }

                if (!string.IsNullOrEmpty(lblGirisId.Text))
                    id = Convert.ToInt32(lblGirisId.Text);
                else
                    id = 0;

                if (id == 0)
                    blnKaydet = true;
                else
                    blnKaydet = false;

                if (blnKaydet)
                {
                    myCommand.CommandText = "I_ARAC_GIRIS";
                }
                else
                {
                    myCommand.CommandText = "U_ARAC_GIRIS";
                    myCommand.Parameters.AddWithValue("@ID", id);
                }

                myCommand.Parameters.AddWithValue("@ABONE_ID", lblAboneId.Text);
                myCommand.Parameters.AddWithValue("@ARAC_PLAKA", txtPlaka.Text);
                myCommand.Parameters.AddWithValue("@AD_SOYAD", txtAdSoyad.Text);
                myCommand.Parameters.AddWithValue("@GIRIS_TARIHI", dpGirisTarihi.Value);

                retvalue = DataUtil.emsExcQuery(myCommand);
                if (!string.IsNullOrEmpty(retvalue))
                {
                    MessageBox.Show(retvalue);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            BindDataGrid();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            lblAboneId.Text = "";
            lblGirisId.Text = "";
            txtAdSoyad.Text = "";
            dpGirisTarihi.Value = DateTime.Now;
            txtPlaka.Text = "";
            txtKayitTarihi.Text = "";

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string retvalue = "";
            int id = 0;
            if (!string.IsNullOrEmpty(lblGirisId.Text))
                id = Convert.ToInt32(lblGirisId.Text);


            if (id != 0)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "D_ARAC_GIRIS";
                    myCommand.Parameters.AddWithValue("@ID", id);
                    retvalue = DataUtil.emsExcQuery(myCommand);
                    BindDataGrid();
                    btnTemizle_Click(sender, e);

                    if (!string.IsNullOrEmpty(retvalue))
                    {
                        MessageBox.Show(retvalue);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgAracGiris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowId = dgAracGiris.SelectedCells[0].RowIndex;

            if (dgAracGiris.Rows[RowId].Cells[0].Value != null)
            {
                lblGirisId.Text = dgAracGiris.Rows[RowId].Cells[0].Value.ToString();
                lblAboneId.Text = dgAracGiris.Rows[RowId].Cells[1].Value.ToString();
                txtAdSoyad.Text = dgAracGiris.Rows[RowId].Cells[2].Value.ToString();
                txtPlaka.Text   = dgAracGiris.Rows[RowId].Cells[3].Value.ToString();
                dpGirisTarihi.Value = Convert.ToDateTime(dgAracGiris.Rows[RowId].Cells[4].Value.ToString());
                txtKayitTarihi.Text = dgAracGiris.Rows[RowId].Cells[5].Value.ToString();

            }
        }
    }
}
