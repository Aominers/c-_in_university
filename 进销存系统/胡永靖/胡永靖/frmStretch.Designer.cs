namespace 胡永靖
{
    partial class frmStretch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TrackBar();
            this.tbV = new System.Windows.Forms.TrackBar();
            this.cmbQuanlity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "横向：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "纵向：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "质量：";
            // 
            // tbH
            // 
            this.tbH.LargeChange = 1;
            this.tbH.Location = new System.Drawing.Point(110, 57);
            this.tbH.Maximum = 200;
            this.tbH.Minimum = 20;
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(265, 56);
            this.tbH.TabIndex = 3;
            this.tbH.Value = 100;
            this.tbH.Scroll += new System.EventHandler(this.tbH_Scroll);
            // 
            // tbV
            // 
            this.tbV.LargeChange = 1;
            this.tbV.Location = new System.Drawing.Point(110, 151);
            this.tbV.Maximum = 200;
            this.tbV.Minimum = 20;
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(265, 56);
            this.tbV.TabIndex = 4;
            this.tbV.Value = 100;
            this.tbV.Scroll += new System.EventHandler(this.tbV_Scroll);
            // 
            // cmbQuanlity
            // 
            this.cmbQuanlity.FormattingEnabled = true;
            this.cmbQuanlity.Location = new System.Drawing.Point(110, 249);
            this.cmbQuanlity.Name = "cmbQuanlity";
            this.cmbQuanlity.Size = new System.Drawing.Size(265, 23);
            this.cmbQuanlity.TabIndex = 5;
            this.cmbQuanlity.SelectedIndexChanged += new System.EventHandler(this.cmbQuanlity_SelectedIndexChanged);
            // 
            // frmStretch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 388);
            this.Controls.Add(this.cmbQuanlity);
            this.Controls.Add(this.tbV);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStretch";
            this.Text = "frmStretch";
            this.Load += new System.EventHandler(this.frmStretch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbH;
        private System.Windows.Forms.TrackBar tbV;
        private System.Windows.Forms.ComboBox cmbQuanlity;
    }
}