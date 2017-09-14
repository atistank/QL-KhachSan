using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public class KhachHang_BUS
    {

        //Lấy DS khách hàng
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            return KhachHang_DAO.LayDSKhachHang();
        }

        //Lấy DS khách hàng theo họ và tên
        public static List<KhachHang_DTO> TimKhachHangTheoHoTen(string ho, string ten)
        {
            return KhachHang_DAO.TimKhachHangTheoHoTen(ho, ten);
        }

        //Lấy DS khách hàng theo tên
        public static List<KhachHang_DTO> TimKhachHangTheoTen(string ten)
        {
            return KhachHang_DAO.TimKhachHangTheoTen(ten);
        }

        //Lấy một khách hàng theo mã
        public static KhachHang_DTO TimKhachHangTheoMa(string makh)
        {
            return KhachHang_DAO.TimKhachHangTheoMa(makh);
        }

        //Lấy một khách hàng theo mã phòng
        public static List<KhachHang_DTO> TimKhachHangTheoMaPhong(string maphong)
        {
            return KhachHang_DAO.LayDSKhachHangTheoMaPhong(maphong);
        }

        //Thêm 1 khách hàng
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.ThemKhachHang(kh);
        }

        //Sửa 1 khách hàng
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SuaKhachHang(kh);
        }

        //Xóa 1 khách hàng
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.XoaKhachHang(kh);
        }
    }
}
