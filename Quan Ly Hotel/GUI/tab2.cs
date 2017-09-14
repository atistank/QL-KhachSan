using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class tab2 : UserControl
    {
        public event EventHandler AddControl;
        private void button1_Click(object sender, EventArgs e)
        {
            this.AddControl(this, new EventArgs());
        }
        public tab2()
        {
            InitializeComponent();
        }
        public void animateTM() {
           
            animate.Start();
        }

        private void animate_Tick(object sender, EventArgs e)
        {
            animate.Stop();
        }

        void showcontrol()
        {
            foreach (Control item in this.Controls)
            {
                bunifuTransition1.ShowSync(item);
                Application.DoEvents();
            }
        }
        public void hidecontrol()
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = false; 
                Application.DoEvents();
            }
        }

    }
}
