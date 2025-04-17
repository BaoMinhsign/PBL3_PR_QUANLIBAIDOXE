using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEW
{
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            LoadUC(new ucKhachHang());
        }
    }
}
