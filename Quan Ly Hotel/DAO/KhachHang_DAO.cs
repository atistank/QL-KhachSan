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
    public class KhachHang_DAO
    {

        static SqlConnection con;

        // Lấy danh sách tất cả khách hàng
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
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

                //kh.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());

                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

        // Tìm ds khách hàng theo họ và tên, trả về null nếu không thấy
        public static List<KhachHang_DTO> TimKhachHangTheoHoTen(string ho, string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where ho like '%{0}%' and ten like '%{1}%'", ho, ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
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

                lstKhachHang.Add(kh);
            }

            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
        // Tìm ds khách hàng theo tên, trả về null nếu không thấy
        public static List<KhachHang_DTO> TimKhachHangTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where ten like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
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

                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

        // Lấy thông tin khách hàng có mã ma, trả về null nếu không thấy
        public static KhachHang_DTO TimKhachHangTheoMa(string makh)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makh=N'{0}'", makh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();

            kh.SMaKH = dt.Rows[0]["makh"].ToString();
            kh.SHo = dt.Rows[0]["ho"].ToString();
            kh.STen = dt.Rows[0]["ten"].ToString();
            kh.SGioiTinh = dt.Rows[0]["gioitinh"].ToString();
            kh.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            kh.SSDT = dt.Rows[0]["sdt"].ToString();
            kh.SCMND = dt.Rows[0]["cmnd"].ToString();
            kh.SMaPhong = dt.Rows[0]["maphong"].ToString();
            kh.SEmail = dt.Rows[0]["email"].ToString();
            kh.SDiaChi = dt.Rows[0]["diachi"].ToString();
            kh.SQuocTich = dt.Rows[0]["quoctich"].ToString();
            kh.DtNgayDen = DateTime.Parse(dt.Rows[0]["ngayden"].ToString());

            DataProvider.DongKetNoi(con);
            return kh;
        }

        // Lấy danh sách các khách hàng có mã phòng
        public static List<KhachHang_DTO> LayDSKhachHangTheoMaPhong(string maphong)
        {
            string sTruyVan = string.Format(@"select * from khachhang where maphong=N'{0}'", maphong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();

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
             //   kh.DtNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());

                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

        // Thêm khách hàng
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}','{10}',N'{11}')"
                ,kh.SMaKH,kh.SHo,kh.STen,kh.SGioiTinh,kh.DtNgaySinh,kh.SSDT,kh.SCMND,kh.SMaPhong,kh.SEmail,kh.SDiaChi,kh.SQuocTich,kh.DtNgayDen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Sửa khách hàng
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"update khachhang set ho=N'{0}',ten=N'{1}',gioitinh=N'{2}',ngaysinh='{3}',sdt=N'{4}', cmnd=N'{5}', maphong=N'{6}', email=N'{7}', diachi=N'{8}', quoctich=N'{9}', ngayden=N'{10}' where makh=N'{11}'", kh.SHo, kh.STen, kh.SGioiTinh, kh.DtNgaySinh, kh.SSDT, kh.SCMND, kh.SMaPhong, kh.SEmail, kh.SDiaChi, kh.SQuocTich, kh.DtNgayDen, kh.SMaKH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // xóa thì ok
        // Xóa khách hàng
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"delete from khachhang where MaKH=N'{0}'", kh.SMaKH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
