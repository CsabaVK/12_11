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
    public partial class FrmMain : Form
    {
        OleDbConnection conn;
        public FrmMain()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=utiroda.accdb");
            InitializeComponent();
            FillDgv();
        }

        private void FillDgv()
        {
            conn.Open();

            var cmd = new OleDbCommand("SELECT T_KÓD, HOVÁ, KEZDET, VÉG, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR " +
                "FROM (((TÚRA " +
                "INNER JOIN IDEGENVEZETŐ ON VEZETŐ = I_KÓD) " +
                //"INNER JOIN SZÁLLÁS ON SZÁLLÁS = SZ_KÓD) " +
                //"INNER JOIN ÚTVONAL ON ÚTVONAL = ÚT_KÓD) " +
                "GROUP BY T_KÓD, HOVÁ, KEZDET, VÉG, IDEGENVEZETŐ.NÉV, SZÁLLÁS.NÉV, ÁR;", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                dgvTurak.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6]);
            }

            conn.Close();
        }
    }
}
