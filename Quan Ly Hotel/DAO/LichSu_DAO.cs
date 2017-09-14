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
    public class LichSu_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả khách hàng
        public static List<LichSu_DTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from lichsukhachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSu_DTO> lstKhachHang = new List<DTO.LichSu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSu_DTO kh = new LichSu_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SHo = dt.Rows[i]["ho"].ToString();
                kh.STen = dt.Rows[i]["ten"].ToString();
                kh.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                kh.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());

                kh.SSDT = dt.Rows[i]["sdt"].ToString();
                kh.SCMND = dt.Rows[i]["cmnd"].ToString();
                kh.SMaPhong = dt.Rows[i]["maphong"].ToString();
                kh.SEmail = dt.Rows[i]["email"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SQuocTich = dt.Rows[i]["quoctich"].ToString();
                kh.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                kh.DtNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());

                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

        // Tìm ds khách hàng theo họ và tên, trả về null nếu không thấy
        public static List<LichSu_DTO> TimKhachHangTheoHoTen(string ho, string ten)
        {
            string sTruyVan = string.Format(@"select * from lichsukhachhang where ho like '%{0}%' and ten like '%{1}%'", ho, ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSu_DTO> lstKhachHang = new List<DTO.LichSu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSu_DTO kh = new LichSu_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SHo = dt.Rows[i]["ho"].ToString();
                kh.STen = dt.Rows[i]["ten"].ToString();
                kh.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                kh.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                kh.SSDT = dt.Rows[i]["sdt"].ToString();
                kh.SCMND = dt.Rows[i]["cmnd"].ToString();
                kh.SMaPhong = dt.Rows[i]["maphong"].ToString();
                kh.SEmail = dt.Rows[i]["email"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SQuocTich = dt.Rows[i]["quoctich"].ToString();
                kh.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                kh.DtNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());

                lstKhachHang.Add(kh);
            }

            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
        // Tìm ds khách hàng theo tên, trả về null nếu không thấy
        public static List<LichSu_DTO> TimKhachHangTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from lichsukhachhang where ten like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LichSu_DTO> lstKhachHang = new List<DTO.LichSu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSu_DTO kh = new LichSu_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SHo = dt.Rows[i]["ho"].ToString();
                kh.STen = dt.Rows[i]["ten"].ToString();
                kh.SGioiTinh = dt.Rows[i]["gioitinh"].ToString();
                kh.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                kh.SSDT = dt.Rows[i]["sdt"].ToString();
                kh.SCMND = dt.Rows[i]["cmnd"].ToString();
                kh.SMaPhong = dt.Rows[i]["maphong"].ToString();
                kh.SEmail = dt.Rows[i]["email"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SQuocTich = dt.Rows[i]["quoctich"].ToString();
                kh.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                kh.DtNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());

                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

        // Thêm khách hàng
        public static bool ThemKhachHang(LichSu_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into lichsukhachhang values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}')"
                , kh.SMaKH, kh.SHo, kh.STen, kh.SGioiTinh, kh.DtNgaySinh, kh.SSDT, kh.SCMND, kh.SMaPhong, kh.SEmail, kh.SDiaChi, kh.SQuocTich, kh.DtNgayDen, kh.DtNgayDi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
