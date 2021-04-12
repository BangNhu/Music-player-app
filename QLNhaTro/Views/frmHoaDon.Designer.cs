
namespace QLNhaTro.Views
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaTroDataSet = new QLNhaTro.QLNhaTroDataSet();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemkhutrocn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtKhachtro = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Th = new DevExpress.XtraEditors.GroupControl();
            this.btnTong = new DevExpress.XtraEditors.SimpleButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.btnVesinh = new System.Windows.Forms.CheckBox();
            this.btnGiatdo = new System.Windows.Forms.CheckBox();
            this.btnInternet = new System.Windows.Forms.CheckBox();
            this.btnXemay = new System.Windows.Forms.CheckBox();
            this.btnXedap = new System.Windows.Forms.CheckBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.hoaDonTableAdapter = new QLNhaTro.QLNhaTroDataSetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).BeginInit();
            this.Th.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(791, 206);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(234, 36);
            this.txtTim.TabIndex = 70;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::QLNhaTro.Properties.Resources.find_32x32;
            this.btnTimKiem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(1026, 206);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 37);
            this.btnTimKiem.TabIndex = 67;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maKTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngayThanhToanDataGridViewTextBoxColumn,
            this.triGiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 437);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 216);
            this.dataGridView1.TabIndex = 66;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKTDataGridViewTextBoxColumn
            // 
            this.maKTDataGridViewTextBoxColumn.DataPropertyName = "MaKT";
            this.maKTDataGridViewTextBoxColumn.HeaderText = "MaKT";
            this.maKTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKTDataGridViewTextBoxColumn.Name = "maKTDataGridViewTextBoxColumn";
            this.maKTDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayThanhToanDataGridViewTextBoxColumn
            // 
            this.ngayThanhToanDataGridViewTextBoxColumn.DataPropertyName = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.HeaderText = "NgayThanhToan";
            this.ngayThanhToanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayThanhToanDataGridViewTextBoxColumn.Name = "ngayThanhToanDataGridViewTextBoxColumn";
            this.ngayThanhToanDataGridViewTextBoxColumn.Width = 125;
            // 
            // triGiaDataGridViewTextBoxColumn
            // 
            this.triGiaDataGridViewTextBoxColumn.DataPropertyName = "TriGia";
            this.triGiaDataGridViewTextBoxColumn.HeaderText = "TriGia";
            this.triGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.triGiaDataGridViewTextBoxColumn.Name = "triGiaDataGridViewTextBoxColumn";
            this.triGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLNhaTroDataSet;
            // 
            // qLNhaTroDataSet
            // 
            this.qLNhaTroDataSet.DataSetName = "QLNhaTroDataSet";
            this.qLNhaTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Sua;
            this.btnSua.Location = new System.Drawing.Point(1008, 37);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 53);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Email_Delete_icon__2_;
            this.btnXoa.Location = new System.Drawing.Point(806, 111);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 53);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThemkhutrocn
            // 
            this.btnThemkhutrocn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkhutrocn.Appearance.Options.UseFont = true;
            this.btnThemkhutrocn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemkhutrocn.ImageOptions.Image")));
            this.btnThemkhutrocn.Location = new System.Drawing.Point(806, 37);
            this.btnThemkhutrocn.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemkhutrocn.Name = "btnThemkhutrocn";
            this.btnThemkhutrocn.Size = new System.Drawing.Size(132, 53);
            this.btnThemkhutrocn.TabIndex = 63;
            this.btnThemkhutrocn.Text = "Thêm";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(1008, 110);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 53);
            this.btnLuu.TabIndex = 62;
            this.btnLuu.Text = "Lưu";
            // 
            // txtKhachtro
            // 
            this.txtKhachtro.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachtro.Location = new System.Drawing.Point(288, 82);
            this.txtKhachtro.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachtro.Name = "txtKhachtro";
            this.txtKhachtro.Size = new System.Drawing.Size(325, 28);
            this.txtKhachtro.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(125, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 21);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Tên khách trọ";
            // 
            // Th
            // 
            this.Th.Controls.Add(this.btnTong);
            this.Th.Controls.Add(this.textBox5);
            this.Th.Controls.Add(this.textBox3);
            this.Th.Controls.Add(this.textBox4);
            this.Th.Controls.Add(this.labelControl4);
            this.Th.Controls.Add(this.labelControl5);
            this.Th.Controls.Add(this.textBox2);
            this.Th.Controls.Add(this.textBox1);
            this.Th.Controls.Add(this.labelControl3);
            this.Th.Controls.Add(this.labelControl1);
            this.Th.Controls.Add(this.dtpNgaythanhtoan);
            this.Th.Controls.Add(this.btnVesinh);
            this.Th.Controls.Add(this.btnGiatdo);
            this.Th.Controls.Add(this.btnInternet);
            this.Th.Controls.Add(this.btnXemay);
            this.Th.Controls.Add(this.btnXedap);
            this.Th.Controls.Add(this.labelControl8);
            this.Th.Location = new System.Drawing.Point(69, 25);
            this.Th.Margin = new System.Windows.Forms.Padding(4);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(651, 383);
            this.Th.TabIndex = 69;
            this.Th.Text = "Thông tin hóa đơn";
            // 
            // btnTong
            // 
            this.btnTong.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Appearance.Options.UseFont = true;
            this.btnTong.Location = new System.Drawing.Point(66, 326);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(122, 34);
            this.btnTong.TabIndex = 71;
            this.btnTong.Text = "Tổng ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(219, 330);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(325, 23);
            this.textBox5.TabIndex = 70;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(467, 208);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 23);
            this.textBox3.TabIndex = 68;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 206);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 23);
            this.textBox4.TabIndex = 67;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(359, 209);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 21);
            this.labelControl4.TabIndex = 66;
            this.labelControl4.Text = "Tiền nước";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(55, 206);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 21);
            this.labelControl5.TabIndex = 65;
            this.labelControl5.Text = "Tiền điện";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 164);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 23);
            this.textBox2.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 163);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 63;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(359, 165);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 21);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Tiền rác";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 163);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 21);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Tiền phòng";
            // 
            // dtpNgaythanhtoan
            // 
            this.dtpNgaythanhtoan.Location = new System.Drawing.Point(219, 110);
            this.dtpNgaythanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaythanhtoan.Name = "dtpNgaythanhtoan";
            this.dtpNgaythanhtoan.Size = new System.Drawing.Size(325, 23);
            this.dtpNgaythanhtoan.TabIndex = 36;
            // 
            // btnVesinh
            // 
            this.btnVesinh.AutoSize = true;
            this.btnVesinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVesinh.Location = new System.Drawing.Point(57, 244);
            this.btnVesinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnVesinh.Name = "btnVesinh";
            this.btnVesinh.Size = new System.Drawing.Size(86, 25);
            this.btnVesinh.TabIndex = 35;
            this.btnVesinh.Text = "Vệ sinh";
            this.btnVesinh.UseVisualStyleBackColor = true;
            this.btnVesinh.CheckedChanged += new System.EventHandler(this.btnVesinh_CheckedChanged);
            // 
            // btnGiatdo
            // 
            this.btnGiatdo.AutoSize = true;
            this.btnGiatdo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiatdo.Location = new System.Drawing.Point(384, 278);
            this.btnGiatdo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiatdo.Name = "btnGiatdo";
            this.btnGiatdo.Size = new System.Drawing.Size(86, 25);
            this.btnGiatdo.TabIndex = 34;
            this.btnGiatdo.Text = "Giặt đồ";
            this.btnGiatdo.UseVisualStyleBackColor = true;
            // 
            // btnInternet
            // 
            this.btnInternet.AutoSize = true;
            this.btnInternet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternet.Location = new System.Drawing.Point(240, 241);
            this.btnInternet.Margin = new System.Windows.Forms.Padding(4);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(92, 25);
            this.btnInternet.TabIndex = 33;
            this.btnInternet.Text = "Internet";
            this.btnInternet.UseVisualStyleBackColor = true;
            // 
            // btnXemay
            // 
            this.btnXemay.AutoSize = true;
            this.btnXemay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemay.Location = new System.Drawing.Point(55, 278);
            this.btnXemay.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemay.Name = "btnXemay";
            this.btnXemay.Size = new System.Drawing.Size(87, 25);
            this.btnXemay.TabIndex = 32;
            this.btnXemay.Text = "Xe máy";
            this.btnXemay.UseVisualStyleBackColor = true;
            // 
            // btnXedap
            // 
            this.btnXedap.AutoSize = true;
            this.btnXedap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXedap.Location = new System.Drawing.Point(240, 278);
            this.btnXedap.Margin = new System.Windows.Forms.Padding(4);
            this.btnXedap.Name = "btnXedap";
            this.btnXedap.Size = new System.Drawing.Size(84, 25);
            this.btnXedap.TabIndex = 31;
            this.btnXedap.Text = "Xe đạp";
            this.btnXedap.UseVisualStyleBackColor = true;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(55, 113);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(122, 21);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Ngày thanh toán";
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoaDon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 668);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemkhutrocn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtKhachtro);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Th);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "XtraForm3";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaTroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).EndInit();
            this.Th.ResumeLayout(false);
            this.Th.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemkhutrocn;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtKhachtro;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl Th;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.CheckBox btnVesinh;
        private System.Windows.Forms.CheckBox btnGiatdo;
        private System.Windows.Forms.CheckBox btnInternet;
        private System.Windows.Forms.CheckBox btnXemay;
        private System.Windows.Forms.CheckBox btnXedap;
        private System.Windows.Forms.DateTimePicker dtpNgaythanhtoan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnTong;
        private System.Windows.Forms.TextBox textBox5;
        private QLNhaTroDataSet qLNhaTroDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLNhaTroDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn triGiaDataGridViewTextBoxColumn;
    }
}