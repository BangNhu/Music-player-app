
namespace QLNhaTro.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAnhienmatkhau = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatkhau = new System.Windows.Forms.MaskedTextBox();
            this.txtTentaikhoan = new System.Windows.Forms.TextBox();
            this.llbQuentaikhoan = new System.Windows.Forms.LinkLabel();
            this.chENhotaikhoan = new DevExpress.XtraEditors.CheckEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chENhotaikhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAnhienmatkhau);
            this.groupControl1.Controls.Add(this.txtMatkhau);
            this.groupControl1.Controls.Add(this.txtTentaikhoan);
            this.groupControl1.Controls.Add(this.llbQuentaikhoan);
            this.groupControl1.Controls.Add(this.chENhotaikhoan);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnDangnhap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(81, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(577, 300);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // btnAnhienmatkhau
            // 
            this.btnAnhienmatkhau.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAnhienmatkhau.Appearance.Options.UseBackColor = true;
            this.btnAnhienmatkhau.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnAnhienmatkhau.AppearanceHovered.Options.UseBackColor = true;
            this.btnAnhienmatkhau.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnAnhienmatkhau.AppearancePressed.Options.UseBackColor = true;
            this.btnAnhienmatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnhienmatkhau.ImageOptions.Image")));
            this.btnAnhienmatkhau.Location = new System.Drawing.Point(454, 120);
            this.btnAnhienmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnhienmatkhau.Name = "btnAnhienmatkhau";
            this.btnAnhienmatkhau.Size = new System.Drawing.Size(32, 31);
            this.btnAnhienmatkhau.TabIndex = 13;
            this.btnAnhienmatkhau.Click += new System.EventHandler(this.btnAnhienmatkhau_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(199, 120);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(284, 28);
            this.txtMatkhau.TabIndex = 12;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtTentaikhoan
            // 
            this.txtTentaikhoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentaikhoan.Location = new System.Drawing.Point(199, 63);
            this.txtTentaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTentaikhoan.Name = "txtTentaikhoan";
            this.txtTentaikhoan.Size = new System.Drawing.Size(284, 28);
            this.txtTentaikhoan.TabIndex = 11;
            // 
            // llbQuentaikhoan
            // 
            this.llbQuentaikhoan.AutoSize = true;
            this.llbQuentaikhoan.Location = new System.Drawing.Point(364, 186);
            this.llbQuentaikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbQuentaikhoan.Name = "llbQuentaikhoan";
            this.llbQuentaikhoan.Size = new System.Drawing.Size(108, 17);
            this.llbQuentaikhoan.TabIndex = 8;
            this.llbQuentaikhoan.TabStop = true;
            this.llbQuentaikhoan.Text = "Quên tài khoản?";
            // 
            // chENhotaikhoan
            // 
            this.chENhotaikhoan.Location = new System.Drawing.Point(26, 182);
            this.chENhotaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.chENhotaikhoan.Name = "chENhotaikhoan";
            this.chENhotaikhoan.Properties.Caption = "Nhớ tài khoản";
            this.chENhotaikhoan.Size = new System.Drawing.Size(176, 21);
            this.chENhotaikhoan.TabIndex = 7;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.btnHuy.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.Appearance.Options.UseBorderColor = true;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Location = new System.Drawing.Point(302, 234);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 38);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDangnhap.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.btnDangnhap.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDangnhap.Appearance.Options.UseBackColor = true;
            this.btnDangnhap.Appearance.Options.UseBorderColor = true;
            this.btnDangnhap.Appearance.Options.UseFont = true;
            this.btnDangnhap.Appearance.Options.UseForeColor = true;
            this.btnDangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangnhap.Location = new System.Drawing.Point(130, 234);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(125, 38);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên tài khoản";
            // 
            // FrmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 341);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmLogin.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chENhotaikhoan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.LinkLabel llbQuentaikhoan;
        private DevExpress.XtraEditors.CheckEdit chENhotaikhoan;
        private System.Windows.Forms.MaskedTextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTentaikhoan;
        private DevExpress.XtraEditors.SimpleButton btnAnhienmatkhau;
    }
}