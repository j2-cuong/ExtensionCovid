using DataUseVaccine.FormDetail;
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataUseVaccine.Frm
{
    public partial class GridContent : DevExpress.XtraEditors.XtraUserControl
    {
        private static GridContent _instance;
        private string Conn = Properties.Settings.Default.ConnectionString;

        public GridContent()
        {
            InitializeComponent();
            LoadScreen();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = Guid.NewGuid();
            var time_ = DateTime.Now;
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormData _f = new FormData(ID.ToString(), time_);
            _f.ShowDialog();
            LoadScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var idSend = "";
            var time_ = DateTime.Now;
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["ID"].ToString();

            }

            Configs.UpdateSettingAppConfig("Editmode", "2");
            FormData _frmCm = new FormData(idSend , time_);
            _frmCm.ShowDialog();
            LoadScreen();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("test");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadScreen();
        }
        private void LoadScreen()
        {
            gridControl1.DataSource = LoadData.TrangChu();
        }

    }
}
