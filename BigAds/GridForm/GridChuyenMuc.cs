using BigAds.FormDetail;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridChuyenMuc : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridChuyenMuc _instance;
        public GridChuyenMuc()
        {
            InitializeComponent();
            _conn.Open();
        }
        public static GridChuyenMuc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridChuyenMuc();
                return _instance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
