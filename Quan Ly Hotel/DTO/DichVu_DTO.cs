using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu_DTO
    {
        private string sSTT;
        public string SSTT
        {
            get { return sSTT; }
            set { sSTT= value; }
        }

        private string sMaDichVu;
        public string SMaDichVu
        {
            get { return sMaDichVu; }
            set { sMaDichVu = value; }
        }

        private string sTenDichVu;
        public string STenDichVu
        {
            get { return sTenDichVu; }
            set { sTenDichVu = value; }
        }

        private string sMaPhong;
        public string SMaPhong
        {
            get { return sMaPhong; }
            set { sMaPhong = value; }
        }

        private DateTime dtNgaySuDung;
        public DateTime DtNgaySuDung
        {
            get { return dtNgaySuDung; }
            set { dtNgaySuDung = value; }
        }
    }
}
