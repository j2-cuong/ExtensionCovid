using DataUseVaccine.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataUseVaccine.DetailForm
{
    public partial class typePrint : DevExpress.XtraEditors.XtraForm
    {
        private string idGrid;
        public typePrint(string ID)
        {
            idGrid = ID;
            InitializeComponent();
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtType.Text.Contains("1"))
            {
                Configs.UpdateSettingAppConfig("_typePrint", "0");
            } else
            {
                if (txtType.Text.Contains("2"))
                {
                    try
                    {
                        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                        if(_conn.State == ConnectionState.Closed)
                        {
                            _conn.Open();
                        }
                        Configs.UpdateSettingAppConfig("_typePrint", "1");
                        var Qr = $"select * from TrangChu where TrangChu_id = '{idGrid}' AND isnull(vx_ma2,'')<>''";
                        DataTable _check = new DataTable();
                        SqlDataAdapter f = new SqlDataAdapter(Qr, _conn);
                        f.Fill(_check);
                        if(_check.Rows.Count == 0)
                        {
                            XtraMessageBox.Show("Đối tượng chưa tiêm mũi 2. Vui lòng kiểm tra lại");
                        }
                    } catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                        return;
                    }
                    
                } else
                {
                    XtraMessageBox.Show("Giá trị không đúng so với quy đinh. Vui lòng kiểm tra lại");
                }
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(txtType.Text.Trim()))
                {
                    SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    XtraReport report = new XtraReport();
                    var repxFile = "Repx/Report.repx";
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    var Qr = $"EXEC dbo.PrintData @id = N'{idGrid}',   @type = {Properties.Settings.Default._typePrint}  ";
                    DataSet dsDieuChinh = GetDataSet(Qr, _conn);
                    var itemReport = print.PrintReport(dsDieuChinh, repxFile);
                    report.Pages.AddRange(itemReport.Pages);

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng nhập giá trị trước khi bấm in");
                }
                

            } catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public DataSet GetDataSet(string sql, SqlConnection connection)
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "dataSet1";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ds.Tables.Add(table);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection?.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return ds;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}