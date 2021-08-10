using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUseVaccine.Services
{
    public class LoadData
    {
        public static DataTable LoadGrDTuong()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable GroupDTuong = new DataTable();
            var text = $"select * from dbo.GroupDTuong order by isTimeAdd";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(GroupDTuong);
            return GroupDTuong;
        }
        public static DataTable bindingGroupDTuong(string ID)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if(_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            
            DataTable GroupDTuong = new DataTable();
            var text = $"select * from dbo.GroupDTuong where GroupDTuong_id = '{ID}'";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(GroupDTuong);
            return GroupDTuong;
        }

        public static DataTable LoadDoiTuong()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.DTuong order by isTimeAdd desc";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable bindingDTuong(string ID)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.DTuong where DTuong_id = '{ID}'";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable LoadBsy()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.DMBsy";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable bindingBsy(string ID)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.DMBsy where DMBsy_id = '{ID}'";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable LoadVx()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.VacXin";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable bindingVx(string ID)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.VacXin where vx_id = '{ID}'";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }


        public static DataTable TrangChu()
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.TrangChu";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }

        public static DataTable bindingTrangChu(string ID)
        {
            SqlConnection _conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            DataTable DTuong = new DataTable();
            var text = $"select * from dbo.TrangChu where trangchu_id = '{ID}'";
            SqlDataAdapter _data = new SqlDataAdapter(text, _conn);
            _data.Fill(DTuong);
            return DTuong;
        }
    }
}
