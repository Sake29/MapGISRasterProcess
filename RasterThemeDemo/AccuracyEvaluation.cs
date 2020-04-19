using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using MapGIS.GISControl;
using MapGIS.GeoDataBase;
using MapGIS.GeoDataBase.GeoRaster;
using MapGIS.GeoMap;
using MapGIS.RasAnalysis;

namespace RasterThemeDemo
{
    public partial class AccuracyEvaluation : Form
    {
        //地理数据源
        Server Svr = new Server();
        //地理数据库
        DataBase GDB = new DataBase();
      

        //影像高度
        public int height = 0;
        //影像宽度
        public int width = 0;

        Form1 form = new Form1();


        public AccuracyEvaluation(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AccuracyEvaluation_Load(object sender, EventArgs e)
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
                selectDBCmb1.Items.Add(name);
                selectDBCmb2.Items.Add(name);
                i++;
            }
        }

        private void selectDBCmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> rCatIDs = null;

            if (selectDBCmb1.Text == null)
                return;

            selectRasterCmb1.Items.Clear();
            GDB = Svr.OpenGDB(selectDBCmb1.Text);

            //获取栅格目录的ID
            rCatIDs = GDB.GetXclses(XClsType.Rcat, 0);
            if (rCatIDs != null)
            {
                int count = rCatIDs.Count;

                //获取栅格目录中栅格数据集的信息
                for (int i = 0; i < count; i++)
                    getRasterData(XClsType.Rds, rCatIDs[i], selectRasterCmb1);
            }
            //直接获取数据库中栅格数据的信息
            getRasterData(XClsType.Rds, 0, selectRasterCmb1);

            selectRasterCmb1.Text = "";
            selectRasterCmb1.SelectedIndex = -1;
        }

        private void selectDBCmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> rCatIDs = null;

            if (selectDBCmb2.Text == null)
                return;

            selectRasterCmb2.Items.Clear();
            GDB = Svr.OpenGDB(selectDBCmb2.Text);

            //获取栅格目录的ID
            rCatIDs = GDB.GetXclses(XClsType.Rcat, 0);
            if (rCatIDs != null)
            {
                int count = rCatIDs.Count;

                //获取栅格目录中栅格数据集的信息
                for (int i = 0; i < count; i++)
                    getRasterData(XClsType.Rds, rCatIDs[i], selectRasterCmb2);
            }
            //直接获取数据库中栅格数据的信息
            getRasterData(XClsType.Rds, 0, selectRasterCmb2);

            selectRasterCmb2.Text = "";
            selectRasterCmb2.SelectedIndex = -1;
        }

        // 获取栅格数据的id和name
        public void getRasterData(XClsType type, int FdsID,ComboBox selectRasterCmb)
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

        private void button_Click(object sender, EventArgs e)
        {
            //获取参数
            //原始图像路径
            string OriRasURL = "GDBP://MapGisLocal/" + selectDBCmb1.Text + "/ras/" + selectRasterCmb1.Text;
            //分类图像路径
            string ClsRasURL = "GDBP://MapGisLocal/" + selectDBCmb2.Text + "/ras/" + selectRasterCmb2.Text;
            //评价结果路径
            string result = resultPath.Text;

            //统计参数
            bool ErrMatrix = false;
            bool ClsAccu = false;
            bool TtlAccu = false;
            bool Kappa = false;
            if (this.ErrMatrix.Checked == true)
            {
                ErrMatrix = true;
            }
            if (this.ClsAccu.Checked == true)
            {
                ClsAccu = true;
            }
            if (this.TtlAccu.Checked == true)
            {
                TtlAccu = true;
            }
            if (this.Kappa.Checked == true)
            {
                Kappa = true;
            }


            RasterDataSet ori_rds = new RasterDataSet();
            RasterDataSet cls_rds = new RasterDataSet();
            ori_rds.OpenByURL(OriRasURL, RasAccessType.RasAccessType_Update);
            cls_rds.OpenByURL(ClsRasURL, RasAccessType.RasAccessType_Update);
            //显示图像信息
            height = cls_rds.GetPixelHeight();
            width = cls_rds.GetPixelWidth();

            //生成评价器
            RasClassificationAnalyse rca = new RasClassificationAnalyse();
            //设置初始参数
            rca.SetData(cls_rds,cls_rds.BandCount);
            //设置处理范围
            rca.SetCommonParam(0, 0, height, width);
            //调用评价器
            int i = rca.RsClassificationAccuracyAnalyse(ori_rds, ErrMatrix, ClsAccu, TtlAccu, Kappa, result);
            if (i > 0)
            {
                MessageBox.Show("精度评价完成！");
            }
            else
            {
                MessageBox.Show("精度评价失败！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "";

            SaveFileDialog dialog = new SaveFileDialog();

            //此处仅列出三种格式，更多格式，请参考MapGIS.GeoMap.ImgType枚举类
            dialog.Filter = "文本文件 (*.txt)|*.txt";

            dialog.ShowDialog();

            url = dialog.FileName;


            if (url == "")
                return;

            this.resultPath.Text = url;
        }
    }
}
