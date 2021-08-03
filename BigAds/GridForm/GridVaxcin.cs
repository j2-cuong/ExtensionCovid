using BigAds.FormDetail;
using BigAds.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BigAds.Frm
{
    public partial class GridVaxcin : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridVaxcin _instance;
        public GridVaxcin()
        {
            InitializeComponent();
            _conn.Open();
        }
        public static GridVaxcin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridVaxcin();
                return _instance;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = new Guid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormVaxcin _f = new FormVaxcin(ID.ToString());
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
            FormVaxcin _frmCm = new FormVaxcin(idSend);
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
