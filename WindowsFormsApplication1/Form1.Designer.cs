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
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.AlterSkin = new DevExpress.XtraBars.BarSubItem();
            this.AlterSkin1 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSkin2 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSkin3 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSkin4 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSkin5 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSkin6 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterSytle = new DevExpress.XtraBars.BarSubItem();
            this.AlterStyle1 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterStyle2 = new DevExpress.XtraBars.BarButtonItem();
            this.AlterStyle3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.file = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.controls = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.view = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.Lbl_XYScale = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Default = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.Btn_Next,
            this.barSubItem1,
            this.AlterSkin,
            this.AlterSkin1,
            this.AlterSkin2,
            this.AlterSkin3,
            this.AlterSkin4,
            this.AlterSkin5,
            this.AlterSkin6,
            this.AlterSytle,
            this.AlterStyle1,
            this.AlterStyle2,
            this.AlterStyle3,
            this.barButtonItem2,
            this.Default});
            this.Btn_Refresh.Location = new System.Drawing.Point(0, 0);
            this.Btn_Refresh.MaxItemId = 27;
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
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 13;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // AlterSkin
            // 
            this.AlterSkin.Caption = "修改皮肤";
            this.AlterSkin.Id = 14;
            this.AlterSkin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AlterSkin.LargeGlyph")));
            this.AlterSkin.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterSkin1),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterSkin2),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterSkin3),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterSkin4),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterSkin5)});
            this.AlterSkin.Name = "AlterSkin";
            // 
            // AlterSkin1
            // 
            this.AlterSkin1.Caption = "Office 2010 Black";
            this.AlterSkin1.Id = 15;
            this.AlterSkin1.Name = "AlterSkin1";
            this.AlterSkin1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterSkin1_ItemClick);
            // 
            // AlterSkin2
            // 
            this.AlterSkin2.Caption = "Office 2013";
            this.AlterSkin2.Id = 16;
            this.AlterSkin2.Name = "AlterSkin2";
            this.AlterSkin2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterSkin2_ItemClick);
            // 
            // AlterSkin3
            // 
            this.AlterSkin3.Caption = "DevExpress Dark Style";
            this.AlterSkin3.Id = 17;
            this.AlterSkin3.Name = "AlterSkin3";
            this.AlterSkin3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterSkin3_ItemClick);
            // 
            // AlterSkin4
            // 
            this.AlterSkin4.Caption = "VS2010";
            this.AlterSkin4.Id = 18;
            this.AlterSkin4.Name = "AlterSkin4";
            this.AlterSkin4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterSkin4_ItemClick);
            // 
            // AlterSkin5
            // 
            this.AlterSkin5.Caption = "Seven Classic";
            this.AlterSkin5.Id = 19;
            this.AlterSkin5.Name = "AlterSkin5";
            this.AlterSkin5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterSkin5_ItemClick);
            // 
            // AlterSkin6
            // 
            this.AlterSkin6.Caption = "3D";
            this.AlterSkin6.Id = 20;
            this.AlterSkin6.Name = "AlterSkin6";
            // 
            // AlterSytle
            // 
            this.AlterSytle.Caption = "修改风格";
            this.AlterSytle.Id = 21;
            this.AlterSytle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AlterSytle.LargeGlyph")));
            this.AlterSytle.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterStyle1),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterStyle2),
            new DevExpress.XtraBars.LinkPersistInfo(this.AlterStyle3)});
            this.AlterSytle.Name = "AlterSytle";
            // 
            // AlterStyle1
            // 
            this.AlterStyle1.Caption = "3D";
            this.AlterStyle1.Id = 22;
            this.AlterStyle1.Name = "AlterStyle1";
            this.AlterStyle1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterStyle1_ItemClick);
            // 
            // AlterStyle2
            // 
            this.AlterStyle2.Caption = "Flat";
            this.AlterStyle2.Id = 23;
            this.AlterStyle2.Name = "AlterStyle2";
            this.AlterStyle2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterStyle2_ItemClick);
            // 
            // AlterStyle3
            // 
            this.AlterStyle3.Caption = "Office 2003";
            this.AlterStyle3.Id = 24;
            this.AlterStyle3.Name = "AlterStyle3";
            this.AlterStyle3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AlterStyle3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.file,
            this.controls,
            this.view,
            this.skin});
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
            // skin
            // 
            this.skin.ItemLinks.Add(this.AlterSkin);
            this.skin.ItemLinks.Add(this.AlterSytle);
            this.skin.ItemLinks.Add(this.Default);
            this.skin.Name = "skin";
            this.skin.Text = "主题";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Lbl_XYScale});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Lbl_XYScale)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // Lbl_XYScale
            // 
            this.Lbl_XYScale.Id = 0;
            this.Lbl_XYScale.Name = "Lbl_XYScale";
            this.Lbl_XYScale.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1350, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 682);
            this.barDockControlBottom.Size = new System.Drawing.Size(1350, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 682);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1350, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 682);
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
            this.panelContainer1.Size = new System.Drawing.Size(268, 537);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // layers
            // 
            this.layers.Controls.Add(this.controlContainer1);
            this.layers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.layers.ID = new System.Guid("84236ce0-15f7-4a60-a91e-e2ca7c08d24e");
            this.layers.Location = new System.Drawing.Point(0, 0);
            this.layers.Name = "layers";
            this.layers.OriginalSize = new System.Drawing.Size(268, 269);
            this.layers.Size = new System.Drawing.Size(268, 267);
            this.layers.Text = "图层控制";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.axTOCControl1);
            this.controlContainer1.Location = new System.Drawing.Point(4, 23);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(260, 240);
            this.controlContainer1.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(260, 240);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
            // 
            // eye
            // 
            this.eye.Controls.Add(this.dockPanel1_Container);
            this.eye.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.eye.ID = new System.Guid("ec5229bd-ceba-41fe-a452-086f90b008dc");
            this.eye.Location = new System.Drawing.Point(0, 267);
            this.eye.Name = "eye";
            this.eye.OriginalSize = new System.Drawing.Size(268, 272);
            this.eye.Size = new System.Drawing.Size(268, 270);
            this.eye.Text = "鹰眼";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.axMapEve);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(260, 243);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // axMapEve
            // 
            this.axMapEve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapEve.Location = new System.Drawing.Point(0, 0);
            this.axMapEve.Name = "axMapEve";
            this.axMapEve.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapEve.OcxState")));
            this.axMapEve.Size = new System.Drawing.Size(260, 243);
            this.axMapEve.TabIndex = 0;
            this.axMapEve.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapEve_OnMouseDown);
            // 
            // attribute
            // 
            this.attribute.Controls.Add(this.controlContainer2);
            this.attribute.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.attribute.FloatVertical = true;
            this.attribute.ID = new System.Guid("96c1d187-4960-41c6-a525-e9951aed37ad");
            this.attribute.Location = new System.Drawing.Point(268, 553);
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
            this.axMapControl1.Size = new System.Drawing.Size(1082, 408);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Default";
            this.barButtonItem2.Id = 25;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // Default
            // 
            this.Default.Caption = "恢复默认";
            this.Default.Id = 26;
            this.Default.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Default.LargeGlyph")));
            this.Default.Name = "Default";
            this.Default.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Default_ItemClick);
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
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem AlterSkin;
        private DevExpress.XtraBars.BarButtonItem AlterSkin1;
        private DevExpress.XtraBars.BarButtonItem AlterSkin2;
        private DevExpress.XtraBars.BarButtonItem AlterSkin3;
        private DevExpress.XtraBars.BarButtonItem AlterSkin4;
        private DevExpress.XtraBars.BarButtonItem AlterSkin5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skin;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem AlterSkin6;
        private DevExpress.XtraBars.BarSubItem AlterSytle;
        private DevExpress.XtraBars.BarButtonItem AlterStyle1;
        private DevExpress.XtraBars.BarButtonItem AlterStyle2;
        private DevExpress.XtraBars.BarButtonItem AlterStyle3;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem Lbl_XYScale;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem Default;
    }
}

