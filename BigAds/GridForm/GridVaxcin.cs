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
            LoadScreen();
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
            Guid ID = Guid.NewGuid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormVaxcin _f = new FormVaxcin(ID.ToString());
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
                idSend = a.Row["vx_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "vx_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    FormVaxcin _frmCm = new FormVaxcin(idSend);
                    _frmCm.ShowDialog();
                    LoadScreen();
                }
                catch (Exception ev)
                {
                    MessageBox.Show(ev.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                idSend = a.Row["vx_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "vx_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    var Qr = $"Delete VacXin where vx_id = '{idSend}'";
                    SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                    InsertSQL.ExecuteNonQuery();
                    XtraMessageBox.Show("Xóa thành công");
                    LoadScreen();
                }
                catch (Exception ev)
                {
                    MessageBox.Show(ev.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void LoadScreen()
        {
            gridControl1.DataSource = LoadData.LoadVx();
        }
    }
}
