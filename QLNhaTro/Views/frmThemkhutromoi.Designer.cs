
namespace QLNhaTro.Views
{
    partial class frmThemkhutromoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemkhutromoi));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnTenkhutro = new System.Windows.Forms.TextBox();
            this.btnDiachikhutro = new System.Windows.Forms.TextBox();
            this.btnMotakhutro = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsapxep = new DevExpress.XtraEditors.CheckButton();
            this.Th = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemkhutrocn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(89, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên khu trọ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(89, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 21);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Mô tả";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(89, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 21);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Địa chỉ";
            // 
            // btnTenkhutro
            // 
            this.btnTenkhutro.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenkhutro.Location = new System.Drawing.Point(216, 70);
            this.btnTenkhutro.Name = "btnTenkhutro";
            this.btnTenkhutro.Size = new System.Drawing.Size(254, 28);
            this.btnTenkhutro.TabIndex = 9;
            this.btnTenkhutro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDiachikhutro
            // 
            this.btnDiachikhutro.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiachikhutro.Location = new System.Drawing.Point(216, 114);
            this.btnDiachikhutro.Multiline = true;
            this.btnDiachikhutro.Name = "btnDiachikhutro";
            this.btnDiachikhutro.Size = new System.Drawing.Size(254, 68);
            this.btnDiachikhutro.TabIndex = 10;
            // 
            // btnMotakhutro
            // 
            this.btnMotakhutro.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotakhutro.Location = new System.Drawing.Point(216, 188);
            this.btnMotakhutro.Multiline = true;
            this.btnMotakhutro.Name = "btnMotakhutro";
            this.btnMotakhutro.Size = new System.Drawing.Size(254, 69);
            this.btnMotakhutro.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 239);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsapxep
            // 
            this.btnsapxep.ImageOptions.SvgImage = global::QLNhaTro.Properties.Resources.sortasc;
            this.btnsapxep.Location = new System.Drawing.Point(599, 175);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(103, 45);
            this.btnsapxep.TabIndex = 20;
            this.btnsapxep.Text = "Sắp xếp";
            // 
            // Th
            // 
            this.Th.Location = new System.Drawing.Point(46, 22);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(506, 248);
            this.Th.TabIndex = 21;
            this.Th.Text = "Thông tin khu trọ";
            this.Th.Paint += new System.Windows.Forms.PaintEventHandler(this.Th_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(756, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 32);
            this.textBox1.TabIndex = 22;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::QLNhaTro.Properties.Resources.find_32x32;
            this.btnTimKiem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(835, 225);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 32);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Sua;
            this.btnSua.Location = new System.Drawing.Point(756, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 45);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Email_Delete_icon__2_;
            this.btnXoa.Location = new System.Drawing.Point(599, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThemkhutrocn
            // 
            this.btnThemkhutrocn.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkhutrocn.Appearance.Options.UseFont = true;
            this.btnThemkhutrocn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemkhutrocn.ImageOptions.Image")));
            this.btnThemkhutrocn.Location = new System.Drawing.Point(599, 43);
            this.btnThemkhutrocn.Name = "btnThemkhutrocn";
            this.btnThemkhutrocn.Size = new System.Drawing.Size(103, 45);
            this.btnThemkhutrocn.TabIndex = 13;
            this.btnThemkhutrocn.Text = "Thêm";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QLNhaTro.Properties.Resources.Save_icon;
            this.btnLuu.Location = new System.Drawing.Point(756, 43);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 45);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnHuykhutrocn_Click);
            // 
            // frmThemkhutromoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsapxep);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemkhutrocn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMotakhutro);
            this.Controls.Add(this.btnDiachikhutro);
            this.Controls.Add(this.btnTenkhutro);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Th);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemkhutromoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm khu trọ";
            this.Load += new System.EventHandler(this.frmThemkhutromoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox btnTenkhutro;
        private System.Windows.Forms.TextBox btnDiachikhutro;
        private System.Windows.Forms.TextBox btnMotakhutro;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThemkhutrocn;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.CheckButton btnsapxep;
        private DevExpress.XtraEditors.GroupControl Th;
        private System.Windows.Forms.TextBox textBox1;
    }
}