using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _12_11
{
    public partial class UtasSzerkesztes : Form
    {
        OleDbConnection conn;
        DateTime ma = new DateTime(2015, 10, 11);
        public UtasSzerkesztes()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=utiroda.accdb");
            conn.Open();

            var cmd = new OleDbCommand("SELECT T_KÓD, ÚTVONAL.HOVÁ, KEZDET, VÉGE, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR " +
                "FROM (((TÚRA " +
                "INNER JOIN IDEGENVEZETŐ ON TÚRA.VEZETŐ = IDEGENVEZETŐ.I_KÓD) " +
                "INNER JOIN ÚTVONAL ON TÚRA.ÚTVONAL = ÚTVONAL.ÚT_KÓD) " +
                "INNER JOIN SZÁLLÁS ON TÚRA.SZÁLLÁS = SZÁLLÁS.SZ_KÓD) " +
                $"WHERE KEZDET > #{ma.ToString("yyyy-MM-") + "01"}#" +
                "GROUP BY T_KÓD, ÚTVONAL.HOVÁ, KEZDET, VÉGE, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR " +
                "ORDER BY KEZDET ASC;", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                comboBox1.Items.Add(r[0]);
            }

            conn.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KeresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var valami = new UtasKereses();
            valami.ShowDialog();
        }
    }
}
