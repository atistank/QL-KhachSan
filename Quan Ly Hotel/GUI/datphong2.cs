using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class datphong2 : Form
    {
        public string Phanquyen;
        public datphong2()
        {
            InitializeComponent();
        }

        private void datphong2_Load(object sender, EventArgs e)
        {
            if (Phanquyen == "Administrator")
            {
                txtphanquyen.Text = "  Administrator";
                chucvu.Text = "Administrator";
            }
            else
            {
                avatar.Image = Properties.Resources.duyavatar;
                txtphanquyen.Text = "@Ngô Anh Duy";
                chucvu.Text = "Nhân Viên";
            }
            //combobox phòng
            List<TrangThaiPhong_DTO> lst = TrangThaiPhong_BUS.LayPhong();
            cbb_chonphong.DataSource = lst;
            TrangThaiPhong_DTO d = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";

            lst.Insert(0, d);
            cbb_chonphong.ValueMember = "SMaPhong";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainchinh2 f = new Mainchinh2();
            this.Hide();
            f.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainchinh2 f = new Mainchinh2();
            this.Hide();
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainchinh2 f = new Mainchinh2();
            this.Hide();
            f.Show();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txt_ho.Text == "" || txt_ten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }


            // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
            if (txt_makh.Text.Length > 5)
            {
                MessageBox.Show("Mã khách hàng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã khách hàng có bị trùng không
            if (KhachHang_BUS.TimKhachHangTheoMa(txt_makh.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }


            KhachHang_DTO kh1 = new KhachHang_DTO();
            kh1.SMaKH = txt_makh.Text;
            kh1.SHo = txt_ho.Text;
            kh1.STen = txt_ten.Text;

            if (rad_nam.Checked == true)
            {
                kh1.SGioiTinh = "Nam";
            }
            else
            {
                kh1.SGioiTinh = "Nữ";
            }
            //kh1.SGioiTinh = "Nam";
            kh1.DtNgaySinh = DateTime.Parse(date_time_ngaysinh.Text);
            kh1.SSDT = txt_dienthoai.Text;
            kh1.SCMND = txt_cmnd.Text;
            kh1.SMaPhong = cbb_chonphong.Text;
            kh1.SEmail = txt_email.Text;
            kh1.SDiaChi = txt_diachi.Text;
            kh1.SQuocTich = txt_quoctich.Text;
            kh1.DtNgayDen = DateTime.Parse(date_time_ngayden.Text);

            if (KhachHang_BUS.ThemKhachHang(kh1) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            //HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (chucvu.Text == "Administrator")
            {
                test1 f = new test1();
                f.Show();
            }
            else MessageBox.Show("Chỉ có quản trị viên mới truy cập được");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon !!!");
        }
    }
}
