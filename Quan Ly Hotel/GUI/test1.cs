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
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }
        private void HienThiDSKhachHangLenDatagrid()
        {
            List<LichSu_DTO> lstKhachHang = LichSu_BUS.LayDSKhachHang();
            dglichsu.DataSource = lstKhachHang;

            dglichsu.Columns["SMaKH"].HeaderText = "Mã số";
            dglichsu.Columns["SHo"].HeaderText = "Họ";
            dglichsu.Columns["STen"].HeaderText = "Tên";
            dglichsu.Columns["SGioiTinh"].HeaderText = "Phái";
            dglichsu.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dglichsu.Columns["SSDT"].HeaderText = "SĐT";
            dglichsu.Columns["SCMND"].HeaderText = "CMND";
            dglichsu.Columns["SMaPhong"].HeaderText = "Phòng";
            dglichsu.Columns["SEmail"].HeaderText = "Email";
            dglichsu.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dglichsu.Columns["SQuocTich"].HeaderText = "Quốc tịch";
            dglichsu.Columns["DtNgayDen"].HeaderText = "Ngày đến";
            dglichsu.Columns["DtNgayDi"].HeaderText = "Ngày đi";

        }

        private void test1_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHangLenDatagrid();
        }
    }
}
