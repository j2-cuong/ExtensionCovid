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
            var idcheck = "";
            var time_ = DateTime.Now;
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["TrangChu_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrangChu_id") == null/*gridView1.SelectedRowsCount == 0*/)
            {
                MessageBox.Show("Bạn chưa chọn mã cần chỉnh sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("Bạn chưa chọn mã cần chỉnh sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idcheck.Length > 36)
            {
                MessageBox.Show("Bạn không thể chỉnh sửa nhiều mã cùng 1 lúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //var resultDel = new CountTime().delContent(idSend);
                    //if (!resultDel.IsResult)
                    //{
                    //    MessageBox.Show(resultDel.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                        Configs.UpdateSettingAppConfig("Editmode", "2");
                        FormData _frmCm = new FormData(idSend, time_);
                        _frmCm.ShowDialog();
                        LoadScreen();
                    //}
                } catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

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

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["trang_thai"]);
                    //string daKy = View.GetRowCellDisplayText(e.RowHandle, View.Columns["gInvoice"]);

                    if (category == "Đã tiêm mũi 1" || string.IsNullOrEmpty(category.ToString()))
                    {
                        e.HighPriority = true;
                        e.Appearance.BackColor = Color.LightGreen;
                    }

                    else if(category == "Đã tiêm mũi 2" || string.IsNullOrEmpty(category.ToString()))
                    {
                        e.Appearance.BackColor = Color.LightYellow;
                        e.HighPriority = true;
                    }
                }
            }
        }
    }
}
