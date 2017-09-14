using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhong_DTO
    {
        private string sMaPhong;
        public string SMaPhong
        {
            get { return sMaPhong; }
            set { sMaPhong = value; }
        }

        private string sTenPhong;
        public string STenPhong
        {
            get { return sTenPhong; }
            set { sTenPhong = value; }
        }

        private string sGiaPhong;
        public string SGiaPhong
        {
            get { return sGiaPhong; }
            set { sGiaPhong = value; }
        }

        private string sTrangThai;
        public string STrangThai
        {
            get { return sTrangThai; }
            set { sTrangThai = value; }
        }
    }
}
