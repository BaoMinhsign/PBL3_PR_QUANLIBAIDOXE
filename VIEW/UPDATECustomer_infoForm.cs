using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace VIEW
{
    public partial class UPDATECustomer_infoForm: Form
    {
        public UPDATECustomer_infoForm(KhachHang kh)
        {
            InitializeComponent();
            getKH(kh);
        }

        public void getKH(KhachHang kh)
        {
            txtID.Text = kh.ID_Khach;
            txtName.Text = kh.Name_customer; ;
            txtNum.Text = kh.Phone_customer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          KhachHang kh = new KhachHang();
            kh.Name_customer = txtName.Text;
            kh.Phone_customer = txtNum.Text;
            KhachHangBLL bll = new KhachHangBLL();
            string error;
            error = "";
            bool result = bll.UpdateKhachHang(kh, out error);
            if (result)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
