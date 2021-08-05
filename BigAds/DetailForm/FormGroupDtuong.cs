using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using BigAds.Services;
using System.Data;
using DevExpress.XtraEditors;

namespace BigAds.FormDetail
{
    public partial class FormGroupDtuong : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
            //changes commit
    );
        public static string _conn = Properties.Settings.Default.ConnectionString;
        private string idGrid;
        public FormGroupDtuong(string ID)
        {
            idGrid = ID;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = new SqlConnection(_conn);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                if (Properties.Settings.Default.Editmode.Contains("1"))
                {
                    if (string.IsNullOrEmpty(txtMa.Text.Trim()) || string.IsNullOrEmpty(txtTen.Text.Trim()))
                    {
                        XtraMessageBox.Show("Thông tin không đủ, vui lòng nhập thêm dữ liệu");
                    }
                    else
                    {
                        var Qr = $"INSERT INTO GroupDTuong VALUES('{idGrid}' ,'{txtMa.Text}' , N'{txtTen.Text}', GETDATE() )";
                        SqlCommand InsertSQL = new SqlCommand(Qr, Conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Thêm mới thành công");
                        Close();
                    }
                } 
                else
                {
                    txtMa.ReadOnly = true;
                    var Qr = $"Update dbo.GroupDTuong Set GroupDTuong_ten = N'{txtTen.Text}' where GroupDTuong_id = '{idGrid}'";
                    SqlCommand InsertSQL = new SqlCommand(Qr, Conn);
                    InsertSQL.ExecuteNonQuery();
                    XtraMessageBox.Show("Sửa thành công");
                    Close();
                }

            }
            catch (Exception e1)
            {
                XtraMessageBox.Show(e1.Message);
                return;
            }

        }

        private void FormGroupDtuong_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.Editmode.Contains("2"))
                {
                    if (!string.IsNullOrEmpty(idGrid))
                    {
                        DataTable _data = LoadData.bindingGroupDTuong(idGrid);
                        if (_data.Rows.Count > 0)
                        {
                            foreach (DataRow item in _data.Rows)
                            {
                                txtMa.Text = item["GroupDTuong_ma"].ToString();
                                txtTen.Text = item["GroupDTuong_ten"].ToString();
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn mã cần thao tác");
                        Close();
                    }
                }
            } 
            catch (Exception e2)
            {
                XtraMessageBox.Show(e2.Message);
                return;
            }
        }
    }
}