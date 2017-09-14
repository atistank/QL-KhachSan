using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class TrangThaiPhong_DAO
    {
        static SqlConnection con;

        //lấy danh sách phòng
        public static List<TrangThaiPhong_DTO> LayPhong()
        {
            string sTruyVan = "select * from thongtinphong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstPhong = new List<TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO p = new TrangThaiPhong_DTO();
                p.SMaPhong = dt.Rows[i]["maphong"].ToString();
                p.STenPhong = dt.Rows[i]["tenphong"].ToString();
                p.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                p.STrangThai = dt.Rows[i]["tinhtrang"].ToString();
                

                lstPhong.Add(p);
            }
            DataProvider.DongKetNoi(con);
            return lstPhong;
        }

        //lấy giá phòng
        public static List<TrangThaiPhong_DTO> LayGia()
        {
            string sTruyVan = "select * from thongtinphong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstDV = new List<TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO p = new TrangThaiPhong_DTO();
                p.SMaPhong = dt.Rows[i]["maphong"].ToString();
                p.STenPhong = dt.Rows[i]["tenphong"].ToString();
                p.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                p.STrangThai = dt.Rows[i]["tinhtrang"].ToString();

                lstDV.Add(p);
            }
            DataProvider.DongKetNoi(con);
            return lstDV;
        }

        // Lấy danh sách tất cả phòng có trạng thái

        public static List<TrangThaiPhong_DTO> LayDSTrangThaiPhong()
        {
            string sTruyVan = "select * from thongtinphong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstTrangThaiPhong = new List<DTO.TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO ttp = new TrangThaiPhong_DTO();
                ttp.SMaPhong = dt.Rows[i]["maphong"].ToString();
                ttp.STenPhong = dt.Rows[i]["tenphong"].ToString();
                ttp.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                ttp.STrangThai = dt.Rows[i]["tinhtrang"].ToString();
                
                lstTrangThaiPhong.Add(ttp);
            }
            DataProvider.DongKetNoi(con);
            return lstTrangThaiPhong;
        }


        // Lấy danh sách phòng theo trạng thái
        public static List<TrangThaiPhong_DTO> LayDSPhongTheoTrangThai(string trangthai)
        {
            string sTruyVan = string.Format(@"select * from thongtinphong where tinhtrang=N'{0}'", trangthai);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstTrangThaiPhong = new List<DTO.TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO dv = new TrangThaiPhong_DTO();

                dv.SMaPhong = dt.Rows[i]["maphong"].ToString();
                dv.STenPhong = dt.Rows[i]["tenphong"].ToString();
                dv.SGiaPhong = dt.Rows[i]["giaphong"].ToString();
                dv.STrangThai = dt.Rows[i]["tinhtrang"].ToString();
                
                lstTrangThaiPhong.Add(dv);
            }
            DataProvider.DongKetNoi(con);
            return lstTrangThaiPhong;
        }

        // cập nhật trạng thái phòng sử dụng dịch vụ
        public static bool CapNhatTrangThai(TrangThaiPhong_DTO ttp)
        {
            string sTruyVan = string.Format(@"update thongtinphong set tenphong=N'{0}', giaphong=N'{1}', tinhtrang=N'{2}' where maphong=N'{3}'", ttp.STenPhong, ttp.SGiaPhong, ttp.STrangThai, ttp.SMaPhong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
