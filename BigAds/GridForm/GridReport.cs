using BigAds.FormDetail;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridReport : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridReport _instance;
        public GridReport()
        {
            InitializeComponent();
            _conn.Open();
        }
        public static GridReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridReport();
                return _instance;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
