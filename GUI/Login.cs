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

namespace GUI
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

            string getuser = account_BLL.Check_Login(account);
            switch (getuser)
            {
                case "Required username":
                    MessageBox.Show("Vui lòng nhập tên tài khoản");
                    return;
                case "Required password":
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!");
                    return;
                    //default:
                    //    MessageBox.Show("Đăng nhập thành công");
                    //    Main main = new Main();
                    //    this.Hide();
                    //    main.ShowDialog();
                    //    this.Close();
                    //    break;
            }
            MessageBox.Show("Đăng nhập thành công!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
