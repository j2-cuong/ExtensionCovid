using DataUseVaccine.DetailForm;
using DataUseVaccine.FormDetail;
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataUseVaccine.Frm
{
    public partial class GridContent : DevExpress.XtraEditors.XtraUserControl
    {
        private static GridContent _instance;
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
            var time_ = DateTime.Now.ToString("dd - MM - yyyy   HH:mm.ss tt");
            Configs.UpdateSettingAppConfig("Editmode", "1");
            FormData _f = new FormData(ID.ToString(), time_);
            _f.ShowDialog();
            LoadScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var idSend = "";
            var idcheck = "";
            var time_ = DateTime.Now.ToString("dd - MM - yyyy   HH:mm.ss tt");
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
                    //if (!resultDel.IsResult == true)
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
            var idSend = "";
            var idcheck = "";
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
                typePrint _frmCm = new typePrint(idSend);
                _frmCm.ShowDialog();
            }
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            var idSend = "";
            var idcheck = "";
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
                    
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    var Qr = $"select * from  TrangChu where TrangChu_id = '{idSend}' AND trang_thai like '%2%'";
                    DataTable _check = new DataTable();
                    SqlDataAdapter f = new SqlDataAdapter(Qr, _conn);
                    f.Fill(_check);
                    if(_check.Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Không thể xóa dữ liệu đã tiêm lần 2");
                    }
                    else
                    {
                        var Qru = $"delete TrangChu where TrangChu_id = '{idSend}'";
                        SqlCommand InsertSQL = new SqlCommand(Qru, _conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Xóa thành công");
                        LoadScreen();
                    }  
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            infoForm f = new infoForm();
            f.ShowDialog();
        }
    }
}
