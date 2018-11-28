namespace ML3
{
    partial class GBxf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GBxf));
            this.dataSet1 = new ML3.DataSet1();
            this.gbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbTableAdapter = new ML3.DataSet1TableAdapters.GBTableAdapter();
            this.gBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gbGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGBRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKTEH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLSSKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKBLTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPRTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGMTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDTEH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBBindingNavigator)).BeginInit();
            this.gBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbBindingSource
            // 
            this.gbBindingSource.DataMember = "GB";
            this.gbBindingSource.DataSource = this.dataSet1;
            // 
            // gbTableAdapter
            // 
            this.gbTableAdapter.ClearBeforeFill = true;
            // 
            // gBBindingNavigator
            // 
            this.gBBindingNavigator.AddNewItem = null;
            this.gBBindingNavigator.BindingSource = this.gbBindingSource;
            this.gBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gBBindingNavigator.CountItemFormat = "{0}";
            this.gBBindingNavigator.DeleteItem = null;
            this.gBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.toolStripLabel1,
            this.addToolStripButton,
            this.bindingNavigatorSeparator2,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.deleteToolStripButton,
            this.toolStripSeparator1,
            this.refreshToolStripButton,
            this.toolStripSeparator3,
            this.revertToolStripButton});
            this.gBBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gBBindingNavigator.MoveFirstItem = null;
            this.gBBindingNavigator.MoveLastItem = null;
            this.gBBindingNavigator.MoveNextItem = null;
            this.gBBindingNavigator.MovePreviousItem = null;
            this.gBBindingNavigator.Name = "gBBindingNavigator";
            this.gBBindingNavigator.PositionItem = null;
            this.gBBindingNavigator.Size = new System.Drawing.Size(1068, 25);
            this.gBBindingNavigator.TabIndex = 0;
            this.gBBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addToolStripButton.Text = "Add";
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
            // 
            // gbGridControl
            // 
            this.gbGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.gbGridControl.DataSource = this.gbBindingSource;
            this.gbGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGridControl.Location = new System.Drawing.Point(0, 25);
            this.gbGridControl.MainView = this.gridView1;
            this.gbGridControl.Name = "gbGridControl";
            this.gbGridControl.Size = new System.Drawing.Size(1068, 311);
            this.gbGridControl.TabIndex = 2;
            this.gbGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGBRF,
            this.colAKTEH,
            this.colHMTRF,
            this.colDMTRF,
            this.colGMTRF,
            this.colGLSSKL,
            this.colGLSTS,
            this.colKBLTS,
            this.colRPRTS,
            this.colFKN,
            this.colINY,
            this.colINFO,
            this.colINFO2,
            this.colDGMTRH,
            this.colTDTEH,
            this.colUSR});
            this.gridView1.GridControl = this.gbGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            // 
            // colGBRF
            // 
            this.colGBRF.DisplayFormat.FormatString = "n0";
            this.colGBRF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGBRF.FieldName = "GBRF";
            this.colGBRF.Name = "colGBRF";
            this.colGBRF.Visible = true;
            this.colGBRF.VisibleIndex = 0;
            this.colGBRF.Width = 61;
            // 
            // colAKTEH
            // 
            this.colAKTEH.Caption = "Aktif";
            this.colAKTEH.FieldName = "AKTEH";
            this.colAKTEH.Name = "colAKTEH";
            this.colAKTEH.OptionsColumn.FixedWidth = true;
            this.colAKTEH.Visible = true;
            this.colAKTEH.VisibleIndex = 1;
            this.colAKTEH.Width = 40;
            // 
            // colHMTRF
            // 
            this.colHMTRF.Caption = "Hasta";
            this.colHMTRF.FieldName = "HMTRF";
            this.colHMTRF.Name = "colHMTRF";
            this.colHMTRF.Visible = true;
            this.colHMTRF.VisibleIndex = 3;
            this.colHMTRF.Width = 91;
            // 
            // colDMTRF
            // 
            this.colDMTRF.Caption = "Doktor";
            this.colDMTRF.FieldName = "DMTRF";
            this.colDMTRF.MaxWidth = 120;
            this.colDMTRF.Name = "colDMTRF";
            this.colDMTRF.Visible = true;
            this.colDMTRF.VisibleIndex = 4;
            this.colDMTRF.Width = 91;
            // 
            // colGMTRF
            // 
            this.colGMTRF.Caption = "Gönderen";
            this.colGMTRF.FieldName = "GMTRF";
            this.colGMTRF.MaxWidth = 120;
            this.colGMTRF.Name = "colGMTRF";
            this.colGMTRF.Visible = true;
            this.colGMTRF.VisibleIndex = 5;
            this.colGMTRF.Width = 91;
            // 
            // colGLSSKL
            // 
            this.colGLSSKL.Caption = "Şkl";
            this.colGLSSKL.FieldName = "GLSSKL";
            this.colGLSSKL.Name = "colGLSSKL";
            this.colGLSSKL.OptionsColumn.FixedWidth = true;
            this.colGLSSKL.Visible = true;
            this.colGLSSKL.VisibleIndex = 6;
            this.colGLSSKL.Width = 30;
            // 
            // colGLSTS
            // 
            this.colGLSTS.Caption = "Geliş";
            this.colGLSTS.FieldName = "GLSTS";
            this.colGLSTS.Name = "colGLSTS";
            this.colGLSTS.OptionsColumn.FixedWidth = true;
            this.colGLSTS.Visible = true;
            this.colGLSTS.VisibleIndex = 7;
            this.colGLSTS.Width = 58;
            // 
            // colKBLTS
            // 
            this.colKBLTS.Caption = "Kabul";
            this.colKBLTS.FieldName = "KBLTS";
            this.colKBLTS.Name = "colKBLTS";
            this.colKBLTS.OptionsColumn.FixedWidth = true;
            this.colKBLTS.Visible = true;
            this.colKBLTS.VisibleIndex = 8;
            this.colKBLTS.Width = 58;
            // 
            // colRPRTS
            // 
            this.colRPRTS.Caption = "Rapor";
            this.colRPRTS.FieldName = "RPRTS";
            this.colRPRTS.Name = "colRPRTS";
            this.colRPRTS.OptionsColumn.FixedWidth = true;
            this.colRPRTS.Visible = true;
            this.colRPRTS.VisibleIndex = 9;
            this.colRPRTS.Width = 58;
            // 
            // colFKN
            // 
            this.colFKN.FieldName = "FKN";
            this.colFKN.Name = "colFKN";
            this.colFKN.OptionsColumn.FixedWidth = true;
            this.colFKN.Visible = true;
            this.colFKN.VisibleIndex = 10;
            this.colFKN.Width = 40;
            // 
            // colINY
            // 
            this.colINY.Caption = "Ind%";
            this.colINY.FieldName = "INY";
            this.colINY.Name = "colINY";
            this.colINY.OptionsColumn.FixedWidth = true;
            this.colINY.Visible = true;
            this.colINY.VisibleIndex = 11;
            this.colINY.Width = 40;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Info";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 12;
            this.colINFO.Width = 115;
            // 
            // colINFO2
            // 
            this.colINFO2.Caption = "Info2";
            this.colINFO2.FieldName = "INFO2";
            this.colINFO2.Name = "colINFO2";
            this.colINFO2.Visible = true;
            this.colINFO2.VisibleIndex = 13;
            this.colINFO2.Width = 122;
            // 
            // colDGMTRH
            // 
            this.colDGMTRH.Caption = "DğmTrh";
            this.colDGMTRH.FieldName = "DGMTRH";
            this.colDGMTRH.Name = "colDGMTRH";
            this.colDGMTRH.OptionsColumn.FixedWidth = true;
            this.colDGMTRH.Visible = true;
            this.colDGMTRH.VisibleIndex = 14;
            this.colDGMTRH.Width = 58;
            // 
            // colTDTEH
            // 
            this.colTDTEH.Caption = "TDT?";
            this.colTDTEH.FieldName = "TDTEH";
            this.colTDTEH.Name = "colTDTEH";
            this.colTDTEH.OptionsColumn.FixedWidth = true;
            this.colTDTEH.ToolTip = "Tahmini Doğum Tarihi?";
            this.colTDTEH.Visible = true;
            this.colTDTEH.VisibleIndex = 15;
            this.colTDTEH.Width = 40;
            // 
            // colUSR
            // 
            this.colUSR.Caption = "Usr";
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.FixedWidth = true;
            this.colUSR.Visible = true;
            this.colUSR.VisibleIndex = 2;
            this.colUSR.Width = 40;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(91, 26);
            // 
            // gDToolStripMenuItem
            // 
            this.gDToolStripMenuItem.Name = "gDToolStripMenuItem";
            this.gDToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.gDToolStripMenuItem.Text = "GD";
            this.gDToolStripMenuItem.Click += new System.EventHandler(this.gDToolStripMenuItem_Click);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
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
            // GBxf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 336);
            this.Controls.Add(this.gbGridControl);
            this.Controls.Add(this.gBBindingNavigator);
            this.Name = "GBxf";
            this.Text = "GBxf";
            this.Load += new System.EventHandler(this.GBxf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBBindingNavigator)).EndInit();
            this.gBBindingNavigator.ResumeLayout(false);
            this.gBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gbBindingSource;
        private DataSet1TableAdapters.GBTableAdapter gbTableAdapter;
        private System.Windows.Forms.BindingNavigator gBBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private DevExpress.XtraGrid.GridControl gbGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGBRF;
        private DevExpress.XtraGrid.Columns.GridColumn colAKTEH;
        private DevExpress.XtraGrid.Columns.GridColumn colHMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colDMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGLSSKL;
        private DevExpress.XtraGrid.Columns.GridColumn colGLSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colKBLTS;
        private DevExpress.XtraGrid.Columns.GridColumn colRPRTS;
        private DevExpress.XtraGrid.Columns.GridColumn colFKN;
        private DevExpress.XtraGrid.Columns.GridColumn colINY;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO2;
        private DevExpress.XtraGrid.Columns.GridColumn colDGMTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colTDTEH;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        protected System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton revertToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gDToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}