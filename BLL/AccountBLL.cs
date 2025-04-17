using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class AccountBLL
    {
        AccountAccess account_access = new AccountAccess();
        public Account Check_Login(Account account, out string error)
        {
            error = "";
            if (account.Name_account == "")
            {
                error = "Required username";
                return null;
            }
            if (account.PassWord == "")
            {
                error = "Required password";
                return null;
            }
            Account result = account_access.Check_LoginDTO(account);
            if (result == null)
            {
                error = "Tài khoản hoặc mật khẩu không chính xác!!";
            }
            return result;

        }
    }
}
