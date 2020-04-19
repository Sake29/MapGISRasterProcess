namespace RasterThemeDemo
{
    partial class ISODATA
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinInterClassDist = new System.Windows.Forms.TextBox();
            this.MaxLumpNums = new System.Windows.Forms.TextBox();
            this.MaxStd = new System.Windows.Forms.TextBox();
            this.MinCellNums = new System.Windows.Forms.TextBox();
            this.MoveThrs = new System.Windows.Forms.TextBox();
            this.MaxLoopCount = new System.Windows.Forms.TextBox();
            this.SampleStep = new System.Windows.Forms.TextBox();
            this.ClassNums = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DstRasURL = new System.Windows.Forms.TextBox();
            this.OutputPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinInterClassDist);
            this.groupBox1.Controls.Add(this.MaxLumpNums);
            this.groupBox1.Controls.Add(this.MaxStd);
            this.groupBox1.Controls.Add(this.MinCellNums);
            this.groupBox1.Controls.Add(this.MoveThrs);
            this.groupBox1.Controls.Add(this.MaxLoopCount);
            this.groupBox1.Controls.Add(this.SampleStep);
            this.groupBox1.Controls.Add(this.ClassNums);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DstRasURL);
            this.groupBox1.Controls.Add(this.OutputPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 187);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置(ISODATA)";
            // 
            // MinInterClassDist
            // 
            this.MinInterClassDist.Location = new System.Drawing.Point(297, 112);
            this.MinInterClassDist.Name = "MinInterClassDist";
            this.MinInterClassDist.Size = new System.Drawing.Size(72, 25);
            this.MinInterClassDist.TabIndex = 54;
            // 
            // MaxLumpNums
            // 
            this.MaxLumpNums.Location = new System.Drawing.Point(297, 81);
            this.MaxLumpNums.Name = "MaxLumpNums";
            this.MaxLumpNums.Size = new System.Drawing.Size(72, 25);
            this.MaxLumpNums.TabIndex = 53;
            // 
            // MaxStd
            // 
            this.MaxStd.Location = new System.Drawing.Point(297, 49);
            this.MaxStd.Name = "MaxStd";
            this.MaxStd.Size = new System.Drawing.Size(72, 25);
            this.MaxStd.TabIndex = 52;
            // 
            // MinCellNums
            // 
            this.MinCellNums.Location = new System.Drawing.Point(297, 18);
            this.MinCellNums.Name = "MinCellNums";
            this.MinCellNums.Size = new System.Drawing.Size(72, 25);
            this.MinCellNums.TabIndex = 51;
            // 
            // MoveThrs
            // 
            this.MoveThrs.Location = new System.Drawing.Point(93, 112);
            this.MoveThrs.Name = "MoveThrs";
            this.MoveThrs.Size = new System.Drawing.Size(72, 25);
            this.MoveThrs.TabIndex = 50;
            // 
            // MaxLoopCount
            // 
            this.MaxLoopCount.Location = new System.Drawing.Point(93, 81);
            this.MaxLoopCount.Name = "MaxLoopCount";
            this.MaxLoopCount.Size = new System.Drawing.Size(72, 25);
            this.MaxLoopCount.TabIndex = 49;
            // 
            // SampleStep
            // 
            this.SampleStep.Location = new System.Drawing.Point(93, 49);
            this.SampleStep.Name = "SampleStep";
            this.SampleStep.Size = new System.Drawing.Size(72, 25);
            this.SampleStep.TabIndex = 48;
            // 
            // ClassNums
            // 
            this.ClassNums.Location = new System.Drawing.Point(93, 18);
            this.ClassNums.Name = "ClassNums";
            this.ClassNums.Size = new System.Drawing.Size(72, 25);
            this.ClassNums.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "最大合并类数：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "最大标准差：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "类中心位移：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "最小类中心距离：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "最少像元数(%)：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "迭代次数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "采样间隔：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "类数：";
            // 
            // DstRasURL
            // 
            this.DstRasURL.Location = new System.Drawing.Point(127, 141);
            this.DstRasURL.Name = "DstRasURL";
            this.DstRasURL.Size = new System.Drawing.Size(242, 25);
            this.DstRasURL.TabIndex = 37;
            // 
            // OutputPath
            // 
            this.OutputPath.AutoSize = true;
            this.OutputPath.Location = new System.Drawing.Point(7, 144);
            this.OutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(112, 15);
            this.OutputPath.TabIndex = 36;
            this.OutputPath.Text = "输出影像名称：";
            // 
            // ISODATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "ISODATA";
            this.Text = "ISODATA";
            this.Load += new System.EventHandler(this.ISODATA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MinInterClassDist;
        private System.Windows.Forms.TextBox MaxLumpNums;
        private System.Windows.Forms.TextBox MaxStd;
        private System.Windows.Forms.TextBox MinCellNums;
        private System.Windows.Forms.TextBox MoveThrs;
        private System.Windows.Forms.TextBox MaxLoopCount;
        private System.Windows.Forms.TextBox SampleStep;
        private System.Windows.Forms.TextBox ClassNums;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DstRasURL;
        private System.Windows.Forms.Label OutputPath;
    }
}