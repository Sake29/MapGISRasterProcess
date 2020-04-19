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
    public partial class 最大似然法 : Form
    {
        Form1 form = null;

        public 最大似然法(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void 最大似然法_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] selectBands = new int[3];

            //获取波段信息
            int RBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(form.RBandCmb.Text, @"[^0-9]+", ""));
            int GBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(form.GBandCmb.Text, @"[^0-9]+", ""));
            int BBand = int.Parse(System.Text.RegularExpressions.Regex.Replace(form.BBandCmb.Text, @"[^0-9]+", ""));

            selectBands[0] = RBand;
            selectBands[1] = GBand;
            selectBands[2] = BBand;

            double minProbability = 0;
            //获取参数
            try
            {
                minProbability = double.Parse(this.minProb.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("参数“最小概率”输入非法");
                return;
            }
            string DstRasURL = "GDBP://MapGisLocal/" + form.selectDBCmb.Text + "/ras/" + distanceURL.Text;
            
            //MessageBox.Show(DstRasURL);
            if (form.selectRasterCmb.Items.Contains(distanceURL.Text))
            {
                MessageBox.Show("该文件已存在！请重新输入文件名。");
                distanceURL.Text = "";
                return;
            }

            //获取待分类影像
            RasterDataSet rds = form.themeLayer.GetData() as RasterDataSet;

            //构建栅格分类器
            RasClass rc = new RasClass();
            //设置待分类影像
            rc.SetData(rds);
            //设置处理范围
            rc.SetCommonParam(selectBands, 0, 0, form.height, form.width);
            //调用分类器
            //监督分类：最大似然法
            int i = rc.RsMaxLiklihoodSupervisedClassification(minProbability, DstRasURL);

            form.selectRasterCmb.Items.Add(distanceURL.Text);

            if (i == 1)
            {
                MessageBox.Show("分类成功！");
                //将分类结果展示到界面上
                rds.Open(distanceURL.Text, 0);
                //添加分类影像到数据库
                form.selectRasterCmb.Text = distanceURL.Text;
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
    }
}
