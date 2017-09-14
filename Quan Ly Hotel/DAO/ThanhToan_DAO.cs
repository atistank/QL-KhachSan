using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;

namespace DAO
{
    public class ThanhToan_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả thanh toan
        public static List<ThanhToan_DTO> LayDSThanhToan()
        {
            string sTruyVan = "select * from thanhtoan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThanhToan_DTO> lstThanhToan = new List<DTO.ThanhToan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThanhToan_DTO tt = new ThanhToan_DTO();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                tt.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                tt.STenDichVu1 = dt.Rows[i]["tendichvu1"].ToString();
                tt.STenDichVu2 = dt.Rows[i]["tendichvu2"].ToString();
                tt.SGiaDichVu1 = dt.Rows[i]["giadichvu1"].ToString();
                tt.SGiaDichVu2 = dt.Rows[i]["giadichvu2"].ToString();
                tt.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                tt.DtNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());
                tt.SSoNgayThanhToan = dt.Rows[i]["songaythanhtoan"].ToString();
                tt.STongTien = dt.Rows[i]["tongtien"].ToString();
                
                lstThanhToan.Add(tt);
            }
            DataProvider.DongKetNoi(con);
            return lstThanhToan;
        }



        // Lấy ds thanh toán theo mã phòng
        public static List<ThanhToan_DTO> LayDSThanhToanTheoMaPhong(string maphong)
        {
            string sTruyVan = string.Format(@"select * from thanhtoan where maphong=N'{0}'", maphong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThanhToan_DTO> lstThanhToan = new List<DTO.ThanhToan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThanhToan_DTO tt = new ThanhToan_DTO();
                tt.SMaPhong = dt.Rows[i]["maphong"].ToString();
                tt.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                tt.STenDichVu1 = dt.Rows[i]["tendichvu1"].ToString();
                tt.SGiaDichVu1 = dt.Rows[i]["giadichvu1"].ToString();
                tt.STenDichVu2 = dt.Rows[i]["tendichvu2"].ToString();
                tt.SGiaDichVu2 = dt.Rows[i]["giadichvu2"].ToString();
                tt.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                tt.DtNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());
                tt.SSoNgayThanhToan = dt.Rows[i]["songaythanhtoan"].ToString();
                tt.STongTien = dt.Rows[i]["tongtien"].ToString();

                lstThanhToan.Add(tt);
            }
            DataProvider.DongKetNoi(con);
            return lstThanhToan;
        }

        // Thêm thanh toán
        public static bool ThemThanhToan(ThanhToan_DTO tt)
        {
            string sTruyVan = string.Format(@"insert into thanhtoan values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')"
                , tt.SMaPhong, tt.SGiaPhong, tt.STenDichVu1, tt.STenDichVu2, tt.SGiaDichVu1, tt.SGiaDichVu2, tt.DtNgayDen, tt.DtNgayDi, tt.SSoNgayThanhToan, tt.STongTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
