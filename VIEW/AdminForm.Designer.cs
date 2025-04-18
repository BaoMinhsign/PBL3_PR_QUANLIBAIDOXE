using System.Drawing;

namespace VIEW
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnGiaodich = new System.Windows.Forms.Button();
            this.btnBaido = new System.Windows.Forms.Button();
            this.btnPhuongtien = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(21, 14, 55);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnGiaodich);
            this.panel1.Controls.Add(this.btnBaido);
            this.panel1.Controls.Add(this.btnPhuongtien);
            this.panel1.Controls.Add(this.btnKhachhang);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 530);
            this.panel1.TabIndex = 0;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(8, 332);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(35);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(5);
            this.btnThongke.Size = new System.Drawing.Size(145, 44);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // btnGiaodich
            // 
            this.btnGiaodich.Location = new System.Drawing.Point(8, 272);
            this.btnGiaodich.Margin = new System.Windows.Forms.Padding(35);
            this.btnGiaodich.Name = "btnGiaodich";
            this.btnGiaodich.Padding = new System.Windows.Forms.Padding(5);
            this.btnGiaodich.Size = new System.Drawing.Size(145, 44);
            this.btnGiaodich.TabIndex = 4;
            this.btnGiaodich.Text = "Giao Dịch";
            this.btnGiaodich.UseVisualStyleBackColor = true;
            // 
            // btnBaido
            // 
            this.btnBaido.Location = new System.Drawing.Point(9, 212);
            this.btnBaido.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaido.Name = "btnBaido";
            this.btnBaido.Size = new System.Drawing.Size(145, 44);
            this.btnBaido.TabIndex = 3;
            this.btnBaido.Text = "Bãi Đỗ";
            this.btnBaido.UseVisualStyleBackColor = true;
            // 
            // btnPhuongtien
            // 
            this.btnPhuongtien.Location = new System.Drawing.Point(9, 152);
            this.btnPhuongtien.Margin = new System.Windows.Forms.Padding(35);
            this.btnPhuongtien.Name = "btnPhuongtien";
            this.btnPhuongtien.Padding = new System.Windows.Forms.Padding(5);
            this.btnPhuongtien.Size = new System.Drawing.Size(145, 44);
            this.btnPhuongtien.TabIndex = 2;
            this.btnPhuongtien.Text = "Phương Tiện";
            this.btnPhuongtien.UseVisualStyleBackColor = true;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Location = new System.Drawing.Point(8, 92);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(35);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(5);
            this.btnKhachhang.Size = new System.Drawing.Size(145, 44);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách Hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(8, 32);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(35);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(5);
            this.btnNhanvien.Size = new System.Drawing.Size(145, 44);
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Text = "Nhân Viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(176, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1155, 530);
            this.panelMain.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPhuongtien;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnGiaodich;
        private System.Windows.Forms.Button btnBaido;
        private System.Windows.Forms.Panel panelMain;
    }
}