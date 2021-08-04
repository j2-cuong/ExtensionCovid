using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAds.Services
{
    public class dvhc
    {
        
        public static List<ListDonVi> GetTinhTpho()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            try
            {
                var commandText = $"SELECT  Tinh ,TinhCode  FROM Router ";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var content = new List<ListDonVi>();
                    content.AddRange(from DataRow row in table.Rows
                        select new ListDonVi
                        {
                            Tinh = row["Tinh"].ToString(),
                            TinhCode = row["TinhCode"].ToString(),
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

        public static List<ListDonVi> GetQuanHuyen(string a,string b)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            try
            {
                var commandText = $"SELECT  a.Quan AS Quan, a.QuanCode AS QuanCode FROM dbo.DMHC a " +
                    $"left JOIN dbo.Router b ON b.Tinh = a.Tinh AND b.TinhCode = a.TinhCode " +
                    $"where a.Tinh = N'{a}' AND a.TinhCode = N'{b}'" +
                    $"GROUP BY a.Quan , a.QuanCode, b.Tinh ORDER BY a.QuanCode ";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var content = new List<ListDonVi>();
                    content.AddRange(from DataRow row in table.Rows
                                     select new ListDonVi
                                     {
                                         Quan = row["Quan"].ToString(),
                                         QuanCode = row["QuanCode"].ToString(),
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
        public static List<ListDonVi> GetXaPhuong(string c, string d)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            try
            {
                var commandText = $"SELECT  Xa as TenXa, XaCode as MaXa FROM dbo.DMHC " +
                    $"where Quan = N'{c}' AND QuanCode = N'{d}'";
                var adapter = new SqlDataAdapter(commandText, _conn);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    var content = new List<ListDonVi>();
                    content.AddRange(from DataRow row in table.Rows
                                     select new ListDonVi
                                     {
                                         Xa = row["TenXa"].ToString(),
                                         XaCode = row["MaXa"].ToString(),
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


    public class ListDonVi
    {
        public string Tinh { get; set; }
        public string TinhCode { get; set; }
        public string Quan { get; set; }
        public string QuanCode { get; set; }
        public string Xa { get; set; }
        public string XaCode { get; set; }

    }
}
