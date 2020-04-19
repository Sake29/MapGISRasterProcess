namespace RasterThemeDemo
{
    partial class 最大似然法
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
            this.minProb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceURL = new System.Windows.Forms.TextBox();
            this.OutputPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minProb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.distanceURL);
            this.groupBox1.Controls.Add(this.OutputPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 182);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置(最大似然法)";
            // 
            // minProb
            // 
            this.minProb.Location = new System.Drawing.Point(133, 48);
            this.minProb.Name = "minProb";
            this.minProb.Size = new System.Drawing.Size(242, 25);
            this.minProb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "最小概率：";
            // 
            // distanceURL
            // 
            this.distanceURL.Location = new System.Drawing.Point(133, 101);
            this.distanceURL.Name = "distanceURL";
            this.distanceURL.Size = new System.Drawing.Size(242, 25);
            this.distanceURL.TabIndex = 37;
            // 
            // OutputPath
            // 
            this.OutputPath.AutoSize = true;
            this.OutputPath.Location = new System.Drawing.Point(13, 104);
            this.OutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(112, 15);
            this.OutputPath.TabIndex = 36;
            this.OutputPath.Text = "输出影像名称：";
            // 
            // 最大似然法
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "最大似然法";
            this.Text = "最大似然法";
            this.Load += new System.EventHandler(this.最大似然法_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox minProb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distanceURL;
        private System.Windows.Forms.Label OutputPath;
    }
}