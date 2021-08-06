
using DataUseVaccine.Services;
using DevExpress.XtraEditors;

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataUseVaccine.FormDetail
{
    public partial class FormData : DevExpress.XtraEditors.XtraForm
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

        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private string idGrid;
        private string SaveTime;
        private DateTime _time;
        public FormData(string ID, DateTime time_)
        {
            idGrid = ID;
            _time = time_;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AutoSize = false;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void FormData_Load(object sender, EventArgs e)
        {
            // Load thông tin khi bật form với điều kiện null
            LoadDoiTuong("");
            LoadVx("");
            LoadBsy("");
            if (Properties.Settings.Default.Editmode.Contains("1"))
            {
                txtTimeTiem1.Value = _time;
            }
        }

        private void LoadDoiTuong(string a)
        {
            // Đẩy thông tin vào combobox chọn Đối tượng
            searchLookUpEdit2.Properties.DataSource = infoData.DoiTuong(a);
        }
        private void LoadVx(string a)
        {
            // Đẩy thông tin vào combobox chọn Vắc xin
            searchLookUpEdit3.Properties.DataSource = GrData.Vx(a);
            searchLookUpEdit4.Properties.DataSource = GrData.Vx(a);
        }
        private void LoadBsy(string a)
        {
            // Đẩy thông tin vào combobox chọn Bác sỹ
            searchLookUpEdit1.Properties.DataSource = GrData.Bsy(a);
            searchLookUpEdit5.Properties.DataSource = GrData.Bsy(a);
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            // Load Thông tin bệnh nhân
            var a = txtMaDT.Text.Trim();
            LoadDoiTuong(a);
        }

        private void vx_Ma1_TextChanged(object sender, EventArgs e)
        {
            // Load thông tin Vắc xin form 1
            var a = vx_Ma1.Text.Trim();
            LoadVx(a);
        }
        private void vx_ma2_TextChanged(object sender, EventArgs e)
        {
            // Load thông tin vắc xin form 2
            var a = vx_ma2.Text.Trim();
            LoadVx(a);
        }
        private void txttenBsy1_TextChanged(object sender, EventArgs e)
        {
            // Load Bác sỹ form 1
            var a = txttenBsy1.Text.Trim();
            LoadBsy(a);
        }
        private void txttenBsy2_TextChanged(object sender, EventArgs e)
        {
            // Load Bác sỹ form 2
            var a = txttenBsy2.Text.Trim();
            LoadBsy(a);
        }
        private void searchLookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            // Set thông tin Vắc xin form 1 khi click vào combobox 
            // Thay đổi theo thông tin click
            ThongTinVx selectDv = gridView3.GetFocusedRow() as ThongTinVx;
            if (selectDv != null)
            {
                vx_Ma1.Text = NullToString(selectDv.vx_ma.Trim());
                vx_ten1.Text = NullToString(selectDv.vx_ten.Trim());
                vx_nsx1.Text = NullToString(selectDv.vx_nsx.Trim());
                vx_location1.Text = NullToString(selectDv.vx_location.Trim());
                vx_lo1.Text = NullToString(selectDv.vx_lo.Trim());
                txtTimeNhap1.Text = selectDv.vx_ngayNhap.ToString();
                
            }
        }

        private void searchLookUpEdit4_EditValueChanged(object sender, EventArgs e)
        {
            // Set thông tin Vắc xin form 2 khi click vào combobox 
            // Thay đổi theo thông tin click
            ThongTinVx selectDv = gridView4.GetFocusedRow() as ThongTinVx;
            if (selectDv != null)
            {
                vx_ma2.Text = NullToString(selectDv.vx_ma.Trim());
                vx_ten2.Text = NullToString(selectDv.vx_ten.Trim());
                vx_nsx2.Text = NullToString(selectDv.vx_nsx.Trim());
                vx_location2.Text = NullToString(selectDv.vx_location.Trim());
                vx_lo2.Text = NullToString(selectDv.vx_lo.Trim());
                txtTimeNhap2.Text = selectDv.vx_ngayNhap.ToString();
            }
        }



        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            // Set thông tin Bác sỹ form 1 khi click vào combobox 
            // Thay đổi theo thông tin click
            ThongTinBsy selectDv = gridView1.GetFocusedRow() as ThongTinBsy;
            if (selectDv != null)
            {
                txttenBsy1.Text = NullToString(selectDv.DMBsy_Ten.Trim());
                txtDcBsy1.Text = NullToString(selectDv.DMBsy_diaChi);
                txtChuyenKhoa1.Text = NullToString(selectDv.DMBsy_chuyenKhoa);
                txtExp1.Text = NullToString(selectDv.DMBsy_Exp);
                txtPhone1.Text = NullToString(selectDv.DMBsy_Phone.Trim());
                txtbcap1.Text = NullToString(selectDv.DMBsy_bangCap);
            }
        }
        private void searchLookUpEdit5_EditValueChanged(object sender, EventArgs e)
        {
            // Set thông tin Bác sỹ form 1 khi click vào combobox 
            // Thay đổi theo thông tin click
            ThongTinBsy selectDv = gridView5.GetFocusedRow() as ThongTinBsy;
            if (selectDv != null)
            {
                txttenBsy2.Text = NullToString(selectDv.DMBsy_Ten.Trim());
                txtDcBsy2.Text = NullToString(selectDv.DMBsy_diaChi);
                txtChuyenKhoa2.Text = NullToString(selectDv.DMBsy_chuyenKhoa);
                txtExp2.Text = NullToString(selectDv.DMBsy_Exp);
                txtPhone2.Text = NullToString(selectDv.DMBsy_Phone.Trim());
                txtbcap2.Text = NullToString(selectDv.DMBsy_bangCap);
            }
        }
        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            // Set thông tin Bệnh nhân form 1 khi click vào combobox 
            // Thay đổi theo thông tin click
            ThongTinDataDoiTuong selectDv = gridView2.GetFocusedRow() as ThongTinDataDoiTuong;
            if (selectDv != null)
            {
                SaveTime = selectDv.DTuong_nsinh.ToString();
                txtMaDT.Text = NullToString(selectDv.DTuong_ma.Trim());
                txtTenDT.Text = NullToString(selectDv.DTuong_ten.Trim());
                txtNamSinh.Text = selectDv.DTuong_nsinh.ToString("dd - MM - yyyy");
                lblGioiTinh.Text = NullToString(selectDv.DTuong_GTinh.Trim());
                txtDvctac.Text = NullToString(selectDv.DTuong_DVCtac.Trim());
                txtdienthoai.Text = NullToString(selectDv.DTuong_SDT.Trim());
                txtCCCD.Text = NullToString(selectDv.DTuong_CCCD.Trim());
                txttheBH.Text = NullToString(selectDv.DTuong_BHYT.Trim());
                txtNhomUT.Text = NullToString(selectDv.DTuong_MaNhom.Trim());
                txtTinh.Text = NullToString(selectDv.DTuong_Tinh.Trim());
                txtCodeTinh.Text = NullToString(selectDv.DTuong_TinhCode.Trim());
                txtQuan.Text = NullToString(selectDv.DTuong_Quan.Trim());
                txtCodeQuan.Text = NullToString(selectDv.DTuong_QuanCode.Trim());
                txtXa.Text = NullToString(selectDv.DTuong_Xa.Trim());
                txtCodeXa.Text =  NullToString(selectDv.DTuong_XaCode);
                txtDcChiTiet.Text = NullToString(selectDv.DTuong_DCCtiet);
            }
        }
        static string NullToString(object Value)
        {
            // Check null value đẩy vào khoảng trống
            return Value == null ? "" : Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                if (Properties.Settings.Default.Editmode.Contains("1"))
                {
                    try
                    {
                        if(string.IsNullOrEmpty(txtMaDT.Text.Trim()) || string.IsNullOrEmpty(vx_Ma1.Text.Trim()) || string.IsNullOrEmpty(txttenBsy1.Text.Trim()) || string.IsNullOrEmpty(txtPhone1.Text.Trim()))
                        {
                            XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc");
                        } else
                        {

                            DateTime b = DateTime.Parse(txtTimeTiem1.Text);


                            var Qr = $"INSERT INTO dbo.TrangChu VALUES  ( N'{idGrid}','{txtMaDT.Text.Trim()}' , N'{txtTenDT.Text.Trim()}' , " +
                                $"'{SaveTime}' , N'{lblGioiTinh.Text.Trim()}' ,N'{txtDvctac.Text.Trim()}' , " +
                                $"N'{txtdienthoai.Text.Trim()}' , N'{txtCCCD.Text.Trim()}' , N'{txttheBH.Text.Trim()}' , " +
                                $"N'{txtNhomUT.Text.Trim()}' , N'{txtTinh.Text.Trim()}' , N'{txtCodeTinh.Text.Trim()}' , " +
                                $"N'{txtQuan.Text.Trim()}' , N'{txtCodeQuan.Text.Trim()}' , N'{txtXa.Text.Trim()}' , " +
                                $"N'{txtCodeXa.Text.Trim()}' , N'{txtDcChiTiet.Text}' , N'{vx_Ma1.Text.Trim()}' , N'{vx_ten1.Text.Trim()}' , " +
                                $"N'{vx_nsx1.Text.Trim()}' , N'{vx_location1.Text.Trim()}' , N'{vx_lo1.Text.Trim()}' ," +
                                $"'{txtTimeNhap1.Text.Trim()}' , 0 , N'{txttenBsy1.Text.Trim()}' , N'{txtDcBsy1.Text.Trim()}' ," +
                                $"N'{txtChuyenKhoa1.Text.Trim()}' , N'{txtExp1.Text.Trim()}' ,N'{txtPhone1.Text.Trim()}' , " +
                                $"N'{txtbcap1.Text.Trim()}' , N'' , N'' , N'' , N'' , N'' , N'' , 0 ,N'' ,N'' , N'' , N'' , N'' , " +
                                $"N'' , '{b}' ,NULL ,GETDATE() , NULL )";
                            SqlCommand InsertSQL = new SqlCommand(Qr, _conn);
                            InsertSQL.ExecuteNonQuery();
                            XtraMessageBox.Show("Thêm mới thành công");
                            Close();
                        }
                    }
                    catch (Exception ev)
                    {
                        XtraMessageBox.Show(ev.Message);
                        return;
                    }
                }
                else
                {
                    try
                    {

                    }
                    catch (Exception ev)
                    {
                        XtraMessageBox.Show(ev.Message);
                        return;
                    }
                }

            } 
            catch (Exception e1)
            {
                XtraMessageBox.Show(e1.Message);
                return;
            }
            
        }

        
    }
}