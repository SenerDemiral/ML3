namespace ML3
{
    partial class XTxf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XTxf));
            this.xTGridControl = new DevExpress.XtraGrid.GridControl();
            this.xTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new ML3.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXTRF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDX21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTTableAdapter = new ML3.DataSet1TableAdapters.XTTableAdapter();
            this.xTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xMGridControl = new DevExpress.XtraGrid.GridControl();
            this.xMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXMRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMXTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDXTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNGridControl = new DevExpress.XtraGrid.GridControl();
            this.xNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXNRF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYAS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMINK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMAXK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMINE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMAXE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.xNTableAdapter = new ML3.DataSet1TableAdapters.XNTableAdapter();
            this.xMTableAdapter = new ML3.DataSet1TableAdapters.XMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTBindingNavigator)).BeginInit();
            this.xTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // xTGridControl
            // 
            this.xTGridControl.DataSource = this.xTBindingSource;
            this.xTGridControl.Location = new System.Drawing.Point(12, 28);
            this.xTGridControl.MainView = this.gridView1;
            this.xTGridControl.Name = "xTGridControl";
            this.xTGridControl.ShowOnlyPredefinedDetails = true;
            this.xTGridControl.Size = new System.Drawing.Size(632, 418);
            this.xTGridControl.TabIndex = 2;
            this.xTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.xTGridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.xTGridControl_ProcessGridKey);
            // 
            // xTBindingSource
            // 
            this.xTBindingSource.DataMember = "XT";
            this.xTBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet1";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXTRF1,
            this.colSKL1,
            this.colKD1,
            this.colIDX1,
            this.colIDX21,
            this.colAD1,
            this.colAD21});
            this.gridView1.GridControl = this.xTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colXTRF1
            // 
            this.colXTRF1.FieldName = "XTRF";
            this.colXTRF1.Name = "colXTRF1";
            this.colXTRF1.Visible = true;
            this.colXTRF1.VisibleIndex = 0;
            // 
            // colSKL1
            // 
            this.colSKL1.FieldName = "SKL";
            this.colSKL1.Name = "colSKL1";
            this.colSKL1.Visible = true;
            this.colSKL1.VisibleIndex = 1;
            // 
            // colKD1
            // 
            this.colKD1.FieldName = "KD";
            this.colKD1.Name = "colKD1";
            this.colKD1.Visible = true;
            this.colKD1.VisibleIndex = 2;
            // 
            // colIDX1
            // 
            this.colIDX1.FieldName = "IDX";
            this.colIDX1.Name = "colIDX1";
            this.colIDX1.Visible = true;
            this.colIDX1.VisibleIndex = 3;
            // 
            // colIDX21
            // 
            this.colIDX21.FieldName = "IDX2";
            this.colIDX21.Name = "colIDX21";
            this.colIDX21.Visible = true;
            this.colIDX21.VisibleIndex = 4;
            // 
            // colAD1
            // 
            this.colAD1.FieldName = "AD";
            this.colAD1.Name = "colAD1";
            this.colAD1.Visible = true;
            this.colAD1.VisibleIndex = 5;
            // 
            // colAD21
            // 
            this.colAD21.FieldName = "AD2";
            this.colAD21.Name = "colAD21";
            this.colAD21.Visible = true;
            this.colAD21.VisibleIndex = 6;
            // 
            // xTTableAdapter
            // 
            this.xTTableAdapter.ClearBeforeFill = true;
            // 
            // xTBindingNavigator
            // 
            this.xTBindingNavigator.AddNewItem = null;
            this.xTBindingNavigator.BindingSource = this.xTBindingSource;
            this.xTBindingNavigator.CountItem = null;
            this.xTBindingNavigator.DeleteItem = null;
            this.xTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.toolStripSeparator1,
            this.addToolStripButton,
            this.toolStripSeparator2,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.deleteToolStripButton,
            this.toolStripSeparator4,
            this.refreshToolStripButton,
            this.toolStripSeparator5,
            this.revertToolStripButton});
            this.xTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xTBindingNavigator.MoveFirstItem = null;
            this.xTBindingNavigator.MoveLastItem = null;
            this.xTBindingNavigator.MoveNextItem = null;
            this.xTBindingNavigator.MovePreviousItem = null;
            this.xTBindingNavigator.Name = "xTBindingNavigator";
            this.xTBindingNavigator.PositionItem = null;
            this.xTBindingNavigator.Size = new System.Drawing.Size(1281, 25);
            this.xTBindingNavigator.TabIndex = 0;
            this.xTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(21, 22);
            this.bindingNavigatorCountItem.Text = "{0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xMGridControl);
            this.layoutControl1.Controls.Add(this.xNGridControl);
            this.layoutControl1.Controls.Add(this.xTGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(639, 420, 540, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1281, 458);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xMGridControl
            // 
            this.xMGridControl.DataSource = this.xMBindingSource;
            this.xMGridControl.Location = new System.Drawing.Point(653, 273);
            this.xMGridControl.MainView = this.gridView3;
            this.xMGridControl.Name = "xMGridControl";
            this.xMGridControl.Size = new System.Drawing.Size(616, 173);
            this.xMGridControl.TabIndex = 4;
            this.xMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // xMBindingSource
            // 
            this.xMBindingSource.DataMember = "XT_XM";
            this.xMBindingSource.DataSource = this.xTBindingSource;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXMRF,
            this.colMXTRF,
            this.colDXTRF});
            this.gridView3.GridControl = this.xMGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colXMRF
            // 
            this.colXMRF.FieldName = "XMRF";
            this.colXMRF.Name = "colXMRF";
            this.colXMRF.Visible = true;
            this.colXMRF.VisibleIndex = 0;
            // 
            // colMXTRF
            // 
            this.colMXTRF.FieldName = "MXTRF";
            this.colMXTRF.Name = "colMXTRF";
            this.colMXTRF.Visible = true;
            this.colMXTRF.VisibleIndex = 1;
            // 
            // colDXTRF
            // 
            this.colDXTRF.FieldName = "DXTRF";
            this.colDXTRF.Name = "colDXTRF";
            this.colDXTRF.Visible = true;
            this.colDXTRF.VisibleIndex = 2;
            // 
            // xNGridControl
            // 
            this.xNGridControl.DataSource = this.xNBindingSource;
            this.xNGridControl.Location = new System.Drawing.Point(653, 28);
            this.xNGridControl.MainView = this.gridView2;
            this.xNGridControl.Name = "xNGridControl";
            this.xNGridControl.Size = new System.Drawing.Size(616, 220);
            this.xNGridControl.TabIndex = 5;
            this.xNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // xNBindingSource
            // 
            this.xNBindingSource.DataMember = "XT_XN";
            this.xNBindingSource.DataSource = this.xTBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXNRF1,
            this.colXTRF,
            this.colGY1,
            this.colYAS1,
            this.colLMTMINK1,
            this.colLMTMAXK1,
            this.colLMTMINE1,
            this.colLMTMAXE1});
            this.gridView2.GridControl = this.xNGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colXNRF1
            // 
            this.colXNRF1.FieldName = "XNRF";
            this.colXNRF1.Name = "colXNRF1";
            this.colXNRF1.Visible = true;
            this.colXNRF1.VisibleIndex = 0;
            // 
            // colXTRF
            // 
            this.colXTRF.FieldName = "XTRF";
            this.colXTRF.Name = "colXTRF";
            this.colXTRF.Visible = true;
            this.colXTRF.VisibleIndex = 1;
            // 
            // colGY1
            // 
            this.colGY1.FieldName = "GY";
            this.colGY1.Name = "colGY1";
            this.colGY1.Visible = true;
            this.colGY1.VisibleIndex = 2;
            // 
            // colYAS1
            // 
            this.colYAS1.FieldName = "YAS";
            this.colYAS1.Name = "colYAS1";
            this.colYAS1.Visible = true;
            this.colYAS1.VisibleIndex = 3;
            // 
            // colLMTMINK1
            // 
            this.colLMTMINK1.FieldName = "LMTMINK";
            this.colLMTMINK1.Name = "colLMTMINK1";
            this.colLMTMINK1.Visible = true;
            this.colLMTMINK1.VisibleIndex = 4;
            // 
            // colLMTMAXK1
            // 
            this.colLMTMAXK1.FieldName = "LMTMAXK";
            this.colLMTMAXK1.Name = "colLMTMAXK1";
            this.colLMTMAXK1.Visible = true;
            this.colLMTMAXK1.VisibleIndex = 5;
            // 
            // colLMTMINE1
            // 
            this.colLMTMINE1.FieldName = "LMTMINE";
            this.colLMTMINE1.Name = "colLMTMINE1";
            this.colLMTMINE1.Visible = true;
            this.colLMTMINE1.VisibleIndex = 6;
            // 
            // colLMTMAXE1
            // 
            this.colLMTMAXE1.FieldName = "LMTMAXE";
            this.colLMTMAXE1.Name = "colLMTMAXE1";
            this.colLMTMAXE1.Visible = true;
            this.colLMTMAXE1.VisibleIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.splitterItem1,
            this.splitterItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1281, 458);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xNGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(641, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(620, 240);
            this.layoutControlItem2.Text = "Normal Değerler";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xTGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(636, 438);
            this.layoutControlItem1.Text = "İşlemler";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xMGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(641, 245);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(620, 193);
            this.layoutControlItem3.Text = "Macro";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(636, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 438);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(641, 240);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(620, 5);
            // 
            // xNTableAdapter
            // 
            this.xNTableAdapter.ClearBeforeFill = false;
            // 
            // xMTableAdapter
            // 
            this.xMTableAdapter.ClearBeforeFill = true;
            // 
            // XTxf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 483);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.xTBindingNavigator);
            this.Name = "XTxf";
            this.Text = "XTxf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XTxf_FormClosing);
            this.Load += new System.EventHandler(this.XTxf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTBindingNavigator)).EndInit();
            this.xTBindingNavigator.ResumeLayout(false);
            this.xTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet;
        private System.Windows.Forms.BindingSource xTBindingSource;
        private DataSet1TableAdapters.XTTableAdapter xTTableAdapter;
        private System.Windows.Forms.BindingNavigator xTBindingNavigator;
        private DevExpress.XtraGrid.GridControl xTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource xNBindingSource;
        private DataSet1TableAdapters.XNTableAdapter xNTableAdapter;
        private DevExpress.XtraGrid.GridControl xNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colXTRF1;
        private DevExpress.XtraGrid.Columns.GridColumn colSKL1;
        private DevExpress.XtraGrid.Columns.GridColumn colKD1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX21;
        private DevExpress.XtraGrid.Columns.GridColumn colAD1;
        private DevExpress.XtraGrid.Columns.GridColumn colAD21;
        private DevExpress.XtraGrid.Columns.GridColumn colXNRF1;
        private DevExpress.XtraGrid.Columns.GridColumn colXTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGY1;
        private DevExpress.XtraGrid.Columns.GridColumn colYAS1;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMINK1;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMAXK1;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMINE1;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMAXE1;
        private System.Windows.Forms.BindingSource xMBindingSource;
        private DataSet1TableAdapters.XMTableAdapter xMTableAdapter;
        private DevExpress.XtraGrid.GridControl xMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colXMRF;
        private DevExpress.XtraGrid.Columns.GridColumn colMXTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colDXTRF;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton revertToolStripButton;
    }
}