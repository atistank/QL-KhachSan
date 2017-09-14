using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class thongtinphong2 : Form
    {
        public thongtinphong2()
        {
            InitializeComponent();
        }
        public string phanquyen = "1";


        private void thongtinphong2_MouseMove(object sender, MouseEventArgs e)
        {
 
        }

        private void ketqua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HienThiDSKhachHangLenDatagrid()
        {
            List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.LayDSKhachHang();
            dgDSKhachHang.DataSource = lstKhachHang;

            dgDSKhachHang.Columns["SMaKH"].HeaderText = "Mã số";
            dgDSKhachHang.Columns["SHo"].HeaderText = "Họ";
            dgDSKhachHang.Columns["STen"].HeaderText = "Tên";
            dgDSKhachHang.Columns["SGioiTinh"].HeaderText = "Phái";
            dgDSKhachHang.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgDSKhachHang.Columns["SSDT"].HeaderText = "SĐT";
            dgDSKhachHang.Columns["SCMND"].HeaderText = "CMND";
            dgDSKhachHang.Columns["SMaPhong"].HeaderText = "Phòng";
            dgDSKhachHang.Columns["SEmail"].HeaderText = "Email";
            dgDSKhachHang.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgDSKhachHang.Columns["SQuocTich"].HeaderText = "Quốc tịch";
            dgDSKhachHang.Columns["DtNgayDen"].HeaderText = "Ngày đến";

        }
        private void thongtinphong2_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHangLenDatagrid();
            //dgDSKhachHang.Refresh();
            List<TrangThaiPhong_DTO> lst = TrangThaiPhong_BUS.LayPhong();
            cbb_chonphong.DataSource = lst;
            TrangThaiPhong_DTO d = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";

            lst.Insert(0, d);
            cbb_chonphong.ValueMember = "SMaPhong";



            //combobox phòng tìm kiếm
            List<TrangThaiPhong_DTO> lst3 = TrangThaiPhong_BUS.LayPhong();
            cbb_phong.DataSource = lst;
            TrangThaiPhong_DTO d3 = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";

            lst3.Insert(0, d);
            cbb_phong.ValueMember = "SMaPhong";
            // phan quyen
            if (phanquyen == "Administrator")
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

        }
        

        private void QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Mainchinh2 f = new Mainchinh2();
            this.Hide();
            f.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void date_time_ngaysinh_onValueChanged(object sender, EventArgs e)
        {

        }

        private void rad_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_dienthoai_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_ho_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_makh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txt_makh.Text == "" || KhachHang_BUS.TimKhachHangTheoMa(txt_makh.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng!");
                return;
            }

            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txt_makh.Text;
            kh.SHo = txt_ho.Text;
            kh.STen = txt_ten.Text;
            if (rad_nam.Checked == true)
            {
                kh.SGioiTinh = "Nam";
            }
            else
            {
                kh.SGioiTinh = "Nữ";
            }
            kh.DtNgaySinh = DateTime.Parse(date_time_ngaysinh.Text);

            kh.SSDT = txt_dienthoai.Text;
            kh.SCMND = txt_cmnd.Text;
            kh.SMaPhong = cbb_phong.Text;
            kh.SEmail = txt_email.Text;
            kh.SDiaChi = txt_diachi.Text;
          
            kh.DtNgayDen = DateTime.Parse(date_time_ngayden.Text);

            if (KhachHang_BUS.SuaKhachHang(kh) == true)
            {
                HienThiDSKhachHangLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin!");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            txt_dienthoai.Text = "";
            txt_cmnd.Text = "";
            cbb_phong.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_ho.Text = "";
            txt_ten.Text = "";
           
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txt_makh.Text;

            if (KhachHang_BUS.XoaKhachHang(kh) == true)
            {
                HienThiDSKhachHangLenDatagrid();
                MessageBox.Show("Đã xóa khách hàng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
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

           
            kh1.SSDT = txt_dienthoai.Text;
            kh1.SCMND = txt_cmnd.Text;
            kh1.SMaPhong = cbb_chonphong.Text;
            kh1.SEmail = txt_email.Text;
            kh1.SDiaChi = txt_diachi.Text;
            
          //  kh1.DtNgayDen = DateTime.Parse(date_time_ngayden.Text);

            if (KhachHang_BUS.ThemKhachHang(kh1) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm khách hàng!");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txt_ten_OnValueChanged(object sender, EventArgs e)
        {

        }
        // Tìm
        private void button1_Click(object sender, EventArgs e)
        {
            string ho = txt_timho.Text;
            string ten = txt_timten.Text;
            List<KhachHang_DTO> lstkh = KhachHang_BUS.TimKhachHangTheoHoTen(ho, ten);
            if (lstkh == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSKhachHang.DataSource = lstkh;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            string maphong = cbb_phong.Text;

            List<KhachHang_DTO> lstKH = KhachHang_BUS.TimKhachHangTheoMaPhong(maphong);
            if (lstKH == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSKhachHang.DataSource = lstKH;
        }

        private void dgDSKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSKhachHang.SelectedRows[0];
            txt_makh.Text = r.Cells["SMaKH"].Value.ToString();
            txt_ho.Text = r.Cells["SHo"].Value.ToString();
            txt_ten.Text = r.Cells["STen"].Value.ToString();
            date_time_ngaysinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            if (r.Cells["SGioiTinh"].Value.ToString() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            txt_dienthoai.Text = r.Cells["SSDT"].Value.ToString();
            txt_email.Text = r.Cells["SEmail"].Value.ToString();
            txt_cmnd.Text = r.Cells["SCMND"].Value.ToString();
            txt_diachi.Text = r.Cells["SDiaChi"].Value.ToString();
          
            cbb_phong.Text = r.Cells["SMaPhong"].Value.ToString();
            date_time_ngayden.Text = r.Cells["DtNgayDen"].Value.ToString();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
        }

        private void txt_ho_Click(object sender, EventArgs e)
        {
            txt_ho.Text = " ";
        }

        private void txt_timho_Click(object sender, EventArgs e)
        {
            txt_timho.Text = "";
        }

        private void txt_timten_Click(object sender, EventArgs e)
        {
            txt_timten.Text = "";   
        }
    }
}
