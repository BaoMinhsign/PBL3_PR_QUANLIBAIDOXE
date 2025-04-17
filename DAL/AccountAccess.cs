using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class AccountAccess : DatabaseAccess
    {
        // Kiểm tra đăng nhập (dùng câu lệnh SQL)
        public Account Check_LoginDTO(Account account_input)
        {
            string query = "SELECT ID_account, Name_account, ID_role FROM Login WHERE Name_account = @user AND PassWord = @pass";

            SqlParameter[] parameters =
            {
                new SqlParameter("@user", account_input.Name_account),
                new SqlParameter("@pass", account_input.PassWord)
            };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    return new Account
                    {
                        ID_account = reader.GetString(0),
                        Name_account = reader.GetString(1),
                        ID_role = reader.GetInt32(2)
                    };
                }
            }

            return null;
        }
    }
}