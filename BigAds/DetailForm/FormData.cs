
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
        public FormData(string ID)
        {
            idGrid = ID;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AutoSize = false;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            _conn.Open();
            BackColor = Color.FromArgb(244, 245, 247);
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
    }
}