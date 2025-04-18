using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using BLL;
using DTO;

namespace VIEW
{
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
            LoadData();


        }
        private KhachHangBLL bll = new KhachHangBLL();
        private void LoadData()
        {
            List<KhachHang> khachHangs = bll.GetAllKhachHang();
            dgvKhachHang.DataSource = khachHangs;

            // Giao diện đẹp
            //dgvKhachHang.BorderStyle = BorderStyle.None;
            //dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgvKhachHang.BackgroundColor = Color.White;

            //dgvKhachHang.EnableHeadersVisualStyles = false;
            //dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //dgvKhachHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            //dgvKhachHang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvKhachHang.RowTemplate.Height = 35;
            //dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgvKhachHang.RowHeadersVisible = false;


        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                // Lấy ID_Khach từ dòng được chọn
                string id = dgvKhachHang.SelectedRows[0].Cells["ID_Khach"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = bll.DeleteKhachHang(id);
                    if (success)
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadData(); // Load lại dữ liệu sau khi xoá
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ADDCustomer_infoForm addCustomerForm = new ADDCustomer_infoForm();
            addCustomerForm.ShowDialog();
            LoadData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKhachHang.SelectedRows[0];

                KhachHang kh = new KhachHang()
                {
                    ID_Khach = row.Cells["ID_Khach"].Value.ToString(),
                    Name_customer = row.Cells["Name_customer"].Value.ToString(),
                    Phone_customer = row.Cells["Phone_customer"].Value.ToString()
                };
                UPDATECustomer_infoForm updateCustomerForm = new UPDATECustomer_infoForm(kh);
                updateCustomerForm.ShowDialog();
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KhachHangBLL kh = new KhachHangBLL();
            string searchTerm = txtSearch.Text;
            List<KhachHang> searchResults = kh.SearchKhachHang(searchTerm);
            dgvKhachHang.DataSource = searchResults;
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập ID hoặc tên khách hàng để tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvKhachHang.Rows[e.RowIndex].Cells["ID_Khach"].Value.ToString();

                // Nút Sửa
                if (dgvKhachHang.Columns[e.ColumnIndex].Name == "clbtnEdit")
                {
                    KhachHang kh = new KhachHang
                    {
                        ID_Khach = id,
                        Name_customer = dgvKhachHang.Rows[e.RowIndex].Cells["Name_customer"].Value.ToString(),
                        Phone_customer = dgvKhachHang.Rows[e.RowIndex].Cells["Phone_customer"].Value.ToString()
                    };
                    UPDATECustomer_infoForm updateForm = new UPDATECustomer_infoForm(kh);
                    updateForm.ShowDialog();
                    LoadData();
                }

                // Nút Xoá
                if (dgvKhachHang.Columns[e.ColumnIndex].Name == "clbtnDel")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        bool success = bll.DeleteKhachHang(id);
                        if (success)
                        {
                            MessageBox.Show("Xoá thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xoá thất bại!");
                        }
                    }
                }
            }
        }
    }
}

