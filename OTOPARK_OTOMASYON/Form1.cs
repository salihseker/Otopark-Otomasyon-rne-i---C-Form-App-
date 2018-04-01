using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOPARK_OTOMASYON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "OTOPARK OTOMASYONU";

        }


        private void aboneBilgisiTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abone_guncelle abone_guncelle = new abone_guncelle();
            abone_guncelle.Show();

        }

        private void abonelikOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abonelikler_guncelle abonelikler_guncelle = new abonelikler_guncelle();
            abonelikler_guncelle.Show();
        }

        private void tarifeTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarifeler_guncelle tarifeler_guncelle = new tarifeler_guncelle();
            tarifeler_guncelle.Show();
        }

        private void araçGirişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracgiris_guncelle aracgiris_guncelle = new aracgiris_guncelle();
            aracgiris_guncelle.Show();
        }

        private void araçÇıkışıVeÜcretlendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araccikis_guncelle araccikis_guncelle = new araccikis_guncelle();
            araccikis_guncelle.Show();
        }

        private void plakayaAitGirişÇıkışHareketleriRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracgiriscikis_rapor aracgiriscikis_rapor = new aracgiriscikis_rapor();
            aracgiriscikis_rapor.Show();
        }

        private void otoparktaBulunanAraçRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otoparktaki_arac_rapor otoparktaki_arac_raporu = new otoparktaki_arac_rapor();
            otoparktaki_arac_raporu.Show();
        }

        private void aboneliğiAktifOlanÜyeRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktif_abone_rapor aktif_abone_rapor = new aktif_abone_rapor();
            aktif_abone_rapor.Show();
        }

        private void aylıkOtoparkKazançRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aylik_kazanc_rapor aylik_kazanc_rapor = new aylik_kazanc_rapor();
            aylik_kazanc_rapor.Show();
        } 
    }
}
