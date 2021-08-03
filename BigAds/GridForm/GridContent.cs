using BigAds.FormDetail;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridContent : DevExpress.XtraEditors.XtraUserControl
    {
        private static GridContent _instance;
        private string Conn = Properties.Settings.Default.ConnectionString;

        public GridContent()
        {
            InitializeComponent();
        }

        public static GridContent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridContent();
                return _instance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
