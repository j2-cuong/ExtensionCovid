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
            Guid ID = new Guid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormData _f = new FormData(ID.ToString());
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
            FormData _frmCm = new FormData(idSend);
            _frmCm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
