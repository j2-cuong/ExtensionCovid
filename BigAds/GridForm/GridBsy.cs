using BigAds.FormDetail;
using BigAds.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridBsy : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridBsy _instance;
        public GridBsy()
        {
            InitializeComponent();
            _conn.Open();
        }
        public static GridBsy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridBsy();
                return _instance;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = new Guid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormBsy _f = new FormBsy(ID.ToString());
            _f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var idSend = "";
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["ID"].ToString();

            }

            Configs.UpdateSettingAppConfig("Editmode", "2");
            FormBsy _frmCm = new FormBsy(idSend);
            _frmCm.ShowDialog();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var idSend = "";
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["ID"].ToString();

            }
        }
    }
}
