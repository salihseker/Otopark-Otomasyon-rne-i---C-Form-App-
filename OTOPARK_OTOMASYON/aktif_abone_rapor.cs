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
    public partial class aktif_abone_rapor : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public aktif_abone_rapor()
        {
            InitializeComponent();
        }

        private void aktif_abone_rapor_Load(object sender, EventArgs e)
        {
            this.Text = "Aktif Abonelikler Raporu";
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_AKTIF_ABONELIK_RAPOR";
            dgAktifAbone.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            DataUtil.ToCsV(dgAktifAbone, "Aktif_Abonelikler_Raporu.xls");
        }
    }
}
