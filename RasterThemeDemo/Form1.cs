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
    public partial class Form1 : Form
    {
        //地图视图控件
        public MapControl mapControl = null;
        public RasterLayer themeLayer = null;
        //地理数据源
        Server Svr = new Server();
        //地理数据库
        DataBase GDB = new DataBase();
        //栅格数据集
        public RasterDataSet rds = new RasterDataSet();
        //分类后数据集
        RasterDataSet after_cls_rds = new RasterDataSet();
        //波段信息
        RasterBand RasBand = new RasterBand();

        //输出图片路径
        //string picUrl = "";
        //输出图片类型
        //int imgType = 0;

        //影像高度
        public int height = 0;
        //影像宽度
        public int width = 0;
        //x轴分辨率
        double resolutionX = 0;
        //y轴分辨率
        double resolutionY = 0;
        //
        public int[] selectBands = new int[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> dbIDs = null;

            Svr.Connect("MapGISLocal", "", "");

            dbIDs = Svr.GDBIDs;
            int dbCount = dbIDs.Count;
            int i = 0;

            //获取数据库的ID和名称
            while (i < dbCount)
            {
                int id = dbIDs[i];
                string name = Svr.GetDBName(id);
                selectDBCmb.Items.Add(name);
                i++;
            }

            //初始化控件
            this.mapControl = new MapControl();
            this.mapControl.Dock = DockStyle.Fill;
            this.mapControl.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.mapControl);
        }

        private void selectDBCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> rCatIDs = null;

            if (selectDBCmb.Text == null)
                return;

            selectRasterCmb.Items.Clear();
            GDB = Svr.OpenGDB(selectDBCmb.Text);

            //获取栅格目录的ID
            rCatIDs = GDB.GetXclses(XClsType.Rcat, 0);
            if (rCatIDs != null)
            {
                int count = rCatIDs.Count;

                //获取栅格目录中栅格数据集的信息
                for (int i = 0; i < count; i++)
                    getRasterData(XClsType.Rds, rCatIDs[i]);
            }
            //直接获取数据库中栅格数据的信息
            getRasterData(XClsType.Rds, 0);

            selectRasterCmb.Text = "";
            selectRasterCmb.SelectedIndex = -1;
        }

        // 获取栅格数据的id和name
        public void getRasterData(XClsType type, int FdsID)
        {
            List<int> rdsIDs = null;

            rdsIDs = GDB.GetXclses(type, FdsID);
            if (rdsIDs == null) return;

            int count = rdsIDs.Count;
            for (int i = 0; i < count; i++)
            {
                string name = GDB.GetXclsName(type, rdsIDs[i]);
                selectRasterCmb.Items.Add(name);
            }
        }

        private void selectRasterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDBCmb.Text == null || selectRasterCmb.Text == null)
                return;

            RBandCmb.Items.Clear();
            GBandCmb.Items.Clear();
            BBandCmb.Items.Clear();

            rds = new RasterDataSet(GDB);
            rds.Open(selectRasterCmb.Text, 0);

            //将波段添加到各个comoBox中
            for (int i = 0; i < rds.GetBandNum(); i++)
            {
                RasBand = rds.GetRasterBand(i+1);
                RBandCmb.Items.Add("波段" + (i + 1));
                GBandCmb.Items.Add("波段" + (i + 1));
                BBandCmb.Items.Add("波段" + (i + 1));

            }



            //在地图空间中显示该图层
            Map map = new Map();
            themeLayer = new RasterLayer();

            if (rds != null)
                themeLayer.AttachData(rds);

            map.Append(themeLayer);
            this.mapControl.ActiveMap = map;
            this.mapControl.Restore();

            
            RBandCmb.Text = "";
            GBandCmb.Text = "";
            BBandCmb.Text = "";

            if (RBandCmb.Items.Count >= 3 && GBandCmb.Items.Count >= 3 && BBandCmb.Items.Count >= 3)
            {
                RBandCmb.Enabled = true;
                GBandCmb.Enabled = true;
                BBandCmb.Enabled = true;

                RBandCmb.SelectedIndex = 0;
                GBandCmb.SelectedIndex = 1;
                BBandCmb.SelectedIndex = 2;
            }
            else
            {
                RBandCmb.Enabled = false;
                GBandCmb.Enabled = false;
                BBandCmb.Enabled = false;
            }

            //显示图像信息
            height = rds.GetPixelHeight();
            width = rds.GetPixelWidth();

            labelHeight.Text = height.ToString();
            labelWidth.Text = Width.ToString();

            labelHeight.Visible = true;
            labelWidth.Visible = true;

            //显示图像分辨率
            resolutionX = rds.GetResolutionX();
            resolutionY = rds.GetResolutionY();

            labelResolutionX.Text = resolutionX.ToString();
            labelResolutionY.Text = resolutionY.ToString();

            labelResolutionX.Visible = true;
            labelResolutionY.Visible = true;



            //给分类器设置参数
            /*
            textBox2.Text = "4";
            textBox3.Text = "16";
            textBox4.Text = "20";
            textBox5.Text = "0.01";
            textBox9.Text = "0.005";
            textBox8.Text = "9.8";
            textBox7.Text = "5";
            textBox6.Text = "6.4";
            */

        }



        #region 生成影像专题图


        //RGB专题图
        private void BuildRGBTheme()
        {
            if (selectRasterCmb.Text == "")
            {
                MessageBox.Show("请选择影像数据");
                return;
            }

            RasRGBTheme RGBTheme = new RasRGBTheme();
            RGBTheme.Name = selectRasterCmb.Text + "RGB专题图";
            RGBTheme.Visible = true;
            if (RBandCmb.Text != "" && GBandCmb.Text != "" && BBandCmb.Text != "")
            {
                RGBTheme.SetRGBBands(RBandCmb.SelectedIndex + 1, GBandCmb.SelectedIndex + 1, BBandCmb.SelectedIndex + 1);

                //添加专题图
                themeLayer.Themes.Clear();
                themeLayer.Themes.Append(RGBTheme);

                mapControl.Refresh();
            } 
            else
            {
                MessageBox.Show("RGB三个波段均不能为空");
            }

        }




        #endregion

        private void showImg_Click(object sender, EventArgs e)
        {
            BuildRGBTheme();
        }

        /*
        private void classification_Click(object sender, EventArgs e)
        {
            //获取参数
            int ClassNums = int.Parse(textBox2.Text);
            int SampleStep = int.Parse(textBox3.Text);
            int MaxLoopCount =int.Parse(textBox4.Text) ;
            double MoveThrs = double.Parse(textBox5.Text);
            //int MinCellNums = int.Parse(textBox9.Text);
            int MinCellNums = Convert.ToInt32(double.Parse(textBox9.Text) * width * height);
            double MaxStd = double.Parse(textBox8.Text);
            int MaxLumpNums = int.Parse(textBox7.Text);
            double MinInterClassDist = double.Parse(textBox6.Text);
            string DstRasURL = textBox1.Text;
            int RBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(RBandCmb.Text, @"[^0-9]+", ""));
            int GBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(GBandCmb.Text, @"[^0-9]+", ""));
            int BBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(BBandCmb.Text, @"[^0-9]+", ""));

            selectBands[0] = RBand;
            selectBands[1] = GBand;
            selectBands[2] = BBand;

            if (selectRasterCmb.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("该文件已存在！请重新输入文件名。");
                textBox1.Text = "";
                return;
            }

            
            rds = themeLayer.GetData() as RasterDataSet;
            //MessageBox.Show(rds.ClsName);
            //构建栅格分类器
            RasClass rc = new RasClass();
            //设置待分类影像
            rc.SetData(rds);
            //设置处理范围
            rc.SetCommonParam(selectBands,0,0,height,width);
            //设置分类结果URL
            DstRasURL = "GDBP://MapGisLocal/" + selectDBCmb.Text + "/ras/"+ textBox1.Text;
            //调用分类器
            //监督分类：最大似然法
            int i = rc.RsMaxLiklihoodSupervisedClassification(0.1, DstRasURL);
            //非监督分类：ISODATA
            //int i = rc.RsIsoClusterUnsupervisedClassification(ClassNums, MaxStd, MaxLoopCount, MoveThrs, MinInterClassDist, MinCellNums, MaxLumpNums, SampleStep, DstRasURL);
            selectRasterCmb.Items.Add(textBox1.Text);


            if (i == 1) {
                MessageBox.Show("分类成功！");
                //将分类结果展示到界面上
                rds.Open(textBox1.Text, 0);
                Map map = new Map();
                themeLayer = new RasterLayer();

                if (rds != null)
                    themeLayer.AttachData(rds);

                map.Append(themeLayer);
                this.mapControl.ActiveMap = map;
                mapControl.Refresh();

                //获取分类结果
                after_cls_rds.OpenByURL(DstRasURL, RasAccessType.RasAccessType_Update);
                //如果是监督分类，需要给结果集设置AOI;
                //after_cls_rds.SetAOIs((AOIPloygon[])rds.GetAOIs().Clone());
                after_cls_rds = setaoi(rds, after_cls_rds);
                MessageBox.Show("分类结果的aoi有："+after_cls_rds.GetAOIs().Length.ToString());
                //分类结果精度评定
                RasClassificationAnalyse rca = new RasClassificationAnalyse();
                //设置待评价影像（分类结果）
                rca.SetData(after_cls_rds,after_cls_rds.BandCount);
                //设置处理范围
                rca.SetCommonParam(0, 0, height, width);

                int j = rca.RsClassificationAccuracyAnalyse(rds, true, true, true, true, "classifaction_ana1.txt");
                MessageBox.Show("精度评定" + j.ToString());
            }
            else{
                MessageBox.Show("分类失败");
            }
        }
        */
        private RasterDataSet setaoi(RasterDataSet oldrds, RasterDataSet newrds) {
            //设置AOI信息
            AOIPloygon[] oldaois = oldrds.GetAOIs();
            AOIPloygon[] newaois = newrds.GetAOIs();
            AOIPloygon aoi = new AOIPloygon();
            for (int i = 0; i < oldaois.Length; i++) {
                newaois[i].R = oldaois[i].R;
                newaois[i].G = oldaois[i].G;
                newaois[i].B = oldaois[i].B;
            }
            bool flag = newrds.SetAOIs(newaois);
            if (flag)
            {
                MessageBox.Show("AOI信息设置成功");
                return newrds;
            }
            else
            {
                MessageBox.Show("AOI信息设置失败");
                return null;
            }
               
        }

        private void 最大似然法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            最大似然法 form = new 最大似然法(this);
            form.ShowDialog();
        }


        private void iSODATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISODATA form = new ISODATA(this);
            form.ShowDialog();
        }
        private void 精度评定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccuracyEvaluation form = new AccuracyEvaluation(this);
            form.ShowDialog();
        }
    }
}
