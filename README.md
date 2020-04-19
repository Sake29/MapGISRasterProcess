# 基于MapGIS Object开发的遥感影像处理 #
项目地址：https://github.com/Sake29/MapGISRasterProcess  
关于MapGIS二次开发的说明可以参考司马云提供的[入门手册](http://www.smaryun.com/dev/resource_center.html#/type27/tag182/page1)

## 环境依赖 ##
vs2015+C#   
.net framework 4.0  
MapGIS10.0开发工具包


## 部署步骤 ##
1. 以管理员权限启动Visual Studio
2. 打开该项目
2. 设置生成目标平台为x64
3. 此时已经可以启动项目了，如果项目启动不了，将输出路径设置为MapGIS目录下的program

## V1.0.0 目前实现的功能 ##
1. 栅格数据的RGB显示
2. 栅格数据的监督分类（基于最大似然法）
3. 栅格数据的非监督分类  
3. 栅格数据的精度评定  
