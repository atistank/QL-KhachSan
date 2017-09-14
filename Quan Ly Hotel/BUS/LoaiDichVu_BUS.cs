using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiDichVu_BUS
    {
        //Lấy DS loại dịch vụ
        
        public static List<LoaiDichVu_DTO> LayDV()
        {
            return LoaiDichVu_DAO.LayDV();
        }
    }
}
