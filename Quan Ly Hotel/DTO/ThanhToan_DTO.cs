using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToan_DTO
    {
        private string sMaPhong;
        public string SMaPhong
        {
            get { return sMaPhong; }
            set { sMaPhong = value; }
        }

        private string sGiaPhong;
        public string SGiaPhong
        {
            get { return sGiaPhong; }
            set { sGiaPhong = value; }
        }

        private string sTenDichVu1;
        public string STenDichVu1
        {
            get { return sTenDichVu1; }
            set { sTenDichVu1 = value; }
        }

        private string sGiaDichVu1;
        public string SGiaDichVu1
        {
            get { return sGiaDichVu1; }
            set { sGiaDichVu1 = value; }
        }

        private string sTenDichVu2;
        public string STenDichVu2
        {
            get { return sTenDichVu2; }
            set { sTenDichVu2 = value; }
        }

        private string sGiaDichVu2;
        public string SGiaDichVu2
        {
            get { return sGiaDichVu2; }
            set { sGiaDichVu2 = value; }
        }

        private DateTime dtNgayDen;
        public DateTime DtNgayDen
        {
            get { return dtNgayDen; }
            set { dtNgayDen = value; }
        }

        private DateTime dtNgayDi;
        public DateTime DtNgayDi
        {
            get { return dtNgayDi; }
            set { dtNgayDi = value; }
        }

        private string sSoNgayThanhToan;
        public string SSoNgayThanhToan
        {
            get { return sSoNgayThanhToan; }
            set { sSoNgayThanhToan = value; }
        }

        private string sTongTien;
        public string STongTien
        {
            get { return sTongTien; }
            set { sTongTien = value; }
        }

    }
}
