using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 胡永靖
{
    public partial class frmAdjust : Form
    {
        public frmAdjust()
        {
            InitializeComponent();
        }

        private void frmAdjust_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1_Scroll(sender, e);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1_Scroll(sender, e);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1_Scroll(sender, e);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            float red, green, blue,alpha;
            red = (float)hScrollBar1.Value;
            green = (float)hScrollBar2.Value;
            blue = (float)hScrollBar3.Value;
            alpha = (float)hScrollBar4.Value;
            frmMain frm = (frmMain)this.Owner;
            frm.AjustColor(red, green, blue, alpha);
        }
    }
}
