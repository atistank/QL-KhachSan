using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDichVu_DTO
    {
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

        private string sGiaDichVu;
        public string SGiaDichVu
        {
            get { return sGiaDichVu; }
            set { sGiaDichVu = value; }
        }

    }
}
