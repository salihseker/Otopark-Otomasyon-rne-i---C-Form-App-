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
    public partial class abone_arama : Form
    {

        csDatabaseSql DataUtil = new csDatabaseSql();
        DataView dv = null;
        public abone_arama()
        {
            InitializeComponent();
        }

        private void abone_arama_Load(object sender, EventArgs e)
        {
            this.Text = "Abone Ara";
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_ABONE";
            dv = DataUtil.emsGetDataView(myCommand);
            dataGridViewAbone.DataSource = dv;

        }

        private void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (dv != null)
                {
                    dv.RowFilter = string.Format("AD + ' ' + SOYAD LIKE '%{0}%'", txtArama.Text);
                    dataGridViewAbone.DataSource = dv.ToTable();
                }
            }
        }

        private void dataGridViewAbone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowId = dataGridViewAbone.SelectedCells[0].RowIndex;

            if (dataGridViewAbone.Rows[RowId].Cells[0].Value != null)
            {
                abonelikler_guncelle abonelikler_guncelle = (abonelikler_guncelle)Application.OpenForms["abonelikler_guncelle"];
                if (abonelikler_guncelle != null)
                {
                    abonelikler_guncelle.lblAboneId.Text = dataGridViewAbone.Rows[RowId].Cells[0].Value.ToString();
                    abonelikler_guncelle.txtAboneAdSoyad.Text = dataGridViewAbone.Rows[RowId].Cells[1].Value.ToString() + " " + dataGridViewAbone.Rows[RowId].Cells[2].Value.ToString();
                }

                aracgiris_guncelle aracgiris_guncelle = (aracgiris_guncelle)Application.OpenForms["aracgiris_guncelle"];
                if (aracgiris_guncelle != null)
                {
                    aracgiris_guncelle.lblAboneId.Text = dataGridViewAbone.Rows[RowId].Cells[0].Value.ToString();
                    aracgiris_guncelle.txtAdSoyad.Text = dataGridViewAbone.Rows[RowId].Cells[1].Value.ToString() + " " + dataGridViewAbone.Rows[RowId].Cells[2].Value.ToString();
                }

                this.Close();
            }
        }
    }
}
