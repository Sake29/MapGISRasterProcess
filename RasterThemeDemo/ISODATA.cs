using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MapGIS.GISControl;
using MapGIS.GeoDataBase;
using MapGIS.GeoDataBase.GeoRaster;
using MapGIS.GeoMap;
using MapGIS.RasAnalysis;
namespace RasterThemeDemo
{
    public partial class ISODATA : Form
    {
        Form1 form = new Form1();
        

        public ISODATA(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取参数
            int ClassNums = int.Parse(this.ClassNums.Text);
            int SampleStep = int.Parse(this.SampleStep.Text);
            int MaxLoopCount = int.Parse(this.MaxLoopCount.Text);
            double MoveThrs = double.Parse(this.MoveThrs.Text);
            int MinCellNums = Convert.ToInt32(double.Parse(this.MinCellNums.Text) * form.width * form.height);
            double MaxStd = double.Parse(this.MaxStd.Text);
            int MaxLumpNums = int.Parse(this.MaxLumpNums.Text);
            double MinInterClassDist = double.Parse(this.MinInterClassDist.Text);
            string DstRasURL = "GDBP://MapGisLocal/" + form.selectDBCmb.Text + "/ras/" + this.DstRasURL.Text;

            

            //获取待分类影像
            RasterDataSet rds = form.themeLayer.GetData() as RasterDataSet;
            //获取波段信息
            int[] selectBands = new int[rds.BandCount];
            for (int n = 1; n <= rds.BandCount; n++)
            {
                selectBands[n-1] = n;
            }

            //构建栅格分类器
            RasClass rc = new RasClass();
            //设置待分类影像
            rc.SetData(rds);
            //设置处理范围
            rc.SetCommonParam(selectBands, 0, 0, form.height, form.width);
            //调用分类器
            //非监督分类：ISODATA
            int i = rc.RsIsoClusterUnsupervisedClassification(ClassNums, MaxStd, MaxLoopCount, MoveThrs, MinInterClassDist, MinCellNums, MaxLumpNums, SampleStep, DstRasURL);
            if (i == 1)
            {
                MessageBox.Show("分类成功！");
                //将分类结果展示到界面上
                rds.Open(DstRasURL, 0);
                //添加分类影像到数据库
                form.selectRasterCmb.Text = this.DstRasURL.Text;
                Map map = new Map();
                form.themeLayer = new RasterLayer();

                if (rds != null)
                    form.themeLayer.AttachData(rds);

                map.Append(form.themeLayer);
                form.mapControl.ActiveMap = map;
                form.mapControl.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("分类失败！");
            }
        }

        private void ISODATA_Load(object sender, EventArgs e)
        {
            this.ClassNums.Text = "4";
            this.SampleStep.Text = "16";
            this.MaxLoopCount.Text = "20";
            this.MoveThrs.Text = "0.01";
            this.MinCellNums.Text = "0.005";
            this.MaxStd.Text = "9.8";
            this.MaxLumpNums.Text = "5";
            this.MinInterClassDist.Text = "6.4";
        }
    }
}
