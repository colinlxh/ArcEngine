namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Refresh = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_open = new DevExpress.XtraBars.BarButtonItem();
            this.BtnZoomIn_Click = new DevExpress.XtraBars.BarButtonItem();
            this.BtnZoomOut_Click = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPan_Click = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSelect_Click = new DevExpress.XtraBars.BarButtonItem();
            this.BtnViewAll_Click = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Identify = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Measure = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_SelectFeature = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Last = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Next = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.file = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.controls = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.view = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.layers = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.eye = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.axMapEve = new ESRI.ArcGIS.Controls.AxMapControl();
            this.attribute = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.layers.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.eye.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapEve)).BeginInit();
            this.attribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.ExpandCollapseItem.Id = 0;
            this.Btn_Refresh.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Btn_Refresh.ExpandCollapseItem,
            this.btn_open,
            this.BtnZoomIn_Click,
            this.BtnZoomOut_Click,
            this.BtnPan_Click,
            this.BtnSelect_Click,
            this.BtnViewAll_Click,
            this.Btn_Identify,
            this.Btn_Measure,
            this.Btn_SelectFeature,
            this.barButtonItem1,
            this.Btn_Last,
            this.Btn_Next});
            this.Btn_Refresh.Location = new System.Drawing.Point(0, 0);
            this.Btn_Refresh.MaxItemId = 13;
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.Btn_Refresh.Size = new System.Drawing.Size(1350, 145);
            this.Btn_Refresh.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_open
            // 
            this.btn_open.Caption = "打开地图";
            this.btn_open.Id = 1;
            this.btn_open.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_open.LargeGlyph")));
            this.btn_open.Name = "btn_open";
            this.btn_open.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnZoomIn_Click
            // 
            this.BtnZoomIn_Click.Caption = "放大";
            this.BtnZoomIn_Click.Description = "放大";
            this.BtnZoomIn_Click.Id = 2;
            this.BtnZoomIn_Click.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnZoomIn_Click.LargeGlyph")));
            this.BtnZoomIn_Click.Name = "BtnZoomIn_Click";
            this.BtnZoomIn_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnZoomIn_Click_ItemClick);
            // 
            // BtnZoomOut_Click
            // 
            this.BtnZoomOut_Click.Caption = "缩小";
            this.BtnZoomOut_Click.Id = 3;
            this.BtnZoomOut_Click.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnZoomOut_Click.LargeGlyph")));
            this.BtnZoomOut_Click.Name = "BtnZoomOut_Click";
            this.BtnZoomOut_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnZoomOut_Click_ItemClick);
            // 
            // BtnPan_Click
            // 
            this.BtnPan_Click.Caption = "漫游";
            this.BtnPan_Click.Id = 4;
            this.BtnPan_Click.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnPan_Click.LargeGlyph")));
            this.BtnPan_Click.Name = "BtnPan_Click";
            this.BtnPan_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPan_Click_ItemClick);
            // 
            // BtnSelect_Click
            // 
            this.BtnSelect_Click.Caption = "选择";
            this.BtnSelect_Click.Id = 5;
            this.BtnSelect_Click.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnSelect_Click.LargeGlyph")));
            this.BtnSelect_Click.Name = "BtnSelect_Click";
            this.BtnSelect_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSelect_Click_ItemClick);
            // 
            // BtnViewAll_Click
            // 
            this.BtnViewAll_Click.Caption = "全图显示";
            this.BtnViewAll_Click.Id = 6;
            this.BtnViewAll_Click.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BtnViewAll_Click.LargeGlyph")));
            this.BtnViewAll_Click.Name = "BtnViewAll_Click";
            this.BtnViewAll_Click.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnViewAll_Click_ItemClick);
            // 
            // Btn_Identify
            // 
            this.Btn_Identify.Caption = "属性";
            this.Btn_Identify.Id = 7;
            this.Btn_Identify.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_Identify.LargeGlyph")));
            this.Btn_Identify.Name = "Btn_Identify";
            this.Btn_Identify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Identify_ItemClick);
            // 
            // Btn_Measure
            // 
            this.Btn_Measure.Caption = "测量";
            this.Btn_Measure.Id = 8;
            this.Btn_Measure.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_Measure.LargeGlyph")));
            this.Btn_Measure.Name = "Btn_Measure";
            this.Btn_Measure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Measure_ItemClick);
            // 
            // Btn_SelectFeature
            // 
            this.Btn_SelectFeature.Caption = "选择要素";
            this.Btn_SelectFeature.Id = 9;
            this.Btn_SelectFeature.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_SelectFeature.LargeGlyph")));
            this.Btn_SelectFeature.Name = "Btn_SelectFeature";
            this.Btn_SelectFeature.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_SelectFeature_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "刷新地图";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Caption = "前一视图";
            this.Btn_Last.Id = 11;
            this.Btn_Last.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_Last.LargeGlyph")));
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Last_ItemClick);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Caption = "后一视图";
            this.Btn_Next.Id = 12;
            this.Btn_Next.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_Next.LargeGlyph")));
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Next_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.file,
            this.controls,
            this.view});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "菜单";
            // 
            // file
            // 
            this.file.ItemLinks.Add(this.btn_open);
            this.file.ItemLinks.Add(this.barButtonItem1);
            this.file.Name = "file";
            this.file.Text = "文件";
            // 
            // controls
            // 
            this.controls.ItemLinks.Add(this.BtnZoomIn_Click);
            this.controls.ItemLinks.Add(this.BtnZoomOut_Click);
            this.controls.ItemLinks.Add(this.BtnPan_Click);
            this.controls.ItemLinks.Add(this.BtnSelect_Click);
            this.controls.ItemLinks.Add(this.Btn_Identify);
            this.controls.ItemLinks.Add(this.Btn_Measure);
            this.controls.ItemLinks.Add(this.Btn_SelectFeature);
            this.controls.Name = "controls";
            this.controls.Text = "地图";
            // 
            // view
            // 
            this.view.ItemLinks.Add(this.BtnViewAll_Click);
            this.view.ItemLinks.Add(this.Btn_Last);
            this.view.ItemLinks.Add(this.Btn_Next);
            this.view.Name = "view";
            this.view.Text = "显示";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.attribute});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.layers);
            this.panelContainer1.Controls.Add(this.eye);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.ID = new System.Guid("ed4dc08a-a0f2-4974-82fb-1e5ce8762928");
            this.panelContainer1.Location = new System.Drawing.Point(0, 145);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(268, 200);
            this.panelContainer1.Size = new System.Drawing.Size(268, 564);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // layers
            // 
            this.layers.Controls.Add(this.controlContainer1);
            this.layers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.layers.ID = new System.Guid("84236ce0-15f7-4a60-a91e-e2ca7c08d24e");
            this.layers.Location = new System.Drawing.Point(0, 0);
            this.layers.Name = "layers";
            this.layers.OriginalSize = new System.Drawing.Size(268, 292);
            this.layers.Size = new System.Drawing.Size(268, 282);
            this.layers.Text = "图层控制";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.axTOCControl1);
            this.controlContainer1.Location = new System.Drawing.Point(4, 23);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(260, 255);
            this.controlContainer1.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(260, 255);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
            // 
            // eye
            // 
            this.eye.Controls.Add(this.dockPanel1_Container);
            this.eye.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.eye.ID = new System.Guid("ec5229bd-ceba-41fe-a452-086f90b008dc");
            this.eye.Location = new System.Drawing.Point(0, 282);
            this.eye.Name = "eye";
            this.eye.OriginalSize = new System.Drawing.Size(268, 292);
            this.eye.Size = new System.Drawing.Size(268, 282);
            this.eye.Text = "鹰眼";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.axMapEve);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(260, 255);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // axMapEve
            // 
            this.axMapEve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapEve.Location = new System.Drawing.Point(0, 0);
            this.axMapEve.Name = "axMapEve";
            this.axMapEve.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapEve.OcxState")));
            this.axMapEve.Size = new System.Drawing.Size(260, 255);
            this.axMapEve.TabIndex = 0;
            this.axMapEve.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapEve_OnMouseDown);
            // 
            // attribute
            // 
            this.attribute.Controls.Add(this.controlContainer2);
            this.attribute.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.attribute.FloatVertical = true;
            this.attribute.ID = new System.Guid("96c1d187-4960-41c6-a525-e9951aed37ad");
            this.attribute.Location = new System.Drawing.Point(268, 580);
            this.attribute.Name = "attribute";
            this.attribute.OriginalSize = new System.Drawing.Size(200, 129);
            this.attribute.Size = new System.Drawing.Size(1082, 129);
            this.attribute.Text = "属性";
            // 
            // controlContainer2
            // 
            this.controlContainer2.Location = new System.Drawing.Point(4, 23);
            this.controlContainer2.Name = "controlContainer2";
            this.controlContainer2.Size = new System.Drawing.Size(1074, 102);
            this.controlContainer2.TabIndex = 0;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(268, 145);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1082, 435);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(202, 497);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 709);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.attribute);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.Btn_Refresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.layers.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.eye.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapEve)).EndInit();
            this.attribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Btn_Refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup file;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel eye;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel layers;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Docking.DockPanel attribute;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private DevExpress.XtraBars.BarButtonItem btn_open;
        private DevExpress.XtraBars.BarButtonItem BtnZoomIn_Click;
        private DevExpress.XtraBars.BarButtonItem BtnZoomOut_Click;
        private DevExpress.XtraBars.BarButtonItem BtnPan_Click;
        private DevExpress.XtraBars.BarButtonItem BtnSelect_Click;
        private DevExpress.XtraBars.BarButtonItem BtnViewAll_Click;
        private ESRI.ArcGIS.Controls.AxMapControl axMapEve;
        private DevExpress.XtraBars.BarButtonItem Btn_Identify;
        private DevExpress.XtraBars.BarButtonItem Btn_Measure;
        private DevExpress.XtraBars.BarButtonItem Btn_SelectFeature;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup controls;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup view;
        private DevExpress.XtraBars.BarButtonItem Btn_Last;
        private DevExpress.XtraBars.BarButtonItem Btn_Next;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
    }
}

