using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DatabaseAccess
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=DESKTOP-M2HN39B;Initial Catalog=QuanLiBaiDoXe;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public static SqlConnection GetOpenConnection()
        {
            SqlConnection conn = DatabaseAccess.GetConnection();
            conn.Open();
            return conn;
        }

        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetOpenConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                    cmd.Parameters.AddRange(parameters);
            }
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        protected static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetOpenConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                        cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
