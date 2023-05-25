using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DangNhap
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=TUF\SQLEXPRESS;Initial Catalog=grabfood;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select *from DangNhap where TaiKhoan= '" + tk + "' and MatKhau= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dta= cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
