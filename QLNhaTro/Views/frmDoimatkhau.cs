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
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

       // string matkhaucu = "123456";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapnhatmk_Click(object sender, EventArgs e)
        {
            if (txtMatkhaucu.Text != "123456")
            {
                MessageBox.Show("Nhập sai mật khẩu!");
                txtMatkhaucu.ForeColor = Color.Red;
            }  
            else if(txtMatkhaumoi1.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa tối thiểu 6 kí tự!");
                txtMatkhaucu.ForeColor = Color.Black;
                txtMatkhaumoi1.ForeColor = Color.Red;
                txtMatkhaumoi2.ForeColor = Color.Red;
            }    
            else if(txtMatkhaumoi1.Text != txtMatkhaumoi2.Text)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ!");
            }    
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                this.Close();
            }
           
        }
    }
}