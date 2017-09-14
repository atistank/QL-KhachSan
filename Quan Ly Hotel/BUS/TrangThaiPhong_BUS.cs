using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TrangThaiPhong_BUS
    {
        //Lấy DS trạng thái phòng
        public static List<TrangThaiPhong_DTO> LayDSTrangThaiPhong()
        {
            return TrangThaiPhong_DAO.LayDSTrangThaiPhong();
        }

        //Lấy phòng theo trạng thái
        public static List<TrangThaiPhong_DTO> TimPhongTheoTrangThai(string trangthai)
        {
            return TrangThaiPhong_DAO.LayDSPhongTheoTrangThai(trangthai);
        }

        //lấy giá phòng
        public static List<TrangThaiPhong_DTO> LayGia()
        {
            return TrangThaiPhong_DAO.LayGia();
        }

        //cập nhật trạng thái cho 1 phòng
        public static bool CapNhatTrangThai(TrangThaiPhong_DTO ttp)
        {
            return TrangThaiPhong_DAO.CapNhatTrangThai(ttp);
        }

        //lấy danh sách phòng
        public static List<TrangThaiPhong_DTO> LayPhong()
        {
            return TrangThaiPhong_DAO.LayPhong();
        }

    }
}
