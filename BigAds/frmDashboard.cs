using System;
using DevExpress.XtraEditors;
using System.Threading;
using System.Windows.Forms;
using BigAds.Frm;
using System.Data.SqlClient;
using System.Drawing;

namespace BigAds
{
    public partial class frmDashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public string currentFormOpened = "";
        XtraForm someForm;
        
        public frmDashboard(XtraForm thisForm)
        {
            someForm = thisForm;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }
        public void OpenForm(UserControl userControl)
        {

            if (!fluentDesignFormContainer1.Controls.Contains(userControl))
            {
               
                Thread.Sleep(200);
                fluentDesignFormContainer1.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();

            }
            else
            {
                userControl.BringToFront();
            }
            currentFormOpened = userControl.Tag?.ToString();

        }

        private void Element1_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            fluentDesignFormContainer1.Controls.Clear();
            someForm.Hide();
            OpenForm(GridContent.Instance);
            splashScreenManager1.CloseWaitForm();
            
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            someForm.Hide();
            OpenForm(GridContent.Instance);
            accordionControlElement6.Appearance.Normal.BackColor = Color.FromArgb(29, 149, 246);
            accordionControlElement1.Appearance.Normal.BackColor = Color.FromArgb(31, 30, 44);
           
        }
        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            someForm.Close();
            Close();
        }

       

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            fluentDesignFormContainer1.Controls.Clear();
            OpenForm(GridChuyenMuc.Instance);
            splashScreenManager1.CloseWaitForm();

            accordionControlElement1.Appearance.Normal.BackColor = Color.FromArgb(29, 149, 246);
            accordionControlElement6.Appearance.Normal.BackColor = Color.FromArgb(31, 30, 44);

        }

        
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            fluentDesignFormContainer1.Controls.Clear();
            OpenForm(GridContent.Instance);
            splashScreenManager1.CloseWaitForm();

            accordionControlElement6.Appearance.Normal.BackColor = Color.FromArgb(29, 149, 246);
            accordionControlElement1.Appearance.Normal.BackColor = Color.FromArgb(31, 30, 44);
        }
    }
}
