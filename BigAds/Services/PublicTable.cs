using System.Data;
using System.Data.SqlClient;

namespace DataUseVaccine.Services
{
    public class PublicTable
    {
        public static DataTable ReportTable(string Qr)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable DTuong = new DataTable();
            SqlDataAdapter _data = new SqlDataAdapter(Qr, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }
    }
}
