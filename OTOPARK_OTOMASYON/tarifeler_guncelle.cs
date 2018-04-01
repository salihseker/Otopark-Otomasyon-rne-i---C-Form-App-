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
    public partial class tarifeler_guncelle : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public tarifeler_guncelle()
        {
            InitializeComponent();
        }

        private void tarifeler_guncelle_Load(object sender, EventArgs e)
        {
            this.Text = "Tarifeler";
            dpIlkSaat.Value = DateTime.Now;
            dpSonSaat.Value = DateTime.Now.AddHours(1);
            BindDataGrid();
        }


        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_TARIFELER";
            dgTarifeler.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool blnKaydet = false;
            string retvalue = "", strdpSonSaat="";

            int Num;
            bool isNum = int.TryParse(txtTarifeUcreti.Text, out Num);
            if (!isNum)
            {
                MessageBox.Show("Ücret alanı sayısal değer olmalıdır !");
                return;
            }
            else
            {
                if (Convert.ToInt32(txtTarifeUcreti.Text) <= 0)
                {
                    MessageBox.Show("Ücret alanı 0 dan büyük olamlıdır !");
                    return;
                }
            }
            if (dpIlkSaat.Value >= dpSonSaat.Value && dpSonSaat.Text !="00")
            {
                MessageBox.Show("İlk Saat , Son  Saatten Büyük ve Eşit Olamaz !");
                return;
            }


            try
            {
                SqlCommand myCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(lblTarifeId.Text))
                    id = Convert.ToInt32(lblTarifeId.Text);
                else
                    id = 0;

                if (id == 0)
                    blnKaydet = true;
                else
                    blnKaydet = false;

                if (blnKaydet)
                {
                    myCommand.CommandText = "I_TARIFELER";
                }
                else
                {
                    myCommand.CommandText = "U_TARIFELER";
                    myCommand.Parameters.AddWithValue("@ID", id);
                }

                myCommand.Parameters.AddWithValue("@ILK_SAAT", dpIlkSaat.Text);
                myCommand.Parameters.AddWithValue("@SON_SAAT", strdpSonSaat = dpSonSaat.Text == "00" ? "24" : dpSonSaat.Text);
                myCommand.Parameters.AddWithValue("@UCRET", txtTarifeUcreti.Text);
                myCommand.Parameters.AddWithValue("@AKTIF", chkAktif.Checked);

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
            lblTarifeId.Text = "";

            dpIlkSaat.Value = DateTime.Now;
            dpSonSaat.Value = DateTime.Now.AddHours(1);
            txtTarifeUcreti.Text = "0";
            chkAktif.Checked = false;
            txtKayitTarihi.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = 0;
            string retvalue = "";

            if (!string.IsNullOrEmpty(lblTarifeId.Text))
             id = Convert.ToInt32(lblTarifeId.Text);


            if (id != 0)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "D_TARIFELER";
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

        private void dgTarifeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowId = dgTarifeler.SelectedCells[0].RowIndex;

            if (dgTarifeler.Rows[RowId].Cells[0].Value != null)
            {
                lblTarifeId.Text = dgTarifeler.Rows[RowId].Cells[0].Value.ToString();
                dpIlkSaat.Value = Convert.ToDateTime(dgTarifeler.Rows[RowId].Cells[1].Value.ToString());
                dpSonSaat.Value = Convert.ToDateTime(dgTarifeler.Rows[RowId].Cells[2].Value.ToString());
                txtTarifeUcreti.Text = dgTarifeler.Rows[RowId].Cells[3].Value.ToString();
                chkAktif.Checked = bool.Parse(dgTarifeler.Rows[RowId].Cells[4].Value.ToString());
                txtKayitTarihi.Text = dgTarifeler.Rows[RowId].Cells[5].Value.ToString();
            }
        }
    }
}
