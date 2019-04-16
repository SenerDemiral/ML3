namespace ML3
{
    partial class MTHxf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTHxf));
            this.qsDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dataSet = new ML3.DataSet1();
            this.mthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mthTableAdapter = new ML3.DataSet1TableAdapters.MTHTableAdapter();
            this.mthBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mthGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKYTYIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGMTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDTEH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qsDockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.qsDockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mthBindingNavigator)).BeginInit();
            this.mthBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mthGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qsDockManager
            // 
            this.qsDockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.qsDockManager.Form = this;
            this.qsDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.qsDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 300);
            // 
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("3bff61dd-ce16-4fd8-927d-9665bac6c151");
            this.qsDockPanel.Location = new System.Drawing.Point(-200, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.Options.AllowDockBottom = false;
            this.qsDockPanel.Options.AllowDockFill = false;
            this.qsDockPanel.Options.AllowDockTop = false;
            this.qsDockPanel.Options.AllowFloating = false;
            this.qsDockPanel.Options.FloatOnDblClick = false;
            this.qsDockPanel.Options.ShowCloseButton = false;
            this.qsDockPanel.Options.ShowMaximizeButton = false;
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(200, 300);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 273);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet1";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mthBindingSource
            // 
            this.mthBindingSource.DataMember = "MTH";
            this.mthBindingSource.DataSource = this.dataSet;
            // 
            // mthTableAdapter
            // 
            this.mthTableAdapter.ClearBeforeFill = true;
            // 
            // mthBindingNavigator
            // 
            this.mthBindingNavigator.AddNewItem = null;
            this.mthBindingNavigator.BindingSource = this.mthBindingSource;
            this.mthBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mthBindingNavigator.CountItemFormat = "{0}";
            this.mthBindingNavigator.DeleteItem = null;
            this.mthBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.addToolStripButton,
            this.bindingNavigatorSeparator2,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton,
            this.toolStripSeparator1,
            this.refreshToolStripButton,
            this.toolStripSeparator3,
            this.revertToolStripButton,
            this.toolStripSeparator4,
            this.toolStripLabel1});
            this.mthBindingNavigator.Location = new System.Drawing.Point(19, 0);
            this.mthBindingNavigator.MoveFirstItem = null;
            this.mthBindingNavigator.MoveLastItem = null;
            this.mthBindingNavigator.MoveNextItem = null;
            this.mthBindingNavigator.MovePreviousItem = null;
            this.mthBindingNavigator.Name = "mthBindingNavigator";
            this.mthBindingNavigator.PositionItem = null;
            this.mthBindingNavigator.Size = new System.Drawing.Size(858, 25);
            this.mthBindingNavigator.TabIndex = 1;
            this.mthBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(21, 22);
            this.bindingNavigatorCountItem.Text = "{0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // revertToolStripButton
            // 
            this.revertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.revertToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("revertToolStripButton.Image")));
            this.revertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.revertToolStripButton.Name = "revertToolStripButton";
            this.revertToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.revertToolStripButton.Text = "toolStripButton6";
            this.revertToolStripButton.Click += new System.EventHandler(this.revertToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel1.Text = ".";
            // 
            // mthGridControl
            // 
            this.mthGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.mthGridControl.DataSource = this.mthBindingSource;
            this.mthGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mthGridControl.Location = new System.Drawing.Point(19, 25);
            this.mthGridControl.MainView = this.gridView1;
            this.mthGridControl.Name = "mthGridControl";
            this.mthGridControl.Size = new System.Drawing.Size(858, 275);
            this.mthGridControl.TabIndex = 3;
            this.mthGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.mthGridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.mthGridControl_ProcessGridKey);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gbToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // gbToolStripMenuItem
            // 
            this.gbToolStripMenuItem.Name = "gbToolStripMenuItem";
            this.gbToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.gbToolStripMenuItem.Text = "GB";
            this.gbToolStripMenuItem.Click += new System.EventHandler(this.gbToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMTRF,
            this.colKYTYIL,
            this.colAD,
            this.colSEX,
            this.colTCKNO,
            this.colDGMTRH,
            this.colTDTEH,
            this.colMTEL,
            this.colEMAIL});
            this.gridView1.GridControl = this.mthGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAD, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMTRF
            // 
            this.colMTRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            this.colMTRF.AppearanceCell.Options.UseBackColor = true;
            this.colMTRF.DisplayFormat.FormatString = "n0";
            this.colMTRF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMTRF.FieldName = "MTRF";
            this.colMTRF.Name = "colMTRF";
            this.colMTRF.Visible = true;
            this.colMTRF.VisibleIndex = 0;
            this.colMTRF.Width = 60;
            // 
            // colKYTYIL
            // 
            this.colKYTYIL.AppearanceCell.Options.UseTextOptions = true;
            this.colKYTYIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKYTYIL.Caption = "KytYıl";
            this.colKYTYIL.FieldName = "KYTYIL";
            this.colKYTYIL.Name = "colKYTYIL";
            this.colKYTYIL.OptionsColumn.AllowEdit = false;
            this.colKYTYIL.OptionsColumn.AllowFocus = false;
            this.colKYTYIL.OptionsColumn.FixedWidth = true;
            this.colKYTYIL.Visible = true;
            this.colKYTYIL.VisibleIndex = 1;
            this.colKYTYIL.Width = 50;
            // 
            // colAD
            // 
            this.colAD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAD.AppearanceCell.Options.UseFont = true;
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 184;
            // 
            // colSEX
            // 
            this.colSEX.AppearanceCell.Options.UseTextOptions = true;
            this.colSEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSEX.Caption = "Cnsyt";
            this.colSEX.FieldName = "SEX";
            this.colSEX.Name = "colSEX";
            this.colSEX.OptionsColumn.FixedWidth = true;
            this.colSEX.Visible = true;
            this.colSEX.VisibleIndex = 3;
            this.colSEX.Width = 40;
            // 
            // colTCKNO
            // 
            this.colTCKNO.Caption = "TCKNo";
            this.colTCKNO.FieldName = "TCKNO";
            this.colTCKNO.Name = "colTCKNO";
            this.colTCKNO.OptionsColumn.FixedWidth = true;
            this.colTCKNO.ToolTip = "TC Kimlik No";
            this.colTCKNO.Visible = true;
            this.colTCKNO.VisibleIndex = 4;
            this.colTCKNO.Width = 80;
            // 
            // colDGMTRH
            // 
            this.colDGMTRH.Caption = "DğmTrh";
            this.colDGMTRH.FieldName = "DGMTRH";
            this.colDGMTRH.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear;
            this.colDGMTRH.Name = "colDGMTRH";
            this.colDGMTRH.OptionsColumn.FixedWidth = true;
            this.colDGMTRH.Visible = true;
            this.colDGMTRH.VisibleIndex = 5;
            this.colDGMTRH.Width = 60;
            // 
            // colTDTEH
            // 
            this.colTDTEH.Caption = "TDT?";
            this.colTDTEH.FieldName = "TDTEH";
            this.colTDTEH.Name = "colTDTEH";
            this.colTDTEH.OptionsColumn.FixedWidth = true;
            this.colTDTEH.ToolTip = "Tahmini Doğum Tarihi";
            this.colTDTEH.Visible = true;
            this.colTDTEH.VisibleIndex = 6;
            this.colTDTEH.Width = 40;
            // 
            // colMTEL
            // 
            this.colMTEL.Caption = "MobilTel";
            this.colMTEL.FieldName = "MTEL";
            this.colMTEL.Name = "colMTEL";
            this.colMTEL.OptionsColumn.FixedWidth = true;
            this.colMTEL.Visible = true;
            this.colMTEL.VisibleIndex = 7;
            this.colMTEL.Width = 90;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "eMail";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 8;
            this.colEMAIL.Width = 200;
            // 
            // MTHxf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 300);
            this.Controls.Add(this.mthGridControl);
            this.Controls.Add(this.mthBindingNavigator);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "MTHxf";
            this.Tag = "MTH";
            this.Text = "[MTH]●Kişiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MTHxf_FormClosing);
            this.Load += new System.EventHandler(this.MTHxf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qsDockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.qsDockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mthBindingNavigator)).EndInit();
            this.mthBindingNavigator.ResumeLayout(false);
            this.mthBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mthGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager qsDockManager;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.BindingNavigator mthBindingNavigator;
        private System.Windows.Forms.BindingSource mthBindingSource;
        private DataSet1 dataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DataSet1TableAdapters.MTHTableAdapter mthTableAdapter;
        private DevExpress.XtraGrid.GridControl mthGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colKYTYIL;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDGMTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colTDTEH;
        private DevExpress.XtraGrid.Columns.GridColumn colMTEL;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripButton revertToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gbToolStripMenuItem;
    }
}