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
    public partial class aracgiriscikis_rapor : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public aracgiriscikis_rapor()
        {
            InitializeComponent();
        }

        private void aracgiriscikis_rapor_Load(object sender, EventArgs e)
        {
            this.Text = "Araç Giriş/Çıkış Raporu";
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_ARAC_GIRIS_CIKIS_RAPOR";
            myCommand.Parameters.AddWithValue("@ARAC_PLAKA",txtArama.Text);
            dgGirisCikis.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            DataUtil.ToCsV(dgGirisCikis, "AracGirisCikis_Raporu.xls");
        }
    }
}
