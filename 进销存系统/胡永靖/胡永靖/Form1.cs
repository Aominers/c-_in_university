using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
namespace 胡永靖
{
    public partial class frmMain : Form
    {
        Image img;
        int iWidth, iHeight;
        ImageAttributes myAttr;
        Graphics g;

        public frmMain()
        {
            InitializeComponent();
        }

        private void 选择图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG文件(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSource.Image = Image.FromFile(ofd.FileName);
                img = picSource.Image;
                iWidth = img.Width;
                iHeight = img.Height;
            }
        }

        private void 复制图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picDest.Image = picSource.Image;
        }

        private void 底片处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color myColor;
            int rc, gc, bc;
            g.Clear(picSource.BackColor);
            Bitmap bmp1 = (Bitmap)img;
            //复制一个大小相同，但让系统自行决定的像素格式
            Bitmap bmp2 = bmp1.Clone(new Rectangle(0,0,iWidth,iHeight),PixelFormat.DontCare);
            for (int i = iWidth - 1; i >= 0; i--)
            {
                for (int j = iHeight - 1; j >= 0; j--)
                {
                    //获取位图对象中特定位置的像素颜色
                    myColor = bmp1.GetPixel(i, j);
                    rc = 255 - myColor.R;
                    gc = 255 - myColor.G;
                    bc = 255 - myColor.B;
/*                    rc = myColor.R;
                    gc = myColor.G;
                    bc = myColor.B;*/
                    bmp2.SetPixel(i,j,Color.FromArgb(rc,gc,bc));
                }
            }
            g.DrawImage(bmp2, new Rectangle(0, 0, iWidth, iHeight));
        }

        private void 水平镜像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            g.DrawImage(img, 0, 0);
        }

        private void 垂直镜像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImage (img, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "胡永靖";
            g = picDest.CreateGraphics();
            myAttr = new ImageAttributes();
            img = picSource.Image;
            iWidth = img.Width;
            iHeight = img.Height;
        }

        private void 缩放图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStretch frm = new frmStretch();
            frm.Show(this);
        }

        private void 颜色调整ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdjust frm = new frmAdjust();
            frm.Show(this);
        }
        public void AjustColor(float red,float green,float blue,float alpha)
        {
            g.Clear(picSource.BackColor);
            g.Clear(picSource.BackColor);
            float[][] colorMatrixElements =
            {
                new float[] {red ,0,0,0,0},
                new float[] {0,green,0,0,0},
                new float[] {0,0,blue,0,0},
                new float[] {0,0,0,alpha,0},
                new float[] {0f,0,0,0,1.0f } };
            ColorMatrix cm = new ColorMatrix(colorMatrixElements);
            myAttr.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(img, new Rectangle(0, 0, iWidth, iHeight), 0, 0, iWidth, iHeight, GraphicsUnit.Pixel, myAttr);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void Stretch(float hScale,float vScale,InterpolationMode im)
        {
            g.Clear(picSource.BackColor);
            //确定横、纵向放大因子（0.2到2，即20%到200%）
            float iW,iH;
            iW = hScale / 100.00f;
            iH = vScale / 100.00f;
            //设置缩小放大时将使用的插值法
            g.InterpolationMode = im;
            //按指定的放大、缩小因子绘制图像
            g.DrawImage(img,new Rectangle(0, 0,(int)(iW * iWidth),(int)(iH * iHeight)),
                new Rectangle(0, 0, iWidth, iHeight), 
                GraphicsUnit.Pixel);
        }

    }
}
