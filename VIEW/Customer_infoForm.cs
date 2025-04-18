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
    public partial class ADDCustomer_infoForm: Form
    {
        public ADDCustomer_infoForm()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           KhachHang kh = new KhachHang();
            kh.ID_Khach = txtID.Text;
            kh.Name_customer = txtName.Text;
            kh.Phone_customer = txtNum.Text;
            KhachHangBLL bll = new KhachHangBLL();
            string error;
            error = "";
            bool result = bll.AddKhachHang(kh, out error);
            if (result)
            {
                MessageBox.Show("Thêm khách hàng thành công !!");
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
