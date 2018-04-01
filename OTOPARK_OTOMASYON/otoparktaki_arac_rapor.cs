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
    public partial class otoparktaki_arac_rapor : Form
    {
        csDatabaseSql DataUtil = new csDatabaseSql();
        public otoparktaki_arac_rapor()
        {
            InitializeComponent();
        }

        private void otoparktaki_arac_raporu_Load(object sender, EventArgs e)
        {
            this.Text = "Otoparktaki Araçlar Raporu";
            BindDataGrid();
        }

        private void BindDataGrid()
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "S_OTOPARKTAKI_ARACLAR_RAPOR";
            dgOtoparktakiAraclar.DataSource = DataUtil.emsGetDataView(myCommand);

        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            DataUtil.ToCsV(dgOtoparktakiAraclar, "Otoparktaki_Araclar_Raporu.xls");
        }
    }
}
