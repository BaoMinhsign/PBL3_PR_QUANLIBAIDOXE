using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class KhachHangAccess : DatabaseAccess
    {
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> li = new List<KhachHang>();
            SqlDataReader reader = ExecuteReader("SELECT * FROM KHACHHANG");

            while (reader.Read())
            {
                KhachHang kh = new KhachHang()
                {
                    ID_Khach = reader.GetString(0),
                    Name_customer = reader.GetString(1),
                    Phone_customer = reader.GetString(2)
                };
                li.Add(kh);
            }
            reader.Close();
            return li;
        }
        public bool AddKhachHang(KhachHang kh)
        {
            string query = "INSERT INTO KHACHHANG (ID_Khach, Name_Customer, Phone_Customer) VALUES (@ID_Khach, @Name_Customer, @Phone_Customer)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_Khach", kh.ID_Khach),
                new SqlParameter("@Name_Customer", kh.Name_customer),
                new SqlParameter("@Phone_Customer", kh.Phone_customer)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool UpdateKhachHang(KhachHang kh)
        {
            string query = "UPDATE KHACHHANG SET Name_Customer = @Name_Customer, Phone_Customer = @Phone_Customer WHERE ID_Khach = @ID_Khach";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_Khach", kh.ID_Khach),
                new SqlParameter("@Name_Customer", kh.Name_customer),
                new SqlParameter("@Phone_Customer", kh.Phone_customer)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteKhachHang(string id)
        {
            string query = "DELETE FROM KHACHHANG WHERE ID_Khach = @ID_Khach";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_Khach", id)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public List<KhachHang> SearchKhachHang(string key)
        {
            List<KhachHang> li = new List<KhachHang> ();
            string query = @"SELECT * FROM KHACHHANG WHERE ID_Khach Like @kw OR Name_Customer LIKE @kw OR Phone_Customer LIKE @kw";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@kw", "%" + key + "%")
            };
            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang()
                    {
                        ID_Khach = reader.GetString(0),
                        Name_customer = reader.GetString(1),
                        Phone_customer = reader.GetString(2)
                    };
                    li.Add(kh);
                }
            }
            return li;
        }
        public bool CheckID(string id)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE ID_Khach = @ID_Khach";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID_Khach", id)
            };
            int count = Convert.ToInt32(ExecuteScalar(query, parameters));
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckPhone(string phone)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE Phone_Customer = @Phone_Customer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Phone_Customer", phone)
            };
            int count = Convert.ToInt32(ExecuteScalar(query, parameters));
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
