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
    public partial class trangthai2 : Form
    {
        public trangthai2()
        {
            InitializeComponent();
        }

        private void dgTrangThaiPhong_Click(object sender, EventArgs e)
        { /*
            DataGridViewRow r = new DataGridViewRow();
            r = dgTrangThaiPhong.SelectedRows[0];
            cbb_chonphong.Text = r.Cells["SMaPhong"].Value.ToString();
            cbb_trangthai.Text = r.Cells["STrangThai"].Value.ToString();
            txt_giaphong.Text = r.Cells["SGiaPhong"].Value.ToString();
            txt_tenphong.Text = r.Cells["STenPhong"].Value.ToString(); */
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HienThiTrangThaiPhongLenDatagrid()
        {
            List<TrangThaiPhong_DTO> lstTrangThaiPhong = TrangThaiPhong_BUS.LayDSTrangThaiPhong();
            dgTrangThaiPhong.DataSource = lstTrangThaiPhong;

            dgTrangThaiPhong.Columns["SMaPhong"].HeaderText = "Mã Phòng";
            dgTrangThaiPhong.Columns["STenPhong"].HeaderText = "Tên Phòng";
            dgTrangThaiPhong.Columns["SGiaPhong"].HeaderText = "Giá Phòng";
            dgTrangThaiPhong.Columns["STrangThai"].HeaderText = "Trạng Thái";

        }

        private void trangthai2_Load(object sender, EventArgs e)
        {
            HienThiTrangThaiPhongLenDatagrid();



            //combobox phòng
            List<TrangThaiPhong_DTO> lst = TrangThaiPhong_BUS.LayPhong();
            cbb_chonphong.DataSource = lst;
            TrangThaiPhong_DTO d = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";

            lst.Insert(0, d);
            cbb_chonphong.ValueMember = "SMaPhong";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (cbb_chonphong.Text == "" || cbb_trangthai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã phòng và trạng thái!");
                return;
            }

            TrangThaiPhong_DTO ttp = new TrangThaiPhong_DTO();

            ttp.SMaPhong = cbb_chonphong.Text;
            // ttp.STenPhong = cbb_tenphong.Text;
            ttp.STrangThai = cbb_trangthai.Text;
            ttp.SGiaPhong = txt_giaphong.Text;
            ttp.STenPhong = txt_tenphong.Text;

            if (TrangThaiPhong_BUS.CapNhatTrangThai(ttp) == true)
            {
                HienThiTrangThaiPhongLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin!");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string trangthai = cbb_trangthai.Text;

            List<TrangThaiPhong_DTO> lstTrangThai = TrangThaiPhong_BUS.TimPhongTheoTrangThai(trangthai);
            if (lstTrangThai == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgTrangThaiPhong.DataSource = lstTrangThai;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trangthai2_Load_1(object sender, EventArgs e)
        {
            HienThiTrangThaiPhongLenDatagrid();



            //combobox phòng
            List<TrangThaiPhong_DTO> lst = TrangThaiPhong_BUS.LayPhong();
            cbb_chonphong.DataSource = lst;
            TrangThaiPhong_DTO d = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";

            lst.Insert(0, d);
            cbb_chonphong.ValueMember = "SMaPhong";
        }
    }
}
