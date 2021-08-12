using DataUseVaccine.FormDetail;
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using ExcelDataReader;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;
using System.Drawing.Drawing2D;
using System.Globalization;

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
        private DataTable ImportExcelToDt(string FilePath)
        {
            DataTable dt = null;
            try
            {
                using (var stream = File.Open(FilePath, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);

                    // Now you can get data from each sheet by its index or its "name"
                    dt = dataSet.Tables[0];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Vui lòng tắt Excel đi trước khi import.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
            //...
        }
        SqlLibrary sLib = new SqlLibrary();
        string conn = Properties.Settings.Default.ConnectionString;
        private void InsertDTuong(string ma_dt,string ten, string DoB, string Gtinh, string dvCtac, string sdt, string cccd, string bhyt, string maNhom, string Tinh, string maTinh, string Quan, string maQuan, string xa, string maXa, string dChi)
        {
            sLib.open(conn);
            DateTime add = DateTime.Now;
            string id = Guid.NewGuid().ToString();
            string ma = Guid.NewGuid().ToString();
            string gt = "Nam";
            if (Gtinh == "1")
            {
                gt = "Nữ";
            }
            string sqlinsert = @"
            INSERT INTO DTuong(
			DTuong_id,
			DTuong_ma,
			DTuong_ten,
			DTuong_nsinh,
			DTuong_GTinh,
			DTuong_DVCtac,
			DTuong_SDT,
			DTuong_CCCD,
			DTuong_BHYT,
			DTuong_MaNhom,
			DTuong_Tinh,
			DTuong_TinhCode,
			DTuong_Quan,
			DTuong_QuanCode,
			DTuong_Xa,
			DTuong_XaCode,
			DTuong_DCCtiet,
			isTimeAdd
			) VALUES (
            N'" + id + @"',
            N'" + ma_dt + @"',
            N'" + ten + @"',
            N'" + DoB + @"',
            N'" + gt + @"',
            N'" + dvCtac + @"',
            N'" + sdt + @"',
            N'" + cccd + @"',
            N'" + bhyt + @"',
            N'" + maNhom + @"',
            N'" + Tinh + @"',
            N'" + maTinh + @"',
            N'" + Quan + @"',
            N'" + maQuan + @"',
            N'" + xa + @"',
            N'" + maXa + @"',
            N'" + dChi + @"',
            N'" + add.ToString() + @"')
            ";
            sLib.ExecuteQueries(sqlinsert);
            sLib.close();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            string FileName = "";
            string FileDirectory = "";
            string extension = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "*.xls (*.xls)|*.xls|*.xlsx (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog.FileName;
                    FileDirectory = openFileDialog.FileName;
                    extension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    DataTable dt = ImportExcelToDt(FileName);
                    if (dt != null)
                    {
                        for (int i = 7; i < dt.Rows.Count; i++)
                        {
                            InsertDTuong(
                                dt.Rows[i][16].ToString(),
                                dt.Rows[i][1].ToString(),
                                Convert.ToDateTime(dt.Rows[i][2].ToString()).ToString("yyyy-MM-dd"),
                                dt.Rows[i][3].ToString(),
                                dt.Rows[i][5].ToString(),
                                dt.Rows[i][6].ToString(),
                                dt.Rows[i][7].ToString(),
                                dt.Rows[i][8].ToString(),
                                dt.Rows[i][4].ToString(),
                                dt.Rows[i][9].ToString(),
                                dt.Rows[i][10].ToString(),
                                dt.Rows[i][11].ToString(),
                                dt.Rows[i][12].ToString(),
                                dt.Rows[i][13].ToString(),
                                dt.Rows[i][14].ToString(),
                                dt.Rows[i][15].ToString()
                                );
                        }
                        MessageBox.Show("Import hoàn tất!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadScreen();
                    }
                }
            }
        }
        public static void OpenWithDefaultProgram()
        {
            using (Process fileopener = new Process())
            {
                fileopener.StartInfo.FileName = "explorer";
                fileopener.StartInfo.Arguments = "\"" + Application.StartupPath+ @"\Excel\Import DM Patient.xls" + "\"";
                fileopener.Start();
            } 
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenWithDefaultProgram();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
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
                    var Qre = $"select  DTuong_ma as ma_dt, DTuong_ten as ten_dt from dbo.DTuong WHERE DTuong_id = '{idSend}'";
                    DataTable Code = new DataTable();
                    SqlDataAdapter f = new SqlDataAdapter(Qre, _conn);
                    f.Fill(Code);
                    if(Code.Rows.Count > 0)
                    {
                        var Name = DateTime.Now;
                        string text = DateTime.UtcNow.ToString("dd_MM_yyy",
                                                   CultureInfo.InvariantCulture);
                        var barcode = "";
                        var barcodeName = "";
                        string root = $@"D:\BarCodes\{text}";
                        
                        if (!Directory.Exists(root))
                        {
                            Directory.CreateDirectory(root);

                        }
                        foreach (DataRow item in Code.Rows)
                        {
                            barcode = item["ma_dt"].ToString().Trim();
                            barcodeName = item["ten_dt"].ToString().Trim();
                        }
                        QrCodeEncodingOptions  options = new QrCodeEncodingOptions
                        {
                            DisableECI = true,
                            CharacterSet = "UTF-8",
                            Width = 120,
                            Height = 50,
                        };
                        var qr = new BarcodeWriter();
                        qr.Options = options;
                        qr.Format = BarcodeFormat.CODE_128;
                        var result = new Bitmap(qr.Write(barcode.Trim()));

                        var name = result + ".png";                       
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.InitialDirectory = root;
                        saveFileDialog1.Title = "Save Files";
                        saveFileDialog1.CheckFileExists = false;
                        saveFileDialog1.CheckPathExists = false;
                        saveFileDialog1.DefaultExt = "png";
                        saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;
                        ImageFormat format = ImageFormat.Png;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            result.Save($@"{root}\{barcode}.png");
                        }
                        Process.Start($@"{root}\{barcode}.png");
                    }
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
