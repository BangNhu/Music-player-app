using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro.Views
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmMain fm = new frmMain();
        public FrmLogin()
        {
            InitializeComponent();

        }
        int dem = 0;
        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string tentk = "BangNhu", matkhau = "123456";
            DialogResult dr;
            if (txtTentaikhoan.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Hãy điền thông tin!");
            }
            else if (txtTentaikhoan.Text == tentk && matkhau == txtMatkhau.Text)
            {

                MessageBox.Show("Đăng nhập thành công!");
                frmMain f = new frmMain();
                f.Show();
                FrmLogin l = new FrmLogin();
                l.Close();
            }
            else if (txtTentaikhoan.Text != tentk || matkhau != txtMatkhau.Text)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                txtTentaikhoan.ForeColor = Color.Red;
                txtMatkhau.ForeColor = Color.Red;
                dem++;
            }
            if (txtTentaikhoan.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Hãy điền thông tin!");
            }
            if (dem == 3)
            {

                dr = MessageBox.Show("Bạn quên tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.No)
                {
                    MessageBox.Show("Hãy liên hệ với người quản lý nhà trọ để được cấp tài khoản!");
                   //code dong frmmain luon
                }
                /*  else
                  {
                      //Neu quen mat khau thi?
                  }    */
                this.Close();
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        bool a = false;
        private void btnAnhienmatkhau_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                txtMatkhau.PasswordChar = '\0';
                a = true;
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
                a = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}