﻿using DataUseVaccine.FormDetail;
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataUseVaccine.Frm
{
    public partial class GridGroupDt : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private static GridGroupDt _instance;
        public GridGroupDt()
        {
            InitializeComponent();
            LoadScreen();
        }
        public static GridGroupDt Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GridGroupDt();
                return _instance;
            }
        }
        private void LoadScreen()
        {
            gridControl1.DataSource = LoadData.LoadGrDTuong();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid ID = Guid.NewGuid();
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormGroupDtuong _f = new FormGroupDtuong(ID.ToString());
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
                idSend = a.Row["GroupDTuong_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GroupDTuong_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    if(_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    Configs.UpdateSettingAppConfig("Editmode", "2");
                    FormGroupDtuong _frmCm = new FormGroupDtuong(idSend);
                    _frmCm.ShowDialog();
                    LoadScreen();

                } catch (Exception e2)
                {
                    XtraMessageBox.Show(e2.Message);
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
                idSend = a.Row["GroupDTuong_id"].ToString();
                idcheck += idSend;
            }
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GroupDTuong_id") == null/*gridView1.SelectedRowsCount == 0*/)
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
                    var Qr = $"Delete GroupDTuong where GroupDTuong_id = '{idSend}'";
                    SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                    InsertSQL.ExecuteNonQuery();
                    XtraMessageBox.Show("Xóa thành công");
                    LoadScreen();

                }
                catch (Exception e2)
                {
                    XtraMessageBox.Show(e2.Message);
                }
            }
        }
    }
}
