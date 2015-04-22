using ESRI.ArcGIS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Display;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //申明窗体层全局变量：
        ITOCControl mTOCControl;
        ILayer pMoveLayer;
        int toIndex;
        public Form1()
        {
            InitializeComponent();
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void axToolbarControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IToolbarControlEvents_OnMouseDownEvent e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axTOCControl1.SetBuddyControl(axMapControl1);
            mTOCControl = axTOCControl1.Object as ITOCControl; 

        }

        //打开
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\大连矢量化\\";
            ofd.Filter = "Map Document|*.mxd";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IMapControlDefault pMCD;
                pMCD = axMapControl1.Object as IMapControlDefault;
                string strFileName = ofd.FileName;
                bool bRet=pMCD.CheckMxFile(strFileName);
                if (bRet)
                {
                    pMCD.LoadMxFile(strFileName, null, Type.Missing);
                    axMapEve.LoadMxFile(strFileName);
                    ICommand Cmd = new ControlsMapFullExtentCommand();
                    Cmd.OnCreate(this.axMapEve.Object);
                    Cmd.OnClick();
                }
            }

        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
        //    IMapControlDefault pMCD;
        //    pMCD = axMapControl1.Object as IMapControlDefault;

        //    IMap pMap;
        //    pMap = pMCD.Map;

        //    IGeometry pGeom;
        //    pGeom = pMCD.TrackPolygon();
        //    pMap.SelectByShape(pGeom, null, false);

        //    pMCD.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
        }

        //放大
        private void BtnZoomIn_Click_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomInTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //缩小
        private void BtnZoomOut_Click_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomOutTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //漫游
        private void BtnPan_Click_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapPanTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //选择
        private void BtnSelect_Click_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsSelectTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //识别
        private void Btn_Identify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapIdentifyTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //测量
        private void Btn_Measure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapMeasureTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        //选择要素
        private void Btn_SelectFeature_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsSelectFeaturesTool();
            Cmd.OnCreate(this.axMapControl1.Object);
            this.axMapControl1.CurrentTool = Cmd as ITool;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            axMapControl1.Refresh();
        }

        //全图
        private void BtnViewAll_Click_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapFullExtentCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //上一视图
        private void Btn_Last_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentBackCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }

        //下一视图
        private void Btn_Next_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ICommand Cmd = new ControlsMapZoomToLastExtentForwardCommand();
            Cmd.OnCreate(this.axMapControl1.Object);
            Cmd.OnClick();
        }
        
        //鹰眼
        private void axMapEve_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            IPoint Pnt;
            Pnt = new ESRI.ArcGIS.Geometry.Point();
            Pnt.PutCoords(e.mapX, e.mapY);
            axMapControl1.CenterAt(Pnt);
            axMapControl1.Refresh();

        }

        private void axMapControl1_OnExtentUpdated(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //定义边界对象
            IEnvelope pEnv;
            pEnv = e.newEnvelope as IEnvelope;
            IGraphicsContainer pGraphicsContainer;
            IActiveView pActiveView;
            //获取鹰眼图地图数据的图形容器句柄
            try
            {
                pGraphicsContainer = axMapEve.Map as IGraphicsContainer;
                pActiveView = pGraphicsContainer as IActiveView;
                pGraphicsContainer.DeleteAllElements();
                RectangleElement pRectangleEle;
                pRectangleEle = new RectangleElement();
                IElement pEle;
                pEle = pRectangleEle as IElement;
                pEle.Geometry = pEnv;
                IRgbColor pColor;
                pColor = new RgbColor();
                pColor.Transparency = 255;
                pColor.Red = 255;
                ILineSymbol pOutline;
                pOutline = new SimpleLineSymbol();
                pOutline.Width = 1;
                pOutline.Color = pColor;
                pColor = new RgbColor();
                pColor.Transparency = 0;
                IFillSymbol pFillSymbol;
                pFillSymbol = new SimpleFillSymbol();
                pFillSymbol.Color = pColor;
                pFillSymbol.Outline = pOutline;
                IFillShapeElement pFillshapeEle;
                pFillshapeEle = pEle as IFillShapeElement;
                pFillshapeEle.Symbol = pFillSymbol;
                pEle = pFillshapeEle as IElement;
                pGraphicsContainer.AddElement(pEle, 0);
                pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
            }
            catch (Exception exception)
            { 
            
            }

        }

        //图层拖动
        private void axTOCControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
                esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap map = null;
                ILayer layer = null;
                object other = null;
                object index = null;
                mTOCControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
                if (item == esriTOCControlItem.esriTOCControlItemLayer)
                {
                    if (layer is IAnnotationSublayer)   //注记层在表层，不参与移动
                        return;
                    else
                        pMoveLayer = layer;
                }
            }

        }

        private void axTOCControl1_OnMouseUp(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseUpEvent e)
        {
            if (e.button == 1)
            {
                esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap map = null;
                ILayer layer = null;
                object other = null;
                object index = null;
                mTOCControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
                IMap pMap = axMapControl1.ActiveView.FocusMap;
                if (item == esriTOCControlItem.esriTOCControlItemLayer || layer != null)
                {
                    //预移动图层和鼠标当前位置图层不一致时
                    if (pMoveLayer != layer)
                    {
                        ILayer pTempLayer;
                        for (int i = 0; i < pMap.LayerCount; i++)
                        {
                            pTempLayer = pMap.get_Layer(i);
                            //获取鼠标当前位置图层的索引值
                            if (pTempLayer == layer)
                            {
                                toIndex = i;
                            }
                        }
                        pMap.MoveLayer(pMoveLayer, toIndex);
                        axMapControl1.ActiveView.Refresh();
                        mTOCControl.Update();
                    }
                }
            }

        }

        //修改界面皮肤、风格
        private void AlterSkin1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Black";
        }

        private void AlterSkin2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
        }

        private void AlterSkin3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
        }

        private void AlterSkin4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
        }

        private void AlterSkin5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Seven Classic";
        }

        private void AlterStyle1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
        }

        private void AlterStyle2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void AlterStyle3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
        }
        //默认皮肤、风格
        private void Default_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Style";
        }


        //状态栏经纬度、比例尺
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            string XYTxt = "经度:" + e.mapX.ToString("#0.0000") + ",纬度:" + e.mapY.ToString("#0.0000") + "  比例尺:1:" + axMapControl1.MapScale.ToString("#0");
            Lbl_XYScale.Caption = XYTxt;
        }
    }

}

