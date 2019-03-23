using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015年GIS
{
    class Program
    {
        static void Main(string[] args)
        {

            pLayer = this.axMapControl1.get_Layer(i);//所要加的层  
            IFeatureLayer pFeatureLyr = pLayer as IFeatureLayer;//将ILayer转换为IFeaturelayer，为了对图层上的要素进行编辑  
            IFeatureClass pFeatCls = pFeatureLyr.FeatureClass;//定义一个要素集合，并获取图层的要素集合  
            IFeatureClassWrite fr = (IFeatureClassWrite)pFeatCls;//定义一个实现新增要素的接口实例，并该实例作用于当前图层的要素集  
            IWorkspaceEdit w = (pFeatCls as IDataset).Workspace as IWorkspaceEdit;//定义一个工作编辑工作空间，用于开启前图层的编辑状态  
            IFeature f;//定义一个IFeature实例，用于添加到当前图层上  
            w.StartEditing(true);//开启编辑状态  
            w.StartEditOperation();//开启编辑操作  
            IPoint p;//定义一个点，用来作为IFeature实例的形状属性，即shape属性  
            //下面是设置点的坐标和参考系  
            p = new PointClass();
            p.SpatialReference = this.axMapControl1.SpatialReference;
            p.X = 600;
            p.Y = 500;

            //将IPoint设置为IFeature的shape属性时，需要通过中间接口IGeometry转换  
            IGeometry peo;
            peo = p;
            f = pFeatCls.CreateFeature();//实例化IFeature对象， 这样IFeature对象就具有当前图层上要素的字段信息  
            f.Shape = peo;//设置IFeature对象的形状属性  
            f.set_Value(3, "house1");//设置IFeature对象的索引是3的字段值  
            f.Store();//保存IFeature对象  
            fr.WriteFeature(f);//将IFeature对象，添加到当前图层上  
            w.StopEditOperation();//停止编辑操作  
            w.StopEditing(true);//关闭编辑状态，并保存修改  
            this.axMapControl1.Refresh();//刷新地图
        }
    }
}
