using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DichVu_BUS
    {
        //Lấy DS dịch vụ
        public static List<DichVu_DTO> LayDSDichVu()
        {
            return DichVu_DAO.LayDSDichVu();
        }


        //Lấy một dịch vụ theo stt
        public static DichVu_DTO TimDichVuTheoSTT(string stt)
        {
            return DichVu_DAO.TimDichVuTheoSTT(stt);
        }

        //Lấy dịch vụ theo mã phòng
        public static List<DichVu_DTO> TimDichVuTheoMaPhong(string maphong)
        {
            return DichVu_DAO.LayDSDichVuTheoMaPhong(maphong);
        }

        //Thêm dịch vụ cho 1 phòng
        public static bool ThemDichVu(DichVu_DTO dv)
        {
            return DichVu_DAO.ThemDichVu(dv);
        }

        //Sửa dịch vụ cho 1 phòng
        public static bool SuaDichVu(DichVu_DTO dv)
        {
            return DichVu_DAO.SuaDichVu(dv);
        }

        //Xóa dịch vụ cho 1 phòng
        public static bool XoaDichVu(DichVu_DTO dv)
        {
            return DichVu_DAO.XoaDichVu(dv);
        }
    }
}
