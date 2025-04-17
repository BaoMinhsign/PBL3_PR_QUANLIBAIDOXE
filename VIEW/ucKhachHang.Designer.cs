namespace VIEW
{
    partial class ucKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.ID_Khach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBaiDoXeDataSet1 = new VIEW.QuanLiBaiDoXeDataSet1();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBaiDoXeDataSet = new VIEW.QuanLiBaiDoXeDataSet();
            this.kHACHHANGTableAdapter = new VIEW.QuanLiBaiDoXeDataSetTableAdapters.KHACHHANGTableAdapter();
            this.kHACHHANGTableAdapter1 = new VIEW.QuanLiBaiDoXeDataSet1TableAdapters.KHACHHANGTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBaiDoXeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBaiDoXeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(24, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập ID hoặc tên khách hàng để tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(590, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Khach,
            this.Name_Customer,
            this.Phone_Customer});
            this.dgvKhachHang.DataSource = this.kHACHHANGBindingSource1;
            this.dgvKhachHang.Location = new System.Drawing.Point(24, 135);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(543, 347);
            this.dgvKhachHang.TabIndex = 3;
            // 
            // ID_Khach
            // 
            this.ID_Khach.DataPropertyName = "ID_Khach";
            this.ID_Khach.HeaderText = "ID";
            this.ID_Khach.Name = "ID_Khach";
            this.ID_Khach.Width = 200;
            // 
            // Name_Customer
            // 
            this.Name_Customer.DataPropertyName = "Name_Customer";
            this.Name_Customer.HeaderText = "Tên Khách Hàng";
            this.Name_Customer.Name = "Name_Customer";
            this.Name_Customer.Width = 200;
            // 
            // Phone_Customer
            // 
            this.Phone_Customer.DataPropertyName = "Phone_Customer";
            this.Phone_Customer.HeaderText = "Số Điện Thoại";
            this.Phone_Customer.Name = "Phone_Customer";
            this.Phone_Customer.Width = 200;
            // 
            // kHACHHANGBindingSource1
            // 
            this.kHACHHANGBindingSource1.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource1.DataSource = this.quanLiBaiDoXeDataSet1;
            // 
            // quanLiBaiDoXeDataSet1
            // 
            this.quanLiBaiDoXeDataSet1.DataSetName = "QuanLiBaiDoXeDataSet1";
            this.quanLiBaiDoXeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.quanLiBaiDoXeDataSet;
            // 
            // quanLiBaiDoXeDataSet
            // 
            this.quanLiBaiDoXeDataSet.DataSetName = "QuanLiBaiDoXeDataSet";
            this.quanLiBaiDoXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter1
            // 
            this.kHACHHANGTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm KH";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(590, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa thông tin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(590, 215);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 31);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xoá KH";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBaiDoXeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBaiDoXeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QuanLiBaiDoXeDataSet quanLiBaiDoXeDataSet;
        private QuanLiBaiDoXeDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource1;
        private QuanLiBaiDoXeDataSet1 quanLiBaiDoXeDataSet1;
        private QuanLiBaiDoXeDataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Khach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Customer;
    }
}
