using DataUseVaccine.FormDetail;
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataUseVaccine.Frm
{
    public partial class GridDtuong : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridDtuong _instance;
        public GridDtuong()
        {
            InitializeComponent();
            _conn.Open();
            LoadScreen();
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
        private void LoadScreen()
        {
            gridControl1.DataSource = LoadData.LoadDoiTuong();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = Guid.NewGuid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormDtuong _f = new FormDtuong(ID.ToString());
            _f.ShowDialog();
            LoadScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var idSend = "";
            var idcheck = "";
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["DTuong_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTuong_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    Configs.UpdateSettingAppConfig("Editmode", "2");
                    FormDtuong _frmCm = new FormDtuong(idSend);
                    _frmCm.ShowDialog();
                    LoadScreen();
                }
                catch (Exception ec)
                {
                    XtraMessageBox.Show(ec.Message);
                    return;
                }
            }      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var idSend = "";
            var idcheck = "";
            foreach (var item in gridView1.GetSelectedRows())
            {
                DataRowView a = (DataRowView)gridView1.GetRow(item);
                idSend = a.Row["DTuong_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTuong_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    var Qre = $"delete dbo.DTuong WHERE DTuong_id = '{idSend}'";
                    SqlCommand InsertSQL = new SqlCommand(Qre, _conn);
                    InsertSQL.ExecuteNonQuery();
                    XtraMessageBox.Show("xóa thành công");
                    LoadScreen();
                }
                catch (Exception e12)
                {
                    XtraMessageBox.Show(e12.Message);
                    return;
                }
            }
        }
    }
}
