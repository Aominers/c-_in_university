namespace 胡永靖
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picSource = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.复制图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色调整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.底片处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平镜像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直镜像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).BeginInit();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSource.ContextMenuStrip = this.contextMenuStrip1;
            this.picSource.Image = ((System.Drawing.Image)(resources.GetObject("picSource.Image")));
            this.picSource.Location = new System.Drawing.Point(43, 43);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(170, 227);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择图像ToolStripMenuItem,
            this.toolStripSeparator1,
            this.复制图像ToolStripMenuItem,
            this.缩放图像ToolStripMenuItem,
            this.颜色调整ToolStripMenuItem,
            this.底片处理ToolStripMenuItem,
            this.水平镜像ToolStripMenuItem,
            this.垂直镜像ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 206);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 选择图像ToolStripMenuItem
            // 
            this.选择图像ToolStripMenuItem.Name = "选择图像ToolStripMenuItem";
            this.选择图像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.选择图像ToolStripMenuItem.Text = "选择图像";
            this.选择图像ToolStripMenuItem.Click += new System.EventHandler(this.选择图像ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // 复制图像ToolStripMenuItem
            // 
            this.复制图像ToolStripMenuItem.Name = "复制图像ToolStripMenuItem";
            this.复制图像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.复制图像ToolStripMenuItem.Text = "复制图像";
            this.复制图像ToolStripMenuItem.Click += new System.EventHandler(this.复制图像ToolStripMenuItem_Click);
            // 
            // 缩放图像ToolStripMenuItem
            // 
            this.缩放图像ToolStripMenuItem.Name = "缩放图像ToolStripMenuItem";
            this.缩放图像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.缩放图像ToolStripMenuItem.Text = "缩放图像";
            this.缩放图像ToolStripMenuItem.Click += new System.EventHandler(this.缩放图像ToolStripMenuItem_Click);
            // 
            // 颜色调整ToolStripMenuItem
            // 
            this.颜色调整ToolStripMenuItem.Name = "颜色调整ToolStripMenuItem";
            this.颜色调整ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.颜色调整ToolStripMenuItem.Text = "颜色调整";
            this.颜色调整ToolStripMenuItem.Click += new System.EventHandler(this.颜色调整ToolStripMenuItem_Click);
            // 
            // 底片处理ToolStripMenuItem
            // 
            this.底片处理ToolStripMenuItem.Name = "底片处理ToolStripMenuItem";
            this.底片处理ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.底片处理ToolStripMenuItem.Text = "底片处理";
            this.底片处理ToolStripMenuItem.Click += new System.EventHandler(this.底片处理ToolStripMenuItem_Click);
            // 
            // 水平镜像ToolStripMenuItem
            // 
            this.水平镜像ToolStripMenuItem.Name = "水平镜像ToolStripMenuItem";
            this.水平镜像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.水平镜像ToolStripMenuItem.Text = "水平镜像";
            this.水平镜像ToolStripMenuItem.Click += new System.EventHandler(this.水平镜像ToolStripMenuItem_Click);
            // 
            // 垂直镜像ToolStripMenuItem
            // 
            this.垂直镜像ToolStripMenuItem.Name = "垂直镜像ToolStripMenuItem";
            this.垂直镜像ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.垂直镜像ToolStripMenuItem.Text = "垂直镜像";
            this.垂直镜像ToolStripMenuItem.Click += new System.EventHandler(this.垂直镜像ToolStripMenuItem_Click);
            // 
            // picDest
            // 
            this.picDest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDest.Location = new System.Drawing.Point(383, 43);
            this.picDest.Name = "picDest";
            this.picDest.Size = new System.Drawing.Size(235, 320);
            this.picDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDest.TabIndex = 1;
            this.picDest.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 451);
            this.Controls.Add(this.picDest);
            this.Controls.Add(this.picSource);
            this.Name = "frmMain";
            this.Text = "hyjMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 复制图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色调整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 底片处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平镜像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直镜像ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDest;
    }
}

