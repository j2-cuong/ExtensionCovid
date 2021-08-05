
using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DataUseVaccine.Frm
{
    public partial class Base : DevExpress.XtraEditors.XtraForm
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
        public Base()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ServerSQL = txtServer.Text.TrimEnd().TrimStart().Trim();
            var UserSQL = txtUserSQL.Text.TrimEnd().TrimStart().Trim();
            var PassSQL = txtPassSQL.Text.TrimEnd().TrimStart().Trim();
            var DataBase = txtData.Text.TrimEnd().TrimStart().Trim();
            if (!string.IsNullOrEmpty(ServerSQL) && !string.IsNullOrEmpty(UserSQL) && !string.IsNullOrEmpty(PassSQL) && !string.IsNullOrEmpty(DataBase))
            {
                var ConnectString = $@"Server ={ ServerSQL}; Database ={ DataBase}; Integrated Security = False; User Id = { UserSQL }; Password = { PassSQL};";

                Configs.UpdateSettingAppConfig("ServerSQL", ServerSQL);
                Configs.UpdateSettingAppConfig("UserSQL", UserSQL);
                Configs.UpdateSettingAppConfig("PassSQL", PassSQL);
                Configs.UpdateSettingAppConfig("DataBase", DataBase);
                Configs.UpdateSettingAppConfig("ConnectionString", ConnectString);
                Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int i = 0;
            var ServerSQL = txtServer.Text.TrimEnd().TrimStart().Trim();
            var UserSQL = txtUserSQL.Text.TrimEnd().TrimStart().Trim();
            var PassSQL = txtPassSQL.Text.TrimEnd().TrimStart().Trim();
            var DataBase = txtData.Text.TrimEnd().TrimStart().Trim();


            if (!string.IsNullOrEmpty(ServerSQL) && !string.IsNullOrEmpty(UserSQL) && !string.IsNullOrEmpty(PassSQL) && !string.IsNullOrEmpty(DataBase))
            {
                splashScreenManager1.ShowWaitForm();
                for (i = 0; i < 10000; i++)
                {
                    i++;
                    var a = i.ToString();
                    if (i.ToString().Equals("9999"))
                    {
                        Thread.Sleep(9999);
                    }
                }
                var ConnectString = $@"Server={ ServerSQL};Database={DataBase};Integrated Security=False;User Id ={UserSQL};Password={PassSQL};";
                SqlConnection conn = new SqlConnection(ConnectString);
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        XtraMessageBox.Show("Kết nối thành công");
                    }
                    else
                    {
                        XtraMessageBox.Show("Kết nối không thành công, vui lòng kiểm tra lại");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                splashScreenManager1.CloseWaitForm();

            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin");
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

        private void Base_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.ServerSQL;
            txtUserSQL.Text = Properties.Settings.Default.UserSQL;
            txtPassSQL.Text = Properties.Settings.Default.PassSQL;
            txtData.Text = Properties.Settings.Default.DataBase;
        }
    }
}