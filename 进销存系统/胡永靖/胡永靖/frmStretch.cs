using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 胡永靖
{
    public partial class frmStretch : Form
    {
        public frmStretch()
        {
            InitializeComponent();
        }

        private void cmbQuanlity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbH_Scroll(object sender, EventArgs e)
        {
            //获取两个Trackbar
            int hScale, vScale;
            hScale = tbH.Value;
            vScale = tbV.Value;
            frmMain frm = (frmMain)this.Owner;
            frm.Stretch(hScale, vScale, (InterpolationMode)cmbQuanlity.SelectedItem);
        }

        private void tbV_Scroll(object sender, EventArgs e)
        {
            tbH_Scroll(sender, e);
        }

        private void frmStretch_Load(object sender, EventArgs e)
        {
            //双三次插值
            cmbQuanlity.Items.Add(InterpolationMode.Bicubic);
            //双线性插值
            cmbQuanlity.Items.Add(InterpolationMode.Bilinear);
            //默认插值模式
            cmbQuanlity.Items.Add(InterpolationMode.Default);
            //高质量插值
            cmbQuanlity.Items.Add(InterpolationMode.High);
            //高质量双三次插值
            cmbQuanlity.Items.Add(InterpolationMode.HighQualityBicubic);
            //高质量双线性插值
            cmbQuanlity.Items.Add(InterpolationMode.HighQualityBilinear);
            //低质量插值
            cmbQuanlity.Items.Add(InterpolationMode.Low);
            //最近邻插值
            cmbQuanlity.Items.Add(InterpolationMode.NearestNeighbor);
            
            cmbQuanlity.SelectedIndex = 0;
        }
    }
}
