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
    public partial class aylik_kazanc_rapor : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public aylik_kazanc_rapor()
        {
            InitializeComponent();
        }

        private void aylik_kazanc_rapor_Load(object sender, EventArgs e)
        {
            this.Text = "Aylık Kazanç Raporu";
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_AYLIK_KAZANC_RAPOR";
            dgKazancRapor.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            DataUtil.ToCsV(dgKazancRapor, "Aylik_Kazanc_Raporu.xls");
        }
    }
}
