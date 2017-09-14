using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_re_thanhtoan : Form
    {
        public frm_re_thanhtoan()
        {
            InitializeComponent();
        }

        private void frm_re_thanhtoan_Load(object sender, EventArgs e)
        {
            
            //report viewer
            ThanhToan_DTObindingSource.DataSource = ThanhToan_BUS.LayDSThanhToan();
            this.reportViewer1.RefreshReport();

            
            //combobox phòng
            List<TrangThaiPhong_DTO> lst = TrangThaiPhong_BUS.LayPhong();
            cbb_maphong.DataSource = lst;
            TrangThaiPhong_DTO d = new TrangThaiPhong_DTO();
            d.SMaPhong = "Mã Phòng";
           
            lst.Insert(0, d);
            cbb_maphong.ValueMember = "SMaPhong";
            
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

            string maphong = cbb_maphong.SelectedValue.ToString();
            ThanhToan_DTObindingSource.DataSource = ThanhToan_BUS.LayDSThanhToanTheoMaPhong(maphong);
            this.reportViewer1.RefreshReport();
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}
