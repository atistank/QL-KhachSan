using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThanhToan_BUS
    {
        //Lấy DS thanh toán
        public static List<ThanhToan_DTO> LayDSThanhToan()
        {
            return ThanhToan_DAO.LayDSThanhToan();
        }

        //Lấy ds thanh toán theo mã phòng
        public static List<ThanhToan_DTO> LayDSThanhToanTheoMaPhong(string maphong)
        {
            return ThanhToan_DAO.LayDSThanhToanTheoMaPhong(maphong);
        }

        //Thêm 1 hóa đơn thanh toán
        public static bool ThemThanhToan(ThanhToan_DTO tt)
        {
            return ThanhToan_DAO.ThemThanhToan(tt);
        }
    }
}
