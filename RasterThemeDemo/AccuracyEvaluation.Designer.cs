namespace RasterThemeDemo
{
    partial class AccuracyEvaluation
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
            this.label3 = new System.Windows.Forms.Label();
            this.ErrMatrix = new System.Windows.Forms.CheckBox();
            this.ClsAccu = new System.Windows.Forms.CheckBox();
            this.TtlAccu = new System.Windows.Forms.CheckBox();
            this.Kappa = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectRasterCmb1 = new System.Windows.Forms.ComboBox();
            this.selectDBCmb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectRasterCmb2 = new System.Windows.Forms.ComboBox();
            this.selectDBCmb2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "评估内容";
            // 
            // ErrMatrix
            // 
            this.ErrMatrix.AutoSize = true;
            this.ErrMatrix.Location = new System.Drawing.Point(140, 179);
            this.ErrMatrix.Name = "ErrMatrix";
            this.ErrMatrix.Size = new System.Drawing.Size(86, 19);
            this.ErrMatrix.TabIndex = 3;
            this.ErrMatrix.Text = "混淆矩阵";
            this.ErrMatrix.UseVisualStyleBackColor = true;
            // 
            // ClsAccu
            // 
            this.ClsAccu.AutoSize = true;
            this.ClsAccu.Location = new System.Drawing.Point(256, 178);
            this.ClsAccu.Name = "ClsAccu";
            this.ClsAccu.Size = new System.Drawing.Size(86, 19);
            this.ClsAccu.TabIndex = 4;
            this.ClsAccu.Text = "各类精度";
            this.ClsAccu.UseVisualStyleBackColor = true;
            // 
            // TtlAccu
            // 
            this.TtlAccu.AutoSize = true;
            this.TtlAccu.Location = new System.Drawing.Point(363, 178);
            this.TtlAccu.Name = "TtlAccu";
            this.TtlAccu.Size = new System.Drawing.Size(86, 19);
            this.TtlAccu.TabIndex = 5;
            this.TtlAccu.Text = "总体精度";
            this.TtlAccu.UseVisualStyleBackColor = true;
            // 
            // Kappa
            // 
            this.Kappa.AutoSize = true;
            this.Kappa.Location = new System.Drawing.Point(477, 178);
            this.Kappa.Name = "Kappa";
            this.Kappa.Size = new System.Drawing.Size(96, 19);
            this.Kappa.TabIndex = 6;
            this.Kappa.Text = "Kappa系数";
            this.Kappa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出路径";
            // 
            // resultPath
            // 
            this.resultPath.Location = new System.Drawing.Point(140, 270);
            this.resultPath.Name = "resultPath";
            this.resultPath.Size = new System.Drawing.Size(309, 25);
            this.resultPath.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectRasterCmb1);
            this.groupBox2.Controls.Add(this.selectDBCmb1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(44, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(277, 119);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原始影像";
            // 
            // selectRasterCmb1
            // 
            this.selectRasterCmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRasterCmb1.FormattingEnabled = true;
            this.selectRasterCmb1.Location = new System.Drawing.Point(127, 75);
            this.selectRasterCmb1.Margin = new System.Windows.Forms.Padding(4);
            this.selectRasterCmb1.Name = "selectRasterCmb1";
            this.selectRasterCmb1.Size = new System.Drawing.Size(135, 23);
            this.selectRasterCmb1.TabIndex = 2;
            // 
            // selectDBCmb1
            // 
            this.selectDBCmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDBCmb1.FormattingEnabled = true;
            this.selectDBCmb1.Location = new System.Drawing.Point(127, 26);
            this.selectDBCmb1.Margin = new System.Windows.Forms.Padding(4);
            this.selectDBCmb1.Name = "selectDBCmb1";
            this.selectDBCmb1.Size = new System.Drawing.Size(135, 23);
            this.selectDBCmb1.TabIndex = 2;
            this.selectDBCmb1.SelectedIndexChanged += new System.EventHandler(this.selectDBCmb1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择影像数据";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择数据库";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectRasterCmb2);
            this.groupBox1.Controls.Add(this.selectDBCmb2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(377, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(277, 119);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类影像";
            // 
            // selectRasterCmb2
            // 
            this.selectRasterCmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRasterCmb2.FormattingEnabled = true;
            this.selectRasterCmb2.Location = new System.Drawing.Point(127, 75);
            this.selectRasterCmb2.Margin = new System.Windows.Forms.Padding(4);
            this.selectRasterCmb2.Name = "selectRasterCmb2";
            this.selectRasterCmb2.Size = new System.Drawing.Size(135, 23);
            this.selectRasterCmb2.TabIndex = 2;
            // 
            // selectDBCmb2
            // 
            this.selectDBCmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDBCmb2.FormattingEnabled = true;
            this.selectDBCmb2.Location = new System.Drawing.Point(127, 26);
            this.selectDBCmb2.Margin = new System.Windows.Forms.Padding(4);
            this.selectDBCmb2.Name = "selectDBCmb2";
            this.selectDBCmb2.Size = new System.Drawing.Size(135, 23);
            this.selectDBCmb2.TabIndex = 2;
            this.selectDBCmb2.SelectedIndexChanged += new System.EventHandler(this.selectDBCmb2_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "选择数据库";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(579, 385);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 49;
            this.button.Text = "确定";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // AccuracyEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 503);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kappa);
            this.Controls.Add(this.TtlAccu);
            this.Controls.Add(this.ClsAccu);
            this.Controls.Add(this.ErrMatrix);
            this.Controls.Add(this.label3);
            this.Name = "AccuracyEvaluation";
            this.Text = "精度评定";
            this.Load += new System.EventHandler(this.AccuracyEvaluation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ErrMatrix;
        private System.Windows.Forms.CheckBox ClsAccu;
        private System.Windows.Forms.CheckBox TtlAccu;
        private System.Windows.Forms.CheckBox Kappa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox selectRasterCmb1;
        public System.Windows.Forms.ComboBox selectDBCmb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox selectRasterCmb2;
        public System.Windows.Forms.ComboBox selectDBCmb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button;
    }
}