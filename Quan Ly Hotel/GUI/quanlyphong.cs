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
    public partial class quanlyphong : Form
    {
        public quanlyphong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            line.Width = label1.Width;
            line.Left = label1.Left;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            line.Width = label2.Width;
            line.Left = label2.Left;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            line.Width = label3.Width;
            line.Left = label3.Left;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void quanlyphong_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UserControl1());
        }
    }
}
