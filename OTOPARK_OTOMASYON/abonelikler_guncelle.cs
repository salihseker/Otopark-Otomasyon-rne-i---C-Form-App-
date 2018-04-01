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
    public partial class abonelikler_guncelle : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public abonelikler_guncelle()
        {
            InitializeComponent();
        }

        private void abonelikler_guncelle_Load(object sender, EventArgs e)
        {
            this.Text = "Abonelikler ";
            dpBaslangicTarihi.Value = DateTime.Now;
            dpBitisTarihi.Value = DateTime.Now.AddDays(10);
            BindDataGrid();
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

            int Num;
            bool isNum = int.TryParse(txtAboneUcreti.Text, out Num);
            if (!isNum)
            {
                MessageBox.Show("Ücret alanı sayısal değer olmalıdır !");
                return;
            }
            else {
                if (Convert.ToInt32(txtAboneUcreti.Text) <= 0)
                {
                    MessageBox.Show("Ücret alanı 0 dan büyük olamlıdır !");
                    return;
                }
            }
            if (dpBaslangicTarihi.Value >= dpBitisTarihi.Value)
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden Büyük ve Eşit Olamaz !");
                return;
            }


            try
            {
                SqlCommand myCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(lblAbonelikId.Text))
                    id = Convert.ToInt32(lblAbonelikId.Text);
                else
                    id = 0;

                if (id == 0)
                    blnKaydet = true;
                else
                    blnKaydet = false;

                if (blnKaydet)
                {
                    myCommand.CommandText = "I_ABONELIKLER";
                }
                else
                {
                    myCommand.CommandText = "U_ABONELIKLER";
                    myCommand.Parameters.AddWithValue("@ID", id);
                }

                myCommand.Parameters.AddWithValue("@ABONE_ID", lblAboneId.Text);
                myCommand.Parameters.AddWithValue("@BASLANGIC_TARIHI", dpBaslangicTarihi.Value);
                myCommand.Parameters.AddWithValue("@BITIS_TARIHI", dpBitisTarihi.Value);
                myCommand.Parameters.AddWithValue("@ABONE_UCRETI", txtAboneUcreti.Text);

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

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_ABONELIKLER";
            dgAbonelikler.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void dgAbonelikler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowId = dgAbonelikler.SelectedCells[0].RowIndex;

            if (dgAbonelikler.Rows[RowId].Cells[0].Value != null)
            {
                lblAbonelikId.Text = dgAbonelikler.Rows[RowId].Cells[0].Value.ToString();
                lblAboneId.Text = dgAbonelikler.Rows[RowId].Cells[1].Value.ToString();
                dpBaslangicTarihi.Value = Convert.ToDateTime(dgAbonelikler.Rows[RowId].Cells[2].Value.ToString());
                dpBitisTarihi.Value = Convert.ToDateTime(dgAbonelikler.Rows[RowId].Cells[3].Value.ToString());
                txtAboneUcreti.Text = dgAbonelikler.Rows[RowId].Cells[4].Value.ToString();
                txtKayitTarihi.Text = dgAbonelikler.Rows[RowId].Cells[5].Value.ToString();
                txtAboneAdSoyad.Text = dgAbonelikler.Rows[RowId].Cells[6].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblAbonelikId.Text = "";
            lblAboneId.Text = "";
            txtAboneAdSoyad.Text = "";
            dpBaslangicTarihi.Value = DateTime.Now;
            dpBitisTarihi.Value = DateTime.Now.AddDays(10);
            txtAboneUcreti.Text = "0";
            txtKayitTarihi.Text = "";

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string retvalue = "";
            int id = 0;
            if (!string.IsNullOrEmpty(lblAbonelikId.Text))
                id = Convert.ToInt32(lblAbonelikId.Text);


            if (id != 0)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "D_ABONELIKLER";
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

       
    }
}
