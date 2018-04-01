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
    public partial class abone_guncelle : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public abone_guncelle()
        {
            InitializeComponent();

        }

        private void abone_guncelle_Load(object sender, EventArgs e)
        {
            this.Text = "Abone Tanımlama";
            this.txtKayitTarihi.Enabled = false;
            BindDataGrid();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string retvalue = "";
            int abone_id = 0;
            bool blnKaydet = false;

            try
            {
                SqlCommand myCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(lblAboneId.Text))
                    abone_id = Convert.ToInt32(lblAboneId.Text);
                else
                    abone_id = 0;

                if (abone_id == 0)
                    blnKaydet = true;
                else
                    blnKaydet = false;

                if (blnKaydet)
                {
                    myCommand.CommandText = "I_ABONE";
                }
                else
                {
                    myCommand.CommandText = "U_ABONE";
                    myCommand.Parameters.AddWithValue("@ABONE_ID", abone_id);
                }

                myCommand.Parameters.AddWithValue("@AD", txtAdi.Text);
                myCommand.Parameters.AddWithValue("@SOYAD", txtSoyadi.Text);
                myCommand.Parameters.AddWithValue("@IL", txtIl.Text);
                myCommand.Parameters.AddWithValue("@ILCE", txtIlce.Text);
                myCommand.Parameters.AddWithValue("@TELEFON", txtTelefon.Text);

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
            myCommand.CommandText = "S_ABONE";
            myGridView.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void myGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowId = myGridView.SelectedCells[0].RowIndex;

            if (myGridView.Rows[RowId].Cells[0].Value != null)
            {
                lblAboneId.Text = myGridView.Rows[RowId].Cells[0].Value.ToString();
                txtAdi.Text = myGridView.Rows[RowId].Cells[1].Value.ToString();
                txtSoyadi.Text = myGridView.Rows[RowId].Cells[2].Value.ToString();
                txtIl.Text = myGridView.Rows[RowId].Cells[3].Value.ToString();
                txtIlce.Text = myGridView.Rows[RowId].Cells[4].Value.ToString();
                txtTelefon.Text = myGridView.Rows[RowId].Cells[5].Value.ToString();
                txtKayitTarihi.Text = myGridView.Rows[RowId].Cells[6].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblAboneId.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtTelefon.Text = "";
            txtKayitTarihi.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int abone_id = 0;
            string  retvalue = "";
            if (!string.IsNullOrEmpty(lblAboneId.Text))
                abone_id = Convert.ToInt32(lblAboneId.Text);


            if (abone_id != 0)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandText = "D_ABONE";
                    myCommand.Parameters.AddWithValue("@ABONE_ID", abone_id);
                    retvalue = DataUtil.emsExcQuery(myCommand);
                    BindDataGrid();
                    btnTemizle_Click(sender, e);

                    if (!string.IsNullOrEmpty(retvalue)) {
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
