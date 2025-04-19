using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBaiDoXeDataSet1 = new VIEW.QuanLiBaiDoXeDataSet1();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBaiDoXeDataSet = new VIEW.QuanLiBaiDoXeDataSet();
            this.kHACHHANGTableAdapter = new VIEW.QuanLiBaiDoXeDataSetTableAdapters.KHACHHANGTableAdapter();
            this.kHACHHANGTableAdapter1 = new VIEW.QuanLiBaiDoXeDataSet1TableAdapters.KHACHHANGTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ID_Khach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbtnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clbtnDel = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(24, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(911, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập ID hoặc tên khách hàng để tìm kiếm";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::VIEW.Properties.Resources.Search_btn;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(947, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Khach,
            this.Name_Customer,
            this.Phone_Customer,
            this.clbtnEdit,
            this.clbtnDel});
            this.dgvKhachHang.DataSource = this.kHACHHANGBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvKhachHang.Location = new System.Drawing.Point(24, 135);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.Size = new System.Drawing.Size(965, 334);
            this.dgvKhachHang.TabIndex = 3;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
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
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(859, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ID_Khach
            // 
            this.ID_Khach.DataPropertyName = "ID_Khach";
            this.ID_Khach.FillWeight = 25.97403F;
            this.ID_Khach.HeaderText = "ID";
            this.ID_Khach.Name = "ID_Khach";
            this.ID_Khach.ReadOnly = true;
            this.ID_Khach.Width = 275;
            // 
            // Name_Customer
            // 
            this.Name_Customer.DataPropertyName = "Name_Customer";
            this.Name_Customer.FillWeight = 155.2408F;
            this.Name_Customer.HeaderText = "Tên Khách Hàng";
            this.Name_Customer.Name = "Name_Customer";
            this.Name_Customer.ReadOnly = true;
            this.Name_Customer.Width = 275;
            // 
            // Phone_Customer
            // 
            this.Phone_Customer.DataPropertyName = "Phone_Customer";
            this.Phone_Customer.FillWeight = 199.2299F;
            this.Phone_Customer.HeaderText = "Số Điện Thoại";
            this.Phone_Customer.Name = "Phone_Customer";
            this.Phone_Customer.ReadOnly = true;
            this.Phone_Customer.Width = 275;
            // 
            // clbtnEdit
            // 
            this.clbtnEdit.FillWeight = 52.18367F;
            this.clbtnEdit.HeaderText = "";
            this.clbtnEdit.Image = global::VIEW.Properties.Resources.Edit_btn;
            this.clbtnEdit.Name = "clbtnEdit";
            this.clbtnEdit.ReadOnly = true;
            this.clbtnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clbtnEdit.Width = 50;
            // 
            // clbtnDel
            // 
            this.clbtnDel.FillWeight = 67.37158F;
            this.clbtnDel.HeaderText = "";
            this.clbtnDel.Image = global::VIEW.Properties.Resources.Del_btn;
            this.clbtnDel.Name = "clbtnDel";
            this.clbtnDel.ReadOnly = true;
            this.clbtnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clbtnDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clbtnDel.Width = 50;
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1028, 800);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Khach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Customer;
        private System.Windows.Forms.DataGridViewImageColumn clbtnEdit;
        private System.Windows.Forms.DataGridViewImageColumn clbtnDel;
    }
}
