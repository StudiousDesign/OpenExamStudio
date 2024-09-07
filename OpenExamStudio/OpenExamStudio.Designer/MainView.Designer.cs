namespace OpenExamStudio.Designer
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.btnLoadExam = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanelNavigation = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.dockPanelToolbox = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtExamAuthor = new DevExpress.XtraEditors.TextEdit();
            this.lciExamAuthor = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtExamDescription = new DevExpress.XtraEditors.TextEdit();
            this.lciExamDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtExamName = new DevExpress.XtraEditors.TextEdit();
            this.lciExamName = new DevExpress.XtraLayout.LayoutControlItem();
            this.spinEditExamLength = new DevExpress.XtraEditors.SpinEdit();
            this.lciExamTime = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanelNavigation.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.dockPanelToolbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditExamLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamTime)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinPaletteDropDownButtonItem1,
            this.btnLoadExam});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinPaletteDropDownButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadExam)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 0;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // btnLoadExam
            // 
            this.btnLoadExam.Caption = "&Load Exam";
            this.btnLoadExam.Id = 7;
            this.btnLoadExam.Name = "btnLoadExam";
            this.btnLoadExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoadExam_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1918, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1046);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1007);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1918, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1007);
            // 
            // documentManager1
            // 
            this.documentManager1.ClientControl = this.layoutControl1;
            this.documentManager1.MenuManager = this.barManager1;
            this.documentManager1.View = this.noDocumentsView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1,
            this.noDocumentsView1});
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelNavigation,
            this.dockPanelToolbox});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(3302, 738);
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("cc3dbb82-2deb-4c7f-bfc9-dbe81b7d2059");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedDockingContainerId = new System.Guid("bca5d8c1-ba21-4410-9e51-3d028c1c4db2");
            this.dockPanel1.SavedIndex = 2;
            this.dockPanel1.SavedMdiDocumentIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 36);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 163);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanelNavigation
            // 
            this.dockPanelNavigation.Controls.Add(this.dockPanel2_Container);
            this.dockPanelNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelNavigation.ID = new System.Guid("f31dafdf-a6f2-4e52-bef5-c544111511dc");
            this.dockPanelNavigation.Location = new System.Drawing.Point(0, 39);
            this.dockPanelNavigation.Name = "dockPanelNavigation";
            this.dockPanelNavigation.OriginalSize = new System.Drawing.Size(243, 200);
            this.dockPanelNavigation.Size = new System.Drawing.Size(243, 1007);
            this.dockPanelNavigation.Text = "Exam Navigation";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.navBarControl1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 38);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(236, 966);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 236;
            this.navBarControl1.Size = new System.Drawing.Size(236, 966);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // dockPanelToolbox
            // 
            this.dockPanelToolbox.Controls.Add(this.dockPanel3_Container);
            this.dockPanelToolbox.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanelToolbox.ID = new System.Guid("ff58edfa-5c7f-40bc-ad61-231dbe20972c");
            this.dockPanelToolbox.Location = new System.Drawing.Point(1718, 39);
            this.dockPanelToolbox.Name = "dockPanelToolbox";
            this.dockPanelToolbox.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelToolbox.Size = new System.Drawing.Size(200, 1007);
            this.dockPanelToolbox.Text = "Toolbox";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 38);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(193, 966);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = this.barManager1;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(180, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciExamAuthor,
            this.emptySpaceItem1,
            this.lciExamDescription,
            this.lciExamName,
            this.lciExamTime});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1475, 1007);
            this.Root.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEditExamLength);
            this.layoutControl1.Controls.Add(this.txtExamName);
            this.layoutControl1.Controls.Add(this.txtExamDescription);
            this.layoutControl1.Controls.Add(this.txtExamAuthor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(243, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1475, 1007);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtExamAuthor
            // 
            this.txtExamAuthor.Location = new System.Drawing.Point(842, 16);
            this.txtExamAuthor.MenuManager = this.barManager1;
            this.txtExamAuthor.Name = "txtExamAuthor";
            this.txtExamAuthor.Size = new System.Drawing.Size(254, 28);
            this.txtExamAuthor.StyleController = this.layoutControl1;
            this.txtExamAuthor.TabIndex = 4;
            // 
            // lciExamAuthor
            // 
            this.lciExamAuthor.Control = this.txtExamAuthor;
            this.lciExamAuthor.Location = new System.Drawing.Point(724, 0);
            this.lciExamAuthor.Name = "lciExamAuthor";
            this.lciExamAuthor.Size = new System.Drawing.Size(362, 34);
            this.lciExamAuthor.Text = "Exam Author:";
            this.lciExamAuthor.TextSize = new System.Drawing.Size(86, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 34);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1449, 947);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtExamDescription
            // 
            this.txtExamDescription.Location = new System.Drawing.Point(480, 16);
            this.txtExamDescription.MenuManager = this.barManager1;
            this.txtExamDescription.Name = "txtExamDescription";
            this.txtExamDescription.Size = new System.Drawing.Size(254, 28);
            this.txtExamDescription.StyleController = this.layoutControl1;
            this.txtExamDescription.TabIndex = 5;
            // 
            // lciExamDescription
            // 
            this.lciExamDescription.Control = this.txtExamDescription;
            this.lciExamDescription.Location = new System.Drawing.Point(362, 0);
            this.lciExamDescription.Name = "lciExamDescription";
            this.lciExamDescription.Size = new System.Drawing.Size(362, 34);
            this.lciExamDescription.Text = "Exam Description:";
            this.lciExamDescription.TextSize = new System.Drawing.Size(86, 13);
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(118, 16);
            this.txtExamName.MenuManager = this.barManager1;
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(254, 28);
            this.txtExamName.StyleController = this.layoutControl1;
            this.txtExamName.TabIndex = 6;
            // 
            // lciExamName
            // 
            this.lciExamName.Control = this.txtExamName;
            this.lciExamName.Location = new System.Drawing.Point(0, 0);
            this.lciExamName.Name = "lciExamName";
            this.lciExamName.Size = new System.Drawing.Size(362, 34);
            this.lciExamName.Text = "Exam Name:";
            this.lciExamName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // spinEditExamLength
            // 
            this.spinEditExamLength.EditValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinEditExamLength.Location = new System.Drawing.Point(1204, 16);
            this.spinEditExamLength.MenuManager = this.barManager1;
            this.spinEditExamLength.Name = "spinEditExamLength";
            this.spinEditExamLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditExamLength.Size = new System.Drawing.Size(255, 28);
            this.spinEditExamLength.StyleController = this.layoutControl1;
            this.spinEditExamLength.TabIndex = 7;
            // 
            // lciExamTime
            // 
            this.lciExamTime.Control = this.spinEditExamLength;
            this.lciExamTime.Location = new System.Drawing.Point(1086, 0);
            this.lciExamTime.Name = "lciExamTime";
            this.lciExamTime.Size = new System.Drawing.Size(363, 34);
            this.lciExamTime.Text = "Exam Length:";
            this.lciExamTime.TextSize = new System.Drawing.Size(86, 13);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1046);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dockPanelToolbox);
            this.Controls.Add(this.dockPanelNavigation);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainVIew";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanelNavigation.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.dockPanelToolbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExamAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditExamLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExamTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelToolbox;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelNavigation;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem btnLoadExam;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraEditors.SpinEdit spinEditExamLength;
        private DevExpress.XtraEditors.TextEdit txtExamName;
        private DevExpress.XtraEditors.TextEdit txtExamDescription;
        private DevExpress.XtraEditors.TextEdit txtExamAuthor;
        private DevExpress.XtraLayout.LayoutControlItem lciExamAuthor;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciExamDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciExamName;
        private DevExpress.XtraLayout.LayoutControlItem lciExamTime;
    }
}