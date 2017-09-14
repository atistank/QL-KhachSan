using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        public string TenDangNhap;
        public string MatKhau1;
        public string MatKhau2;

        public string Ten_Dang_Nhap
        {
            get { return TenDangNhap; }
            set { TenDangNhap = value; }
        }

        public string Mat_Khau_1
        {
            get { return MatKhau1; }
            set { MatKhau1 = value; }
        }

        public string Mat_Khau_2
        {
            get { return MatKhau2; }
            set { MatKhau2 = value; }
        }
    }
}
