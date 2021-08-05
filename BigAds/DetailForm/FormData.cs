
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
            _conn.Open();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void FormData_Load(object sender, EventArgs e)
        {
            LoadPopup("");
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            ThongTinDataDoiTuong selectDv = gridView2.GetFocusedRow() as ThongTinDataDoiTuong;
            if (selectDv != null)
            {
                txtMaDT.Text = selectDv.DTuong_ma.Trim().ToString();
                txtTenDT.Text = selectDv.DTuong_ten.Trim().ToString();
                txtNamSinh.Text = selectDv.DTuong_nsinh.ToString("dd'/'MM'/'yyyy");
                lblGioiTinh.Text = selectDv.DTuong_GTinh.Trim().ToString();
                txtDvctac.Text = selectDv.DTuong_DVCtac.Trim().ToString();
                txtdienthoai.Text = selectDv.DTuong_SDT.Trim().ToString();
                txtCCCD.Text = selectDv.DTuong_CCCD.Trim().ToString();
                txttheBH.Text = selectDv.DTuong_BHYT.Trim().ToString();
                txtNhomUT.Text = selectDv.DTuong_MaNhom.Trim().ToString();
                txtTinh.Text = selectDv.DTuong_Tinh.Trim().ToString();
                txtCodeTinh.Text = selectDv.DTuong_TinhCode.Trim().ToString();
                txtQuan.Text = selectDv.DTuong_Quan.Trim().ToString();
                txtCodeQuan.Text = selectDv.DTuong_QuanCode.Trim().ToString();
                txtXa.Text = selectDv.DTuong_Xa.Trim().ToString();
                txtCodeXa.Text = selectDv.DTuong_XaCode.Trim().ToString();
                txtDcChiTiet.Text = selectDv.DTuong_DCCtiet.Trim().ToString();
            }
        }
        private void LoadPopup(string a)
        {
            searchLookUpEdit2.Properties.DataSource = infoData.DoiTuong(a);
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            var a = txtMaDT.Text.Trim();
            LoadPopup(a);
        }
    }
}