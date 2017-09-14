using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string ma)
        {
            return DangNhap_DAO.TimTaiKhoan(ma);
        }
        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            return DangNhap_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau(ma);
        }
        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            return DangNhap_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(ma, m);
        }

        //Lấy tên đăng nhập
        public static DangNhap_DTO TimTenDangNhap(string dn)
        {
            return DangNhap_DAO.TimTenDangNhap(dn);
        }

        //Lấy mật khẩu
        public static DangNhap_DTO TimMK(string mk)
        {
            return DangNhap_DAO.TimMK(mk);
        }

        //Cập nhật thông tin đăng nhập
        public static bool Doi_Mat_Mau(DangNhap_DTO up)
        {
            return DangNhap_DAO.Doi_Mat_Khau(up);
        }
    }
}
