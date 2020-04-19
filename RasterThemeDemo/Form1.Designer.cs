namespace RasterThemeDemo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监督分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大似然法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非监督分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSODATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.精度评定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showImg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectRasterCmb = new System.Windows.Forms.ComboBox();
            this.selectDBCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BandSet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BBandCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GBandCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RBandCmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelResolutionY = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelResolutionX = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.BandSet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分类ToolStripMenuItem,
            this.分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 分类ToolStripMenuItem
            // 
            this.分类ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.监督分类ToolStripMenuItem,
            this.非监督分类ToolStripMenuItem});
            this.分类ToolStripMenuItem.Name = "分类ToolStripMenuItem";
            this.分类ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.分类ToolStripMenuItem.Text = "分类";
            // 
            // 监督分类ToolStripMenuItem
            // 
            this.监督分类ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最大似然法ToolStripMenuItem});
            this.监督分类ToolStripMenuItem.Name = "监督分类ToolStripMenuItem";
            this.监督分类ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.监督分类ToolStripMenuItem.Text = "监督分类";
            // 
            // 最大似然法ToolStripMenuItem
            // 
            this.最大似然法ToolStripMenuItem.Name = "最大似然法ToolStripMenuItem";
            this.最大似然法ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.最大似然法ToolStripMenuItem.Text = "最大似然法";
            this.最大似然法ToolStripMenuItem.Click += new System.EventHandler(this.最大似然法ToolStripMenuItem_Click);
            // 
            // 非监督分类ToolStripMenuItem
            // 
            this.非监督分类ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSODATAToolStripMenuItem});
            this.非监督分类ToolStripMenuItem.Name = "非监督分类ToolStripMenuItem";
            this.非监督分类ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.非监督分类ToolStripMenuItem.Text = "非监督分类";
            // 
            // iSODATAToolStripMenuItem
            // 
            this.iSODATAToolStripMenuItem.Name = "iSODATAToolStripMenuItem";
            this.iSODATAToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.iSODATAToolStripMenuItem.Text = "ISODATA";
            this.iSODATAToolStripMenuItem.Click += new System.EventHandler(this.iSODATAToolStripMenuItem_Click);
            // 
            // 分析ToolStripMenuItem
            // 
            this.分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.精度评定ToolStripMenuItem});
            this.分析ToolStripMenuItem.Name = "分析ToolStripMenuItem";
            this.分析ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.分析ToolStripMenuItem.Text = "分析";
            // 
            // 精度评定ToolStripMenuItem
            // 
            this.精度评定ToolStripMenuItem.Name = "精度评定ToolStripMenuItem";
            this.精度评定ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.精度评定ToolStripMenuItem.Text = "精度评定";
            this.精度评定ToolStripMenuItem.Click += new System.EventHandler(this.精度评定ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showImg);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.BandSet);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1332, 621);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 1;
            // 
            // showImg
            // 
            this.showImg.Location = new System.Drawing.Point(299, 401);
            this.showImg.Margin = new System.Windows.Forms.Padding(4);
            this.showImg.Name = "showImg";
            this.showImg.Size = new System.Drawing.Size(100, 29);
            this.showImg.TabIndex = 49;
            this.showImg.Text = "显示影像";
            this.showImg.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectRasterCmb);
            this.groupBox2.Controls.Add(this.selectDBCmb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(386, 119);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打开影像数据";
            // 
            // selectRasterCmb
            // 
            this.selectRasterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRasterCmb.FormattingEnabled = true;
            this.selectRasterCmb.Location = new System.Drawing.Point(127, 75);
            this.selectRasterCmb.Margin = new System.Windows.Forms.Padding(4);
            this.selectRasterCmb.Name = "selectRasterCmb";
            this.selectRasterCmb.Size = new System.Drawing.Size(135, 23);
            this.selectRasterCmb.TabIndex = 2;
            this.selectRasterCmb.SelectedIndexChanged += new System.EventHandler(this.selectRasterCmb_SelectedIndexChanged);
            // 
            // selectDBCmb
            // 
            this.selectDBCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDBCmb.FormattingEnabled = true;
            this.selectDBCmb.Location = new System.Drawing.Point(127, 26);
            this.selectDBCmb.Margin = new System.Windows.Forms.Padding(4);
            this.selectDBCmb.Name = "selectDBCmb";
            this.selectDBCmb.Size = new System.Drawing.Size(135, 23);
            this.selectDBCmb.TabIndex = 2;
            this.selectDBCmb.SelectedIndexChanged += new System.EventHandler(this.selectDBCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择影像数据";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择数据库";
            // 
            // BandSet
            // 
            this.BandSet.Controls.Add(this.label7);
            this.BandSet.Controls.Add(this.BBandCmb);
            this.BandSet.Controls.Add(this.label6);
            this.BandSet.Controls.Add(this.GBandCmb);
            this.BandSet.Controls.Add(this.label5);
            this.BandSet.Controls.Add(this.RBandCmb);
            this.BandSet.Location = new System.Drawing.Point(13, 154);
            this.BandSet.Name = "BandSet";
            this.BandSet.Size = new System.Drawing.Size(386, 128);
            this.BandSet.TabIndex = 47;
            this.BandSet.TabStop = false;
            this.BandSet.Text = "波段选择";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "B波段：";
            // 
            // BBandCmb
            // 
            this.BBandCmb.FormattingEnabled = true;
            this.BBandCmb.Location = new System.Drawing.Point(94, 92);
            this.BBandCmb.Margin = new System.Windows.Forms.Padding(4);
            this.BBandCmb.Name = "BBandCmb";
            this.BBandCmb.Size = new System.Drawing.Size(173, 23);
            this.BBandCmb.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "G波段：";
            // 
            // GBandCmb
            // 
            this.GBandCmb.FormattingEnabled = true;
            this.GBandCmb.Location = new System.Drawing.Point(94, 59);
            this.GBandCmb.Margin = new System.Windows.Forms.Padding(4);
            this.GBandCmb.Name = "GBandCmb";
            this.GBandCmb.Size = new System.Drawing.Size(173, 23);
            this.GBandCmb.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "R波段：";
            // 
            // RBandCmb
            // 
            this.RBandCmb.FormattingEnabled = true;
            this.RBandCmb.Location = new System.Drawing.Point(94, 27);
            this.RBandCmb.Margin = new System.Windows.Forms.Padding(4);
            this.RBandCmb.Name = "RBandCmb";
            this.RBandCmb.Size = new System.Drawing.Size(173, 23);
            this.RBandCmb.TabIndex = 44;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelResolutionY);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.labelResolutionX);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.labelWidth);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.labelHeight);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Location = new System.Drawing.Point(13, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 82);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图像信息";
            // 
            // labelResolutionY
            // 
            this.labelResolutionY.AutoSize = true;
            this.labelResolutionY.Location = new System.Drawing.Point(283, 47);
            this.labelResolutionY.Name = "labelResolutionY";
            this.labelResolutionY.Size = new System.Drawing.Size(95, 15);
            this.labelResolutionY.TabIndex = 9;
            this.labelResolutionY.Text = "resolutionY";
            this.labelResolutionY.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(179, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "分辨率（X）";
            // 
            // labelResolutionX
            // 
            this.labelResolutionX.AutoSize = true;
            this.labelResolutionX.Location = new System.Drawing.Point(285, 21);
            this.labelResolutionX.Name = "labelResolutionX";
            this.labelResolutionX.Size = new System.Drawing.Size(95, 15);
            this.labelResolutionX.TabIndex = 7;
            this.labelResolutionX.Text = "resolutionX";
            this.labelResolutionX.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(179, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "分辨率（Y）";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(90, 47);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(47, 15);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "width";
            this.labelWidth.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "高度";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(90, 21);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(55, 15);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "height";
            this.labelHeight.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 47);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 15);
            this.label.TabIndex = 2;
            this.label.Text = "宽度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 649);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "土地利用专题图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.BandSet.ResumeLayout(false);
            this.BandSet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox BandSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelResolutionY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelResolutionX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showImg;
        private System.Windows.Forms.ToolStripMenuItem 分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监督分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非监督分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 精度评定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大似然法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSODATAToolStripMenuItem;
        public System.Windows.Forms.ComboBox selectRasterCmb;
        public System.Windows.Forms.ComboBox selectDBCmb;
        public System.Windows.Forms.ComboBox BBandCmb;
        public System.Windows.Forms.ComboBox GBandCmb;
        public System.Windows.Forms.ComboBox RBandCmb;
    }
}

