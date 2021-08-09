using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUseVaccine.Services
{
    public class GrData
    {
        public static List<ThongTinVx> Vx(string dieuKien)
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
                    where = $" where vx_ma like N'%{dieuKien}%' or vx_ten like N'%{dieuKien}%'";
                }
                else
                {
                    where = "";
                }
                var commandText = $"SELECT * FROM dbo.VacXin {where} ";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var vacxin = new List<ThongTinVx>();
                    vacxin.AddRange(from DataRow row in table.Rows
                                    select new ThongTinVx
                                    {
                                        vx_ma = !string.IsNullOrEmpty(row["vx_ma"].ToString()) ? row["vx_ma"].ToString() : null,
                                        vx_ten = !string.IsNullOrEmpty(row["vx_ten"].ToString()) ? row["vx_ten"].ToString() : null,
                                        vx_nsx = !string.IsNullOrEmpty(row["vx_nsx"].ToString()) ? row["vx_nsx"].ToString() : null,
                                        vx_location = !string.IsNullOrEmpty(row["vx_location"].ToString()) ? row["vx_location"].ToString() : null,
                                        vx_lo = !string.IsNullOrEmpty(row["vx_lo"].ToString()) ? row["vx_lo"].ToString() : null,
                                        vx_ngayNhap = !string.IsNullOrEmpty(row["vx_ngayNhap"].ToString()) ? DateTime.Parse(row["vx_ngayNhap"].ToString()).ToString("dd/MM/yyyy") : null,
                                        vx_hsd = !string.IsNullOrEmpty(row["vx_hsd"].ToString()) ? row["vx_hsd"].ToString() : null,
                                        vx_slNhap = !string.IsNullOrEmpty(row["vx_slNhap"].ToString()) ? row["vx_slNhap"].ToString() : null,
                                        vx__slXuat = !string.IsNullOrEmpty(row["vx__slXuat"].ToString()) ? row["vx__slXuat"].ToString() : null,
                                    });
                    return vacxin;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public static List<ThongTinBsy> Bsy(string dieuKien)
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
                    where = $" where DMBsy_Ma like N'%{dieuKien}%' or DMBsy_Ten like N'%{dieuKien}%'";
                }
                else
                {
                    where = "";
                }
                var commandText = $"SELECT  *  FROM DMBsy {where} ";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var content = new List<ThongTinBsy>();
                    content.AddRange(from DataRow row in table.Rows
                                     select new ThongTinBsy
                                     {
                                         DMBsy_Ma = !string.IsNullOrEmpty(row["DMBsy_Ma"].ToString()) ? row["DMBsy_Ma"].ToString() : null,
                                         DMBsy_Ten = !string.IsNullOrEmpty(row["DMBsy_Ten"].ToString()) ? row["DMBsy_Ten"].ToString() : null,
                                         DMBsy_diaChi = !string.IsNullOrEmpty(row["DMBsy_diaChi"].ToString()) ? row["DMBsy_diaChi"].ToString() : null,
                                         DMBsy_chuyenKhoa = !string.IsNullOrEmpty(row["DMBsy_chuyenKhoa"].ToString()) ? row["DMBsy_chuyenKhoa"].ToString() : null,
                                         DMBsy_Exp = !string.IsNullOrEmpty(row["DMBsy_Exp"].ToString()) ? row["DMBsy_Exp"].ToString() : null,
                                         DMBsy_Phone = !string.IsNullOrEmpty(row["DMBsy_Phone"].ToString()) ? row["DMBsy_Phone"].ToString() : null,
                                         DMBsy_bangCap = !string.IsNullOrEmpty(row["DMBsy_bangCap"].ToString()) ? row["DMBsy_bangCap"].ToString() : null,

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
    public class ThongTinVx
    {
        public string vx_ma { get; set; }
        public string vx_ten { get; set; }
        public string vx_nsx { get; set; }
        public string vx_location { get; set; }
        public string vx_lo { get; set; }
        public string vx_ngayNhap { get; set; }
        public string vx_hsd { get; set; }
        public string vx_slNhap { get; set; }
        public string vx__slXuat { get; set; }

    }
    public class ThongTinBsy
    {
        public string DMBsy_Ma { get; set; }
        public string DMBsy_Ten { get; set; }
        public string DMBsy_diaChi { get; set; }
        public string DMBsy_chuyenKhoa { get; set; }
        public string DMBsy_Exp { get; set; }
        public string DMBsy_Phone { get; set; }
        public string DMBsy_bangCap { get; set; }

    }
}
