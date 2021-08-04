using BigAds.Services;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigAds.FormDetail
{
    public partial class FormBsy : DevExpress.XtraEditors.XtraForm
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
    );
        private string idGrid ;
        public static string Conn = Properties.Settings.Default.ConnectionString;
        public FormBsy(string ID)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AutoSize = false;
            InitializeComponent();
            idGrid = ID;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.Editmode.Contains("1"))
                {
                    SqlConnection _conn = new SqlConnection(Conn);
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    if (string.IsNullOrEmpty(txtmBsy.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập Mã Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txttenBsy.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập Tên Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txtChuyenKhoa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập chuyên khoa Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập điện thoại liên hệ Bác sỹ");
                    }
                    else
                    {
                        var Qr = $"INSERT INTO dbo.DMBsy VALUES  ( NEWID() , " +
                            $" N'{txtmBsy.Text.Trim()}' ," +
                            $" N'{txttenBsy.Text.Trim()}' , " +
                            $" N'{txtDcBsy.Text.Trim()}' , " +
                            $" N'{txtChuyenKhoa.Text.Trim()}' , " +
                            $" N'{txtExp.Text.Trim()}' , " +
                            $" N'{txtPhone.Text.Trim()}', " +
                            $" N'{txtbcap.Text.Trim()}')";
                        SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Thêm mới thành công");
                        Close();
                    }
                } 
                else
                {
                    txtmBsy.ReadOnly = true;
                    SqlConnection _conn = new SqlConnection(Conn);
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    if (string.IsNullOrEmpty(txtmBsy.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập Mã Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txttenBsy.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập Tên Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txtChuyenKhoa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập chuyên khoa Bác sỹ");
                    }
                    else if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa nhập điện thoại liên hệ Bác sỹ");
                    }
                    else
                    {
                        var Qr = $"Update dbo.DMBsy SET " +
                            $" DMBsy_Ten=N'{txttenBsy.Text.Trim()}' , " +
                            $" DMBsy_diaChi=N'{txtDcBsy.Text.Trim()}' , " +
                            $" DMBsy_chuyenKhoa=N'{txtChuyenKhoa.Text.Trim()}' , " +
                            $" DMBsy_Exp=N'{txtExp.Text.Trim()}' , " +
                            $" DMBsy_Phone=N'{txtPhone.Text.Trim()}', " +
                            $" DMBsy_bangCap=N'{txtbcap.Text.Trim()}'" +
                            $"where DMBsy_id = '{idGrid}'";
                        SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Sửa thành công");
                        Close();
                    }

                }
            } catch (Exception ecc)
            {
                XtraMessageBox.Show(ecc.Message);
                return;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBsy_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Editmode.Contains("2"))
            {
                DataTable _data = LoadData.bindingBsy(idGrid);
                foreach (DataRow item in _data.Rows)
                {
                    txtmBsy.Text = !string.IsNullOrEmpty(item["DMBsy_Ma"].ToString()) ? item["DMBsy_Ma"].ToString() : null;
                    txttenBsy.Text = !string.IsNullOrEmpty(item["DMBsy_Ten"].ToString()) ? item["DMBsy_Ten"].ToString() : null;
                    txtDcBsy.Text = !string.IsNullOrEmpty(item["DMBsy_diaChi"].ToString()) ? item["DMBsy_diaChi"].ToString() : null;
                    txtChuyenKhoa.Text = !string.IsNullOrEmpty(item["DMBsy_chuyenKhoa"].ToString()) ? item["DMBsy_chuyenKhoa"].ToString() : null;
                    txtExp.Text = !string.IsNullOrEmpty(item["DMBsy_Exp"].ToString()) ? item["DMBsy_Exp"].ToString() : null;
                    txtPhone.Text = !string.IsNullOrEmpty(item["DMBsy_Phone"].ToString()) ? item["DMBsy_Phone"].ToString() : null;
                    txtbcap.Text = !string.IsNullOrEmpty(item["DMBsy_bangCap"].ToString()) ? item["DMBsy_bangCap"].ToString() : null;
                }
            }
        }
    }
}