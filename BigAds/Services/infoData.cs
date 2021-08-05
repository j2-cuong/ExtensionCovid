using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUseVaccine.Services
{
    public class infoData
    {
        public static List<ThongTinDataDoiTuong> DoiTuong(string dieuKien)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            try
            {
                var where = "";
                if (!string.IsNullOrEmpty(dieuKien))
                {
                    where = $" where DTuong_ma like N'%{dieuKien}%' or DTuong_ten like N'%{dieuKien}%'  or DTuong_CCCD like N'%{dieuKien}%'";
                }
                else
                {
                    where = "";
                }
                var commandText = $"SELECT  *  FROM DTuong {where} ";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var content = new List<ThongTinDataDoiTuong>();
                    content.AddRange(from DataRow row in table.Rows
                                     select new ThongTinDataDoiTuong
                                     {
                                         DTuong_ma = !string.IsNullOrEmpty(row["DTuong_ma"].ToString()) ? row["DTuong_ma"].ToString() : null,
                                         DTuong_ten = !string.IsNullOrEmpty(row["DTuong_ten"].ToString()) ? row["DTuong_ten"].ToString() : null,
                                         DTuong_nsinh = DateTime.Parse(row["DTuong_nsinh"].ToString()),
                                         DTuong_GTinh = !string.IsNullOrEmpty(row["DTuong_GTinh"].ToString()) ? row["DTuong_GTinh"].ToString() : null,
                                         DTuong_DVCtac = !string.IsNullOrEmpty(row["DTuong_DVCtac"].ToString()) ? row["DTuong_DVCtac"].ToString() : null,
                                         DTuong_SDT = !string.IsNullOrEmpty(row["DTuong_SDT"].ToString()) ? row["DTuong_SDT"].ToString() : null,
                                         DTuong_CCCD = !string.IsNullOrEmpty(row["DTuong_CCCD"].ToString()) ? row["DTuong_CCCD"].ToString() : null,
                                         DTuong_BHYT = !string.IsNullOrEmpty(row["DTuong_BHYT"].ToString()) ? row["DTuong_BHYT"].ToString() : null,
                                         DTuong_MaNhom = !string.IsNullOrEmpty(row["DTuong_MaNhom"].ToString()) ? row["DTuong_MaNhom"].ToString() : null,
                                         DTuong_Tinh = !string.IsNullOrEmpty(row["DTuong_Tinh"].ToString()) ? row["DTuong_Tinh"].ToString() : null,
                                         DTuong_TinhCode = !string.IsNullOrEmpty(row["DTuong_TinhCode"].ToString()) ? row["DTuong_TinhCode"].ToString() : null,
                                         DTuong_Quan = !string.IsNullOrEmpty(row["DTuong_Quan"].ToString()) ? row["DTuong_Quan"].ToString() : null,
                                         DTuong_QuanCode = !string.IsNullOrEmpty(row["DTuong_QuanCode"].ToString()) ? row["DTuong_QuanCode"].ToString() : null,
                                         DTuong_Xa = !string.IsNullOrEmpty(row["DTuong_Xa"].ToString()) ? row["DTuong_Xa"].ToString() : null,
                                         DTuong_XaCode = !string.IsNullOrEmpty(row["DTuong_XaCode"].ToString()) ? row["DTuong_XaCode"].ToString() : null,
                                         DTuong_DCCtiet = !string.IsNullOrEmpty(row["DTuong_DCCtiet"].ToString()) ? row["DTuong_DCCtiet"].ToString() : null,
                                         
                                     });
                    return content;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
    public class ThongTinDataDoiTuong
    {
        public string DTuong_ma { get; set; }
        public string DTuong_ten { get; set; }
        public DateTime DTuong_nsinh { get; set; }
        public string DTuong_GTinh { get; set; }
        public string DTuong_DVCtac { get; set; }
        public string DTuong_SDT { get; set; }
        public string DTuong_CCCD { get; set; }
        public string DTuong_BHYT { get; set; }
        public string DTuong_MaNhom { get; set; }
        public string DTuong_Tinh { get; set; }
        public string DTuong_TinhCode { get; set; }
        public string DTuong_Quan { get; set; }
        public string DTuong_QuanCode { get; set; }
        public string DTuong_Xa { get; set; }
        public string DTuong_XaCode { get; set; }
        public string DTuong_DCCtiet { get; set; }

    }
}
