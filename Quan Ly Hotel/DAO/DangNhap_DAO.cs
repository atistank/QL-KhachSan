using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DangNhap_DAO
    {
        static SqlConnection con;

        //tìm thông tin đăng nhập theo mật khẩu
        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            string sTruyVan = string.Format(@"select * from dangNhap where matkhau1=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            DangNhap_DTO nd = new DangNhap_DTO();
            nd.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            nd.Mat_Khau_2 = dt.Rows[0]["matkhau2"].ToString();
            DataProvider.DongKetNoi(con);
            return nd;
        }

        //tìm thông tin đăng nhập theo tài khoản
            
        public static DangNhap_DTO TimTaiKhoan(string ma)
        {
            string sTruyVan = string.Format(@"select *from dangNhap where tendangnhap=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            DangNhap_DTO nd = new DangNhap_DTO();
            nd.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            nd.Mat_Khau_2 = dt.Rows[0]["matkhau2"].ToString();
            DataProvider.DongKetNoi(con);
            return nd;

        }

        // Lấy thông tin đăng nhập
        public static DangNhap_DTO TimTenDangNhap(string dn)
        {
            string sTruyVan = string.Format(@"select * from dangnhap where tendangnhap=N'{0}'", dn);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DangNhap_DTO nv = new DangNhap_DTO();
            nv.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            nv.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            nv.Mat_Khau_2 = dt.Rows[0]["matkhau2"].ToString();

            DataProvider.DongKetNoi(con);
            return nv;
        }

        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            string sTruyVan = string.Format(@"select * from dangNhap where tendangnhap=N'{0}' and matkhau1=N'{1}'", ma, m);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DangNhap_DTO nd = new DangNhap_DTO();
            nd.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            nd.Mat_Khau_2 = dt.Rows[0]["matkhau2"].ToString();


            DataProvider.DongKetNoi(con);
            return nd;
        }
        // Lấy thông tin đăng nhập
        public static DangNhap_DTO TimMK(string mk)
        {
            string sTruyVan = string.Format(@"select * from dangnhap where matkhau1=N'{0}'", mk);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DangNhap_DTO nv = new DangNhap_DTO();
            nv.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            nv.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            nv.Mat_Khau_2 = dt.Rows[0]["matkhau2"].ToString();

            DataProvider.DongKetNoi(con);
            return nv;
        }

        public static DangNhap_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string tendangnhap)
        {
            string sTruyVan = string.Format(@"select *from dangNhap where tendangnhap=N'{0}'", tendangnhap);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            DangNhap_DTO dn = new DangNhap_DTO();
            dn.Ten_Dang_Nhap = dt.Rows[0]["tendangnhap"].ToString();
            dn.Mat_Khau_1 = dt.Rows[0]["matkhau1"].ToString();
            

            DataProvider.DongKetNoi(con);
            return dn;

        }


        //Đổi mật khẩu
        public static bool Doi_Mat_Khau(DangNhap_DTO dn)
        {
            string sTruyVan = string.Format(@"update dangNhap set matkhau1=N'{0}' where tendangnhap=N'{1}'", dn.Mat_Khau_1, dn.Ten_Dang_Nhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        

    }
}
