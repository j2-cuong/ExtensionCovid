using BigAds.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BigAds.FormDetail
{
    public partial class FormDtuong : DevExpress.XtraEditors.XtraForm
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
        private string idGrid;
        public static string Conn = Properties.Settings.Default.ConnectionString;
        public FormDtuong(string ID)
        {
            MaximizeBox = false;
            AutoSize = false;
            InitializeComponent();
            idGrid = ID;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            searchLookUpEdit1.Visible = false;
            searchLookUpEdit2.Visible = false;
            if (Properties.Settings.Default.Editmode.Contains("2"))
            {
                txtMaDT.ReadOnly = true;
            } else
            {
                txtMaDT.ReadOnly = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(Conn);
            if(_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            try
            {
                if (Properties.Settings.Default.Editmode.Contains("1"))
                {
                    if (string.IsNullOrEmpty(txtMaDT.Text.Trim()))
                    {
                        XtraMessageBox.Show("Mã đối tượng không được để trống");
                    }
                    else if (string.IsNullOrEmpty(txtTenDT.Text.Trim()))
                    {
                        XtraMessageBox.Show("Tên đối tượng không được để trống");
                    }
                    else if (txtNam.Checked == false && txtNu.Checked == false)
                    {
                        XtraMessageBox.Show("Giới tính không được để trống");
                    }
                    else if (string.IsNullOrEmpty(txtdienthoai.Text.Trim()))
                    {
                        XtraMessageBox.Show("Điện thoại không được để trống");
                    }
                    else if (string.IsNullOrEmpty(txtTinh.Text.Trim()) || string.IsNullOrEmpty(txtCodeTinh.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp tỉnh");
                    }
                    else if (string.IsNullOrEmpty(txtQuan.Text.Trim()) || string.IsNullOrEmpty(txtCodeQuan.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp quận huyện");
                    }
                    else if (string.IsNullOrEmpty(txtXa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp xã");
                    }
                    else if (string.IsNullOrEmpty(txtNhomUT.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn nhóm đối tượng");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtNhomUT.Text.Trim()))
                        {
                            var Qr = $"SELECT * FROM dbo.GroupDTuong WHERE GroupDTuong_ma= N'{txtNhomUT.Text.Trim()}' ";
                            DataTable check_ = new DataTable();
                            SqlDataAdapter ad = new SqlDataAdapter(Qr, _conn);
                            ad.Fill(check_);
                            if(check_.Rows.Count > 0)
                            {
                                var NamSinh = txtNamSinh.Value.ToString("yyyy-MM-dd");
                                var gt = "";
                                if(txtNam.Checked == true && txtNu.Checked == true)
                                {
                                    XtraMessageBox.Show("Chỉ được phép chọn 1 giới tính");
                                    return;
                                } else
                                {
                                    if(txtNam.Checked == true)
                                    {
                                        gt = "Nam";
                                    } else
                                    {
                                        gt = "Nữ";
                                    }
                                   
                                }

                                var Que = "INSERT INTO dbo.DTuong VALUES  ( NEWID() ," +
                                    $"N'{txtMaDT.Text.Trim()}' , " +
                                    $"N'{txtTenDT.Text.Trim()}' , " +
                                    $"'{NamSinh}' , " +
                                    $"{gt} , " +
                                    $"N'{txtDvctac.Text.Trim()}' , " +
                                    $"N'{txtdienthoai.Text.Trim()}' ," +
                                    $"N'{txtCCCD.Text.Trim()}' ," +
                                    $"N'{txttheBH.Text.Trim()}' ," +
                                    $"N'{txtNhomUT.Text.Trim()}' ," +
                                    $"N'{txtTinh.Text.Trim()}' , " +
                                    $"N'{txtCodeTinh.Text.Trim()}' ," +
                                    $"N'{txtQuan.Text.Trim()}' , " +
                                    $"N'{txtCodeQuan.Text.Trim()}' , " +
                                    $"N'{txtXa.Text.Trim()}' , " +
                                    $"N'{txtCodeXa.Text.Trim()}' , " +
                                    $"N'{txtDcChiTiet.Text.Trim()}' , " +
                                    $"GETDATE() )";
                                SqlCommand InsertSQL = new SqlCommand(Que, _conn);
                                InsertSQL.ExecuteNonQuery();
                                XtraMessageBox.Show("Tạo thành công");
                                Close();
                            }
                            else
                            {
                                XtraMessageBox.Show("Mã nhóm đối tượng chưa được tạo");
                            }
                        }
                        
                    }
                    

                }
                if (Properties.Settings.Default.Editmode.Contains("2"))
                {

                    if (string.IsNullOrEmpty(txtTenDT.Text.Trim()))
                    {
                        XtraMessageBox.Show("Tên đối tượng không được để trống");
                    }
                    else if (txtNam.Checked == false && txtNu.Checked == false)
                    {
                        XtraMessageBox.Show("Giới tính không được để trống");
                    }
                    else if (string.IsNullOrEmpty(txtdienthoai.Text.Trim()))
                    {
                        XtraMessageBox.Show("Điện thoại không được để trống");
                    }
                    else if (string.IsNullOrEmpty(txtTinh.Text.Trim()) || string.IsNullOrEmpty(txtCodeTinh.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp tỉnh");
                    }
                    else if (string.IsNullOrEmpty(txtQuan.Text.Trim()) || string.IsNullOrEmpty(txtCodeQuan.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp quận huyện");
                    }
                    else if (string.IsNullOrEmpty(txtXa.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đơn vị hình chính cấp xã");
                    }
                    else if (string.IsNullOrEmpty(txtNhomUT.Text.Trim()))
                    {
                        XtraMessageBox.Show("Bạn chưa chọn nhóm đối tượng");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtNhomUT.Text.Trim()))
                        {
                            var Qr = $"SELECT * FROM dbo.GroupDTuong WHERE GroupDTuong_ma= N'{txtNhomUT.Text.Trim()}' ";
                            DataTable check_ = new DataTable();
                            SqlDataAdapter ad = new SqlDataAdapter(Qr, _conn);
                            ad.Fill(check_);
                            if (check_.Rows.Count > 0)
                            {
                                var NamSinh = txtNamSinh.Value.ToString("yyyy-MM-dd");
                                var gt = "";
                                if (txtNam.Checked == true && txtNu.Checked == true)
                                {
                                    XtraMessageBox.Show("Chỉ được phép chọn 1 giới tính");
                                    return;
                                }
                                else
                                {
                                    if (txtNam.Checked == true)
                                    {
                                        gt = "Nam";
                                    }
                                    else
                                    {
                                        gt = "Nữ";
                                    }

                                }

                                var Que = "Update dbo.DTuong set" +
                                    $" DTuong_ten= N'{txtTenDT.Text.Trim()}' , " +
                                    $" DTuong_nsinh= '{NamSinh}' , " +
                                    $" DTuong_GTinh= N'{gt}' , " +
                                    $" DTuong_DVCtac= N'{txtDvctac.Text.Trim()}' , " +
                                    $" DTuong_SDT= N'{txtdienthoai.Text.Trim()}' ," +
                                    $" DTuong_CCCD= N'{txtCCCD.Text.Trim()}' ," +
                                    $" DTuong_BHYT= N'{txttheBH.Text.Trim()}' ," +
                                    $" DTuong_MaNhom= N'{txtNhomUT.Text.Trim()}' ," +
                                    $" DTuong_Tinh= N'{txtTinh.Text.Trim()}' , " +
                                    $" DTuong_TinhCode= N'{txtCodeTinh.Text.Trim()}' ," +
                                    $" DTuong_Quan= N'{txtQuan.Text.Trim()}' , " +
                                    $" DTuong_QuanCode= N'{txtCodeQuan.Text.Trim()}' , " +
                                    $" DTuong_Xa= N'{txtXa.Text.Trim()}' , " +
                                    $" DTuong_XaCode= N'{txtCodeXa.Text.Trim()}' , " +
                                    $" DTuong_DCCtiet= N'{txtDcChiTiet.Text.Trim()}' , " +
                                    $" isTimeAdd= GETDATE() " +
                                    $"where DTuong_id = '{idGrid}'";
                                SqlCommand InsertSQL = new SqlCommand(Que, _conn);
                                InsertSQL.ExecuteNonQuery();
                                XtraMessageBox.Show("Sửa thành công");
                                Close();
                            }
                            else
                            {
                                XtraMessageBox.Show("Mã nhóm đối tượng chưa được tạo");
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
            
            
        }

        private void FormDtuong_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Editmode.Contains("2"))
            {
                DataTable _data = LoadData.bindingDTuong(idGrid);
                if(_data.Rows.Count > 0)
                {
                    foreach (DataRow item in _data.Rows)
                    {
                        txtMaDT.Text = item["DTuong_ma"].ToString();
                        txtTenDT.Text = item["DTuong_ten"].ToString();
                        txtNamSinh.Text = DateTime.Parse(item["DTuong_nsinh"].ToString()).ToString("yyyy-MM-dd");

                        if (item["DTuong_GTinh"].ToString().Contains("Nam"))
                        {
                            txtNam.Checked = true;
                            txtNu.Checked = false;
                        } else
                        {
                            txtNu.Checked = true;
                            txtNam.Checked = false;
                        }
                        


                        txtDvctac.Text = !string.IsNullOrEmpty(item["DTuong_DVCtac"].ToString()) ? item["DTuong_DVCtac"].ToString() : null;
                        txtdienthoai.Text = !string.IsNullOrEmpty(item["DTuong_SDT"].ToString()) ? item["DTuong_SDT"].ToString() : null;
                        txtCCCD.Text = !string.IsNullOrEmpty(item["DTuong_CCCD"].ToString()) ? item["DTuong_CCCD"].ToString() : null;
                        txttheBH.Text = !string.IsNullOrEmpty(item["DTuong_BHYT"].ToString()) ? item["DTuong_BHYT"].ToString() : null;
                        txtNhomUT.Text = !string.IsNullOrEmpty(item["DTuong_MaNhom"].ToString()) ? item["DTuong_MaNhom"].ToString() : null;
                        txtTinh.Text = !string.IsNullOrEmpty(item["DTuong_Tinh"].ToString()) ? item["DTuong_Tinh"].ToString() : null;
                        txtCodeTinh.Text = !string.IsNullOrEmpty(item["DTuong_TinhCode"].ToString()) ? item["DTuong_TinhCode"].ToString() : null;
                        txtQuan.Text = !string.IsNullOrEmpty(item["DTuong_Quan"].ToString()) ? item["DTuong_Quan"].ToString() : null;
                        txtCodeQuan.Text = !string.IsNullOrEmpty(item["DTuong_QuanCode"].ToString()) ? item["DTuong_QuanCode"].ToString() : null;
                        txtXa.Text = !string.IsNullOrEmpty(item["DTuong_Xa"].ToString()) ? item["DTuong_Xa"].ToString() : null;
                        if (!string.IsNullOrEmpty(item["DTuong_XaCode"].ToString()))
                        {
                            txtCodeXa.Text = item["DTuong_XaCode"].ToString();
                        } else
                        {
                            txtCodeXa.Text = null;

                        }
                        txtDcChiTiet.Text = !string.IsNullOrEmpty(item["DTuong_DCCtiet"].ToString()) ? item["DTuong_DCCtiet"].ToString() : null;
                    }
                } else
                {
                    XtraMessageBox.Show("Vui lòng thoát form và bấm tải lại dữ liệu vì không tìm thấy mã ĐT đang thao tác");
                    return;
                }
                
            }
            txtValue.Properties.DataSource = dvhc.GetTinhTpho();
            txtValue.Properties.DisplayMember = Tinh.ToString();
            txtValue.Properties.ValueMember = Tinh.ToString();
        }
        private void txtValue_EditValueChanged(object sender, EventArgs e)
        {
            ListDonVi selectDv = searchLookUpEdit1View.GetFocusedRow() as ListDonVi;
            if (selectDv != null)
            {
                txtTinh.Text = selectDv.Tinh.ToString();
                txtCodeTinh.Text = selectDv.TinhCode.ToString();
                txtValue.EditValue = selectDv.Tinh.ToString();
                searchLookUpEdit1.Visible = true;
                var a = selectDv.Tinh.ToString();
                var b = selectDv.TinhCode.ToString();
                txtQuan.Text = null;
                txtCodeQuan.Text = null;
                txtXa.Text = null;
                txtCodeXa.Text = null;

                searchLookUpEdit1.Properties.DataSource = dvhc.GetQuanHuyen(a,b);
                searchLookUpEdit1.Properties.DisplayMember = Quan.ToString();
                searchLookUpEdit1.Properties.ValueMember = Quan.ToString();
            }
            else
            {
                txtTinh.Text = null;
                txtCodeTinh.Text = null;
                txtValue.EditValue = null;
                searchLookUpEdit1.Visible = false;
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ListDonVi selectDv = gridView3.GetFocusedRow() as ListDonVi;
            if (selectDv != null)
            {
                txtQuan.Text = selectDv.Quan.ToString();
                txtCodeQuan.Text = selectDv.QuanCode.ToString();
                searchLookUpEdit2.Visible = true;

                var c = selectDv.Quan.ToString();
                var d = selectDv.QuanCode.ToString();
                txtXa.Text = null;
                txtCodeXa.Text = null;

                searchLookUpEdit2.Properties.DataSource = dvhc.GetXaPhuong(c, d);
                searchLookUpEdit2.Properties.DisplayMember = Quan.ToString();
                searchLookUpEdit2.Properties.ValueMember = Quan.ToString();

            }
            else
            {
                txtQuan.Text = null;
                txtCodeQuan.Text = null;
                searchLookUpEdit2.Visible = false;
            }
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            ListDonVi selectDv = gridView1.GetFocusedRow() as ListDonVi;
            if (selectDv != null)
            {
                if(string.IsNullOrEmpty(selectDv.Xa.ToString()) )
                {
                    txtXa.Text = null;
                } 
                else
                {
                    txtXa.Text = selectDv.Xa.ToString();
                }
                if (string.IsNullOrEmpty(selectDv.XaCode.ToString()))
                {
                    txtCodeXa.Text = null;
                }
                else
                {
                    txtCodeXa.Text = selectDv.XaCode.ToString();
                }
            }
            else
            {
                txtXa.Text = null;
                txtCodeXa.Text = null;
            }
        }
    }
}