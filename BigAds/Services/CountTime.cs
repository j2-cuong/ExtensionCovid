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
            ResultObject result = new ResultObject
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
                bool b;

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
                        DataTable check = new DataTable();
                        var FindTime = $"select tgTiem from VacXin where vx_ma = N'{maVx}'";
                        SqlDataAdapter checkFind = new SqlDataAdapter(FindTime, _conn);
                        checkFind.Fill(check);
                        if (check.Rows.Count > 0)
                        {
                            foreach (DataRow item2 in check.Rows)
                            {

                                ThoiGianCheck = int.Parse(item2["tgTiem"].ToString());
                                b = TimeHienTai == TiemLan1.AddDays(ThoiGianCheck);
                                if (b != true)
                                {
                                    result.Message = "Chưa tới thời điểm tiêm mũi tiếp theo. Vui lòng kiểm tra khai báo trong danh mục Vắc xin";
                                    result.IsResult = false;
                                } else
                                {
                                    result.IsResult = true;
                                }
                            }
                        }
                    }
                }
               
                _conn.Close();
            }
            catch (Exception ex)
            {
                result.Message = "Chưa tới thời điểm tiêm mũi tiếp theo. Vui lòng kiểm tra khai báo trong danh mục Vắc xin";
                result.IsResult = false;
            }
            return result;
        }
    }
    public class ResultObject
    {
        public bool IsResult { get; set; }

        public string Message { get; set; }

        

    }
}
