using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LichSu_BUS
    {
        //Lấy DS khách hàng
        public static List<LichSu_DTO> LayDSKhachHang()
        {
            return LichSu_DAO.LayDSKhachHang();
        }

        //Lấy DS khách hàng theo họ và tên
        public static List<LichSu_DTO> TimKhachHangTheoHoTen(string ho, string ten)
        {
            return LichSu_DAO.TimKhachHangTheoHoTen(ho, ten);
        }

        //Lấy DS khách hàng theo tên
        public static List<LichSu_DTO> TimKhachHangTheoTen(string ten)
        {
            return LichSu_DAO.TimKhachHangTheoTen(ten);
        }

        //Thêm 1 khách hàng
        public static bool ThemKhachHang(LichSu_DTO kh)
        {
            return LichSu_DAO.ThemKhachHang(kh);
        }
    }
}
