using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Mainchinh2 : Form
    {
        public string phanquyen = "1";



        public Mainchinh2()
        {
            InitializeComponent();
        }
        public void funData(TextBox txtForm1)
        {
         
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {
            txtphanquyen.Text = phanquyen;
        }
        private const int WM_BUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0xA1;

        public string Phanquyen { get => Phanquyen1; set => Phanquyen1 = value; }
        public string Phanquyen1 { get => Phanquyen2; set => Phanquyen2 = value; }
        public string Phanquyen2 { get => phanquyen; set => phanquyen = value; }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int  lParam);
        private void Mainchinh2_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void Mainchinh2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void Mainchinh2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_BUTTONDOWN , HTCAPTION, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            datphong2 f = new datphong2();
            f.Phanquyen = chucvu.Text;
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            thanhtoan2 f = new thanhtoan2();
            f.Phanquyen = chucvu.Text;
            f.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            thongtinphong2 f = new thongtinphong2();
           f.phanquyen =  chucvu.Text;
           
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            trangthai2 f = new trangthai2();
            f.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            tieusu f = new tieusu();
            f.Show();
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon !!!");
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Mainchinh2_Load(object sender, EventArgs e)
        {
       


            if (phanquyen == "admin")
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap2 f = new DangNhap2();
            f.Show();
        }
    }
}
