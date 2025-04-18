using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace VIEW

{
    public partial class Login : Form
    {
        Account account = new Account();
        AccountBLL account_BLL = new AccountBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account.Name_account = txtAccount.Text;
            account.PassWord = txtPass.Text;

            string error;
            Account result = account_BLL.Check_Login(account, out error);
            if (result == null)
            {
                MessageBox.Show(error);
                return;
            }
            string role = result.ID_role == 1 ? "Admin" : result.ID_role == 2 ? "User" : "Unknown role";
            this.Hide();
            MessageBox.Show("Đăng nhập thành công! Role của người đăng nhập là: " + role);
            if (result.ID_role == 1)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                this.Close();
            }
            //else if (result.ID_role == 2)
            //{
            //    UserForm userForm = new UserForm();
            //    userForm.ShowDialog();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
