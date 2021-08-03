using BigAds.FormDetail;
using BigAds.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridDtuong : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridDtuong _instance;
        public GridDtuong()
        {
            InitializeComponent();
            _conn.Open();
        }
        public static GridDtuong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridDtuong();
                return _instance;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = new Guid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormDtuong _f = new FormDtuong(ID.ToString());
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
            FormDtuong _frmCm = new FormDtuong(idSend);
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
