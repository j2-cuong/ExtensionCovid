using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUseVaccine.Services
{
    public class CountTime
    {
        SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public void _connOpen()
        {
            _conn.Open();
        }
        public void _connClose()
        {
            _conn.Close();
        }
        public ResultObject delContent(string id)
        {
            ResultObject resultDelete = new ResultObject
            {
                IsResult = true
            };
            try
            {
                if(_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                
                // Time hiện tại lớn hơn hoặc bằng Time1 + ThoiGianCheck thì cho qua

                int ThoiGianCheck ;
                DateTime TiemLan1;
                DateTime TimeHienTai = DateTime.Now;
                var maVx = "";

                DataTable FindMaVx = new DataTable();
                var QrTimeTiem = $"select vx_ma, TimeTiem1 from TrangChu where TrangChu_id = '{id}'";
                SqlDataAdapter checkCn = new SqlDataAdapter(QrTimeTiem, _conn);
                checkCn.Fill(FindMaVx);
                if (FindMaVx.Rows.Count > 0)
                {
                    
                    foreach (DataRow item in FindMaVx.Rows)
                    {
                        maVx = item["vx_ma"].ToString();
                        TiemLan1 = DateTime.Parse(item["TimeTiem1"].ToString());
                        
                    }
                    
                    DataTable check = new DataTable();
                    var FindTime = $"select tgTiem from VacXin where vx_ma = N'{maVx}'";
                    SqlDataAdapter checkFind = new SqlDataAdapter(FindTime, _conn);
                    checkFind.Fill(check); 
                    if(check.Rows.Count > 0)
                    {
                        foreach (DataRow item in FindMaVx.Rows)
                        {
                            
                            ThoiGianCheck = int.Parse(item["tgTiem"].ToString());
                            
                        }
                    }
                    
                }
                //if (TimeHienTai == Time1.AddDays(ThoiGianCheck))
                //{

                //}



                //    DataTable checkVx = new DataTable();
                //var QrTimeTiem = $"select userAdd from Content where id = '{id}'";
                //SqlDataAdapter checkCn = new SqlDataAdapter(QrTimeTiem, _conn);
                //checkCn.Fill(checkVx);
                //if (checkVx.Rows.Count > 0)
                //{
                //    foreach (DataRow itemU in checkVx.Rows)
                //    {
                //        TimeTiem = itemU["userAdd"].ToString();
                //    }
                //    if (Properties.Settings.Default.UserLogin != TimeTiem && (Properties.Settings.Default.permission.Contains("1") || Properties.Settings.Default.permission.Contains("2")))
                //    {
                //        resultDelete.Message = "Bạn không có quyền xóa Content của người khác";
                //        resultDelete.IsResult = false;
                //    }
                //}

                _conn.Close();
            }
            catch (Exception ex)
            {
                resultDelete.Message = "Bạn không có quyền xóa Content của người khác";
                resultDelete.IsResult = false;
            }
            return resultDelete;
        }
    }
    public class ResultObject
    {
        public bool IsResult { get; set; }

        public string Message { get; set; }

        

    }
}
