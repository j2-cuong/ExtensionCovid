using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataUseVaccine.Services
{
    class SqlLibrary
    {
        SqlConnection con;

        public void open(string conString)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Lỗi", se.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void close()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show( se.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public int ExecuteQueriesReturn(string Query_)
        {
            int x = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                x = cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Lỗi", se.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return x;
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataTable GetDataTable(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
