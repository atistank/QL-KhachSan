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
    public class LoaiDichVu_DAO
    {
        static SqlConnection con;

        //lấy danh sách loại dịch vụ
        public static List<LoaiDichVu_DTO> LayDV()
        {
            string sTruyVan = "select * from dichvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiDichVu_DTO> lstDV = new List<LoaiDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiDichVu_DTO p = new LoaiDichVu_DTO();
                p.SMaDichVu = dt.Rows[i]["madichvu"].ToString();
                p.STenDichVu = dt.Rows[i]["tendichvu"].ToString();
                p.SGiaDichVu = dt.Rows[i]["giadichvu"].ToString();

                lstDV.Add(p);
            }
            DataProvider.DongKetNoi(con);
            return lstDV;
        }
    }
}
