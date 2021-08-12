using DataUseVaccine.Services;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace DataUseVaccine.DetailForm
{
    public partial class infoForm : DevExpress.XtraEditors.XtraForm
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int i = 0;
            splashScreenManager2.ShowWaitForm();
            for (i = 0; i < 10000; i++)
            {
                i++;
                var a = i.ToString();
                if (i.ToString().Equals("9999"))
                {
                    Thread.Sleep(9999);
                }
            }
            splashScreenManager2.CloseWaitForm();
            var tu_ngay = bunifuDatePicker1.Value.ToString("yyyy-MM-dd");
            var den_ngay = bunifuDatePicker2.Value.ToString("yyyy-MM-dd");
            var check1 = bunifuDatePicker1.Value.Date;
            var check2 = bunifuDatePicker2.Value.Date;
            if(check2 < check1)
            {
                MessageBox.Show("Lỗi quy luật chọn ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                var DanhMucQr = $"SELECT count(*) as soluong FROM dbo.DTuong WHERE  CONVERT(DATE, isTimeAdd) between '{tu_ngay}' and '{den_ngay}' ";
                DataTable DanhMuc = PublicTable.ReportTable(DanhMucQr);
                if(DanhMuc.Rows.Count > 0)
                {
                    foreach (DataRow item in DanhMuc.Rows)
                    {
                        txtDanhMuc.Text = item["soluong"].ToString();
                    }
                }
                var Tiem1Qr = $"SELECT count(*) as tiem1 FROM dbo.TrangChu WHERE TimeTiem1 is not null AND  CONVERT(DATE, timeNew) between '{tu_ngay}' and '{den_ngay}'";
                DataTable Tiem1 = PublicTable.ReportTable(Tiem1Qr);
                if (Tiem1.Rows.Count > 0)
                {
                    foreach (DataRow item1 in Tiem1.Rows)
                    {
                        txtTiem1.Text = !string.IsNullOrEmpty(item1["tiem1"].ToString()) ? item1["tiem1"].ToString() : "0";  
                    }
                }

                var Tiem2Qr = $"SELECT count(*) as lan2 FROM dbo.TrangChu WHERE TimeTiem2 is not null AND CONVERT(DATE, timeNew) between '{tu_ngay}' and '{den_ngay}'";
                DataTable Tiem2 = PublicTable.ReportTable(Tiem2Qr);
                if (Tiem2.Rows.Count > 0)
                {
                    foreach (DataRow item2 in Tiem2.Rows)
                    {
                        TxtTiem2.Text = !string.IsNullOrEmpty(item2["lan2"].ToString()) ? item2["lan2"].ToString() : "0";
                    }
                }
            }
        }
    }
}