using DataUseVaccine.Services;
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

namespace DataUseVaccine.FormDetail
{
    public partial class FormVaxcin : DevExpress.XtraEditors.XtraForm
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
        public FormVaxcin(string ID)
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuTextBox8_TextChanged(object sender, EventArgs e)
        {
            int a;
            bool isValidInt = int.TryParse(vx_slNhap.Text, out a);
            if(isValidInt == false)
            {
                XtraMessageBox.Show("Định đạng nhập vào không phải dạng số");
            }
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
                    if (string.IsNullOrEmpty(vx_ma.Text.Trim()))
                    {
                        XtraMessageBox.Show("Mã VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_ten.Text.Trim()))
                    {
                        XtraMessageBox.Show("Tên VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_nsx.Text.Trim()))
                    {
                        XtraMessageBox.Show("Nhà sản xuất không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_location.Text.Trim()))
                    {
                        XtraMessageBox.Show("Nước sx VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_lo.Text.Trim()))
                    {
                        XtraMessageBox.Show("Số lô không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_slNhap.Text.Trim()))
                    {
                        XtraMessageBox.Show("Số lượng nhập không được để trống");
                    }
                    else
                    {
                        var _time = bunifuDatePicker1.Value.ToString();
                        var _time2 = txtNgayNhap.Value.ToString();
                        var Qr = $"INSERT INTO dbo.VacXin VALUES  ( NEWID() , " +
                            $"N'{vx_ma.Text.Trim()}' , " +
                            $"N'{vx_ten.Text.Trim()}' , " +
                            $"N'{vx_nsx.Text.Trim()}' , " +
                            $"N'{vx_location.Text.Trim()}' , " +
                            $"N'{vx_lo.Text.Trim()}' , " +
                            $"N'{_time2}' ," +
                            $"N'{_time}' ," +
                            $"{vx_slNhap.Text.Trim()} , " +
                            $"0 )";
                        SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Tạo mới thành công");
                        Close();
                    }
                }
                else
                {

                    SqlConnection _conn = new SqlConnection(Conn);
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    if (string.IsNullOrEmpty(vx_ma.Text.Trim()))
                    {
                        XtraMessageBox.Show("Mã VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_ten.Text.Trim()))
                    {
                        XtraMessageBox.Show("Tên VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_nsx.Text.Trim()))
                    {
                        XtraMessageBox.Show("Nhà sản xuất không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_location.Text.Trim()))
                    {
                        XtraMessageBox.Show("Nước sx VX không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_lo.Text.Trim()))
                    {
                        XtraMessageBox.Show("Số lô không được để trống");
                    }
                    else if (string.IsNullOrEmpty(vx_slNhap.Text.Trim()))
                    {
                        XtraMessageBox.Show("Số lượng nhập không được để trống");
                    }
                    else
                    {
                        var _time = bunifuDatePicker1.Value.ToString();
                        var _time2 = txtNgayNhap.Value.ToString();
                        var Qr = $"Update dbo.VacXin set   " +
                            $"vx_ten=N'{vx_ten.Text.Trim()}' , " +
                            $"vx_nsx=N'{vx_nsx.Text.Trim()}' , " +
                            $"vx_location=N'{vx_location.Text.Trim()}' , " +
                            $"vx_lo=N'{vx_lo.Text.Trim()}' , " +
                            $"vx_ngayNhap=N'{_time2}' ," +
                            $"vx_hsd=N'{_time}' ," +
                            $"vx_slNhap={vx_slNhap.Text.Trim()} , ";
                        SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                        InsertSQL.ExecuteNonQuery();
                        XtraMessageBox.Show("Sửa thành công");
                        Close();
                    }

                }
            }
            catch (Exception evv)
            {
                XtraMessageBox.Show(evv.Message);
                return;
            }
        }

        private void FormVaxcin_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.Editmode.Contains("2"))
                {
                    if (!string.IsNullOrEmpty(idGrid))
                    {
                        DataTable _data = LoadData.bindingVx(idGrid);
                        foreach (DataRow item in _data.Rows)
                        {
                            vx_ma.Text = !string.IsNullOrEmpty(item["vx_ma"].ToString()) ? item["vx_ma"].ToString() : null;
                            vx_ten.Text = !string.IsNullOrEmpty(item["vx_ten"].ToString()) ? item["vx_ten"].ToString() : null;
                            vx_nsx.Text = !string.IsNullOrEmpty(item["vx_nsx"].ToString()) ? item["vx_nsx"].ToString() : null;
                            vx_location.Text = !string.IsNullOrEmpty(item["vx_location"].ToString()) ? item["vx_location"].ToString() : null;
                            vx_lo.Text = !string.IsNullOrEmpty(item["vx_lo"].ToString()) ? item["vx_lo"].ToString() : null;
                            txtNgayNhap.Text = !string.IsNullOrEmpty(item["vx_ngayNhap"].ToString()) ? item["vx_ngayNhap"].ToString() : null;
                            bunifuDatePicker1.Text = !string.IsNullOrEmpty(item["vx_hsd"].ToString()) ? item["vx_hsd"].ToString() : null;
                            vx_slNhap.Text = !string.IsNullOrEmpty(item["vx_slNhap"].ToString()) ? item["vx_slNhap"].ToString() : null;
                        }
                    } else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn mã cần thao tác");
                        Close();
                    }
                    
                }
            } catch (Exception e2)
            {
                XtraMessageBox.Show(e2.Message);
                return;
            }
            
        }
    }
}