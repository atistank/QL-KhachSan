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
    public class DichVu_DAO
    {
        static SqlConnection con;


        // Lấy thông tin dịch vụ có stt, trả về null nếu không thấy
        public static DichVu_DTO TimDichVuTheoSTT(string stt)
        {
            string sTruyVan = string.Format(@"select * from phongsudungdichvu where stt=N'{0}'", stt);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DichVu_DTO nv = new DichVu_DTO();
            nv.SSTT = dt.Rows[0]["stt"].ToString();
            nv.SMaDichVu = dt.Rows[0]["madichvu"].ToString();
            nv.STenDichVu = dt.Rows[0]["tendichvu"].ToString();
            nv.SMaPhong = dt.Rows[0]["maphong"].ToString();
            nv.DtNgaySuDung = DateTime.Parse(dt.Rows[0]["ngaysudung"].ToString());
           

            DataProvider.DongKetNoi(con);
            return nv;
        }



        // Lấy danh sách tất cả phòng sử dụng dịch vụ
        public static List<DichVu_DTO> LayDSDichVu()
        {
            string sTruyVan = "select * from phongsudungdichvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> lstDichVu = new List<DTO.DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();
                dv.SSTT = dt.Rows[i]["stt"].ToString();
                dv.SMaDichVu = dt.Rows[i]["madichvu"].ToString();
                dv.STenDichVu = dt.Rows[i]["tendichvu"].ToString();
                dv.SMaPhong = dt.Rows[i]["maphong"].ToString();
                dv.DtNgaySuDung = DateTime.Parse(dt.Rows[i]["ngaysudung"].ToString());

                lstDichVu.Add(dv);
            }
            DataProvider.DongKetNoi(con);
            return lstDichVu;
        }
        

        // Lấy danh sách các dịch vụ có mã phòng
        public static List<DichVu_DTO> LayDSDichVuTheoMaPhong(string maphong)
        {
            string sTruyVan = string.Format(@"select * from phongsudungdichvu where maphong=N'{0}'", maphong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> lstDichVu = new List<DTO.DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();

                dv.SSTT = dt.Rows[i]["stt"].ToString();
                dv.SMaDichVu = dt.Rows[i]["madichvu"].ToString();
                dv.STenDichVu = dt.Rows[i]["tendichvu"].ToString();
                dv.SMaPhong = dt.Rows[i]["maphong"].ToString();
                dv.DtNgaySuDung = DateTime.Parse(dt.Rows[i]["ngaysudung"].ToString());
                lstDichVu.Add(dv);
            }
            DataProvider.DongKetNoi(con);
            return lstDichVu;
        }

        

        // Thêm phòng sử dụng dịch vụ
        public static bool ThemDichVu(DichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"insert into phongsudungdichvu values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')"
                , dv.SSTT, dv.SMaDichVu, dv.STenDichVu, dv.SMaPhong, dv.DtNgaySuDung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Sửa phòng sử dụng dịch vụ
        public static bool SuaDichVu(DichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"update phongsudungdichvu set madichvu=N'{0}',tendichvu=N'{1}',maphong='{2}',ngaysudung=N'{3}'  where stt=N'{4}'", dv.SMaDichVu, dv.STenDichVu, dv.SMaPhong, dv.DtNgaySuDung, dv.SSTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa phòng sử dụng dịch vụ
        public static bool XoaDichVu(DichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"delete from phongsudungdichvu where stt=N'{0}'", dv.SSTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
