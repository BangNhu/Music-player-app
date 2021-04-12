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
using System.Configuration;
using System.Data.SqlClient;

namespace QLNhaTro.Views
{
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        public void HienThi()
        {
            string sqlSELECT = "SELECT TenNV, CMND, DienThoai, GioiTinh from dbo.NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsNhanVien.DataSource = dt;
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            String conString = ConfigurationManager.ConnectionStrings["QLNhaTro.Properties.Settings.QLNhaTroConnectionString"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }
        private void btnThemkhutrocn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT into NHANVIEN values (@TeNV,@CMND,@SDT,@Gioitinh,@MaChuTro)";
            SqlCommand cmd = new SqlCommand(insert,con);
            cmd.Parameters.AddWithValue("TeNV", txtTenNV.Text);
            cmd.Parameters.AddWithValue("CMND", txtCMND.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
           // if("Gioitinh" = 1)
            cmd.Parameters.AddWithValue("Gioitinh", radioButton2);
            //cmd.Parameters.AddWithValue("MaChuTro", txtMaChuTro);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void frmNhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}