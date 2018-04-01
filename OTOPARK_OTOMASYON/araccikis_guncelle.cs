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
    public partial class araccikis_guncelle : Form
    {

        csDatabaseSql DataUtil = new csDatabaseSql();
        int RowId;
        public araccikis_guncelle()
        {
            InitializeComponent();
        }

        private void araccikis_guncelle_Load(object sender, EventArgs e)
        {
            this.Text = "Araç Çıkış İşlemi";
            dpCikisTarihi.Value = DateTime.Now;
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_ARAC_CIKIS";
            myCommand.Parameters.AddWithValue("@TUMKAYITLAR_FL", chkTumliste.Checked);
            dgAracCikis.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            lblAboneId.Text = "";
            lblGirisId.Text = "";
            txtAdSoyad.Text = "";
            lblSure.Text = "";
            lblUcret.Text = "";
            txtGirisTarihi.Text = "";
            txtPlaka.Text = "";
            txtKayitTarihi.Text = "";
            dpCikisTarihi.Value = DateTime.Now;

        }

        private void dgAracCikis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowId = dgAracCikis.SelectedCells[0].RowIndex;

            if (dgAracCikis.Rows[RowId].Cells[0].Value != null)
            {
                string strCikisTarihi = dgAracCikis.Rows[RowId].Cells[5].Value.ToString();
                lblGirisId.Text = dgAracCikis.Rows[RowId].Cells[0].Value.ToString();
                lblAboneId.Text = dgAracCikis.Rows[RowId].Cells[1].Value.ToString();
                txtAdSoyad.Text = dgAracCikis.Rows[RowId].Cells[2].Value.ToString();
                txtPlaka.Text = dgAracCikis.Rows[RowId].Cells[3].Value.ToString();
                txtGirisTarihi.Text = dgAracCikis.Rows[RowId].Cells[4].Value.ToString();
                dpCikisTarihi.Value = string.IsNullOrEmpty(strCikisTarihi) ? DateTime.Now : Convert.ToDateTime(dgAracCikis.Rows[RowId].Cells[5].Value.ToString());
                lblSure.Text = dgAracCikis.Rows[RowId].Cells[6].Value.ToString();
                lblUcret.Text = dgAracCikis.Rows[RowId].Cells[7].Value.ToString();
                txtKayitTarihi.Text = dgAracCikis.Rows[RowId].Cells[8].Value.ToString();

            }
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
                    myCommand.CommandText = "U_ARAC_CIKIS_IPTAL";
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

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool blnKaydet = false;
            string retvalue = "", ucret = "", sure = "";

            if (Convert.ToDateTime(txtGirisTarihi.Text) >= dpCikisTarihi.Value)
            {
                MessageBox.Show("Giriş Tarihi , Bitiş Tarihinden Büyük ve Eşit Olamaz !");
                return;
            }

            try
            {
                SqlCommand myCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(lblGirisId.Text))
                {
                    id = Convert.ToInt32(lblGirisId.Text);

                }
                else
                {
                    MessageBox.Show("İşlem yapılacak Satır Seçiniz , Giriş Id si boş olamaz !");
                    return;
                }


                myCommand.CommandText = "U_ARAC_CIKIS";
                myCommand.Parameters.AddWithValue("@ID", id);
                myCommand.Parameters.AddWithValue("@CIKIS_TARIHI", dpCikisTarihi.Value);

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

            try
            {
                if (dgAracCikis.Rows[RowId].Cells[0].Value != null)
                {
                    sure = dgAracCikis.Rows[RowId].Cells[6].Value.ToString();
                    ucret = dgAracCikis.Rows[RowId].Cells[7].Value.ToString();
                    lblSure.Text = sure;
                    lblUcret.Text = ucret;
                    if (!string.IsNullOrEmpty(sure) && sure != "0")
                    {
                        MessageBox.Show("Süre : " + sure + " saat . \n Ücret : " + ucret + " TL ");
                    }
                }
            }
            catch
            {

            }
        }

    }
}
