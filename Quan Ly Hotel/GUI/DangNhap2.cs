using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using DTO;
using BUS;


namespace GUI
{
    public partial class DangNhap2 : Form
    {
        public DangNhap2()
        {
            InitializeComponent();
        }

        private void DangNhap2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu co bi bo trong 
            if (txtdangnhap.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;

            }

            // kiem tra người dùng 
            if (DangNhap_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txtdangnhap.Text) == null)
            {
                MessageBox.Show("không tìm thấy tài khoản!");
                return;
            }

            // kiem tra mật khẩu 
            if (DangNhap_BUS.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(txtdangnhap.Text, txtmatkhau.Text) == null)
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
                return;
            }
            DangNhap_DTO nd = new DangNhap_DTO();
            nd.Ten_Dang_Nhap = txtdangnhap.Text;
            nd.Mat_Khau_1 = txtmatkhau.Text;

            if (DangNhap_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txtdangnhap.Text) == null)
            {
                MessageBox.Show("Đăng Nhập Không Thành Công");
                return;

            }
            else
            {
                //MessageBox.Show("Đăng nhập thành công");
                Mainchinh2 f = new Mainchinh2();
                f.Phanquyen = txtdangnhap.Text;
                f.Show();
                this.Hide();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtdangnhap_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Mainchinh2 f = new Mainchinh2();
            f.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Mainchinh2 f = new Mainchinh2();
            f.Show();
            this.Hide();
        }

        private void txtmatkhau_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdangnhap_Click(object sender, EventArgs e)
        {
            txtdangnhap.Text = "";
        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {
            txtmatkhau.Text = "";
        }
    }
}
