using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class thanhtoan2 : Form
    {
        public string Phanquyen;
        public thanhtoan2()
        {
            InitializeComponent();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void thanhtoan2_Load(object sender, EventArgs e)
        {
            if (Phanquyen == "Administrator")
            {
                txtphanquyen.Text = "  Administrator";
                chucvu.Text = "Administrator";
            }
            else
            {
                avatar.Image = Properties.Resources.duyavatar;
                txtphanquyen.Text = "@Ngô Anh Duy";
                chucvu.Text = "Nhân Viên";
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (chucvu.Text == "Administrator")
            {
                test1 f = new test1();
                f.Show();
            }
            else MessageBox.Show("Chỉ có quản trị viên mới truy cập được");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frm_re_thanhtoan f = new frm_re_thanhtoan();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon !!!");
        }
    }
}
