﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAds.Services
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
            var text = $"select * from dbo.DTuong";
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
    }
}
