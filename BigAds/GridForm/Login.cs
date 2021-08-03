using BigAds.FormDetail;
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

namespace BigAds.Frm
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
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
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Base frm = new Base();
            frm.ShowDialog();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu");
            } else
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.ConnectionString.ToString()))
                {
                    XtraMessageBox.Show("Chưa cài dặt kết nối tới Server. Vui lòng kiểm tra lại");
                }
                else
                {
                    frmDashboard frm = new frmDashboard(this);
                    frm.ShowDialog();
                }
               
            }
        }
    }
}