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
            this.WindowState = FormWindowState.Maximized;
        }
        private void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        //private void btnKhachhang_Click(object sender, EventArgs e)
        //{
        //    btnKhachhang.BackColor = Color.FromArgb(171,163,196);   
        //    LoadUC(new ucKhachHang());
        //}

        //private void btnNhanvien_Click(object sender, EventArgs e)
        //{
        //    btnNhanvien.BackColor = Color.FromArgb(171, 163, 196);
            
        //}

        private Color colorSelected = Color.FromArgb(171, 163, 196);
        private Color colorDefault = Color.FromArgb(21,14,55);

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Reset màu tất cả các nút trong panel
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = colorDefault;
                }
            }
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is PictureBox icon)
                {
                    icon.BackColor = colorDefault;
                }
            }

            // Đổi màu nút được chọn
            clickedButton.BackColor = colorSelected;

            // Load UserControl tương ứng
            switch (clickedButton.Name)
            {
                case "btnKhachhang":
                    icon_Khachhang.BackColor = colorSelected;
                    LoadUC(new ucKhachHang());
                    break;
                case "btnNhanvien":
                    icon_Nhanvien.BackColor = colorSelected;
                    //LoadUC(new ucNhanVien());
                    break;
                // thêm các case khác tùy theo tên nút
                case "btnPhuongtien":
                    icon_Phuongtien.BackColor = colorSelected;
                    //LoadUC(new ucPhuongTien());
                    break;
                case "btnBaido":
                    icon_Baido.BackColor = colorSelected;
                    //LoadUC(new ucBaido());
                    break;
                case "btnGiaodich":
                    icon_Giaodich.BackColor = colorSelected;
                    //LoadUC(new ucGiaodich());
                    break;
                case "btnThongke":
                    icon_Thongke.BackColor = colorSelected;
                    //LoadUC(new ucThongKe());
                    break;
            }
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += SidebarButton_Click;
                }
            }
        }
    }
}
