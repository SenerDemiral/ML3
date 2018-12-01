namespace ML3
{
    partial class RprCLxf
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
            this.dataSetRpr = new ML3.DataSetRpr();
            this.rprCLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rprCLTableAdapter = new ML3.DataSetRprTableAdapters.RprCLTableAdapter();
            this.rprCLGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGBRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKBLTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPRTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHMTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHASTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXKD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXIDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSWA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSWB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSWC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXNMN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKAPRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNCTXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNCONC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTMAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLMTEH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON1TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON2TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colON3TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRNTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNCHTML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprCLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprCLGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.qsDockPanel.SuspendLayout();
            this.hideContainerLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetRpr
            // 
            this.dataSetRpr.DataSetName = "DataSetRpr";
            this.dataSetRpr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rprCLBindingSource
            // 
            this.rprCLBindingSource.DataMember = "RprCL";
            this.rprCLBindingSource.DataSource = this.dataSetRpr;
            // 
            // rprCLTableAdapter
            // 
            this.rprCLTableAdapter.ClearBeforeFill = true;
            // 
            // rprCLGridControl
            // 
            this.rprCLGridControl.DataSource = this.rprCLBindingSource;
            this.rprCLGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rprCLGridControl.Location = new System.Drawing.Point(19, 0);
            this.rprCLGridControl.MainView = this.gridView1;
            this.rprCLGridControl.Name = "rprCLGridControl";
            this.rprCLGridControl.Size = new System.Drawing.Size(1056, 310);
            this.rprCLGridControl.TabIndex = 2;
            this.rprCLGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGBRF,
            this.colGLSTS,
            this.colKBLTS,
            this.colRPRTS,
            this.colDMTRF,
            this.colGMTRF,
            this.colHMTRF,
            this.colHASTA,
            this.colXTRF,
            this.colXAD,
            this.colXKD,
            this.colXIDX,
            this.colXSWA,
            this.colXSWB,
            this.colXSWC,
            this.colXNMN,
            this.colGDRF,
            this.colPRRF,
            this.colGRRF,
            this.colKAPRF,
            this.colSNC,
            this.colSNCTXT,
            this.colSNCONC,
            this.colLMTMIN,
            this.colLMTMAX,
            this.colLMTEH,
            this.colON1,
            this.colON2,
            this.colON3,
            this.colINFO,
            this.colON1TS,
            this.colON2TS,
            this.colON3TS,
            this.colPRNTS,
            this.colSNCHTML});
            this.gridView1.GridControl = this.rprCLGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colGBRF
            // 
            this.colGBRF.FieldName = "GBRF";
            this.colGBRF.Name = "colGBRF";
            this.colGBRF.Visible = true;
            this.colGBRF.VisibleIndex = 0;
            // 
            // colGLSTS
            // 
            this.colGLSTS.FieldName = "GLSTS";
            this.colGLSTS.Name = "colGLSTS";
            this.colGLSTS.Visible = true;
            this.colGLSTS.VisibleIndex = 1;
            // 
            // colKBLTS
            // 
            this.colKBLTS.FieldName = "KBLTS";
            this.colKBLTS.Name = "colKBLTS";
            this.colKBLTS.Visible = true;
            this.colKBLTS.VisibleIndex = 2;
            // 
            // colRPRTS
            // 
            this.colRPRTS.FieldName = "RPRTS";
            this.colRPRTS.Name = "colRPRTS";
            this.colRPRTS.Visible = true;
            this.colRPRTS.VisibleIndex = 3;
            // 
            // colDMTRF
            // 
            this.colDMTRF.FieldName = "DMTRF";
            this.colDMTRF.Name = "colDMTRF";
            this.colDMTRF.Visible = true;
            this.colDMTRF.VisibleIndex = 4;
            // 
            // colGMTRF
            // 
            this.colGMTRF.FieldName = "GMTRF";
            this.colGMTRF.Name = "colGMTRF";
            this.colGMTRF.Visible = true;
            this.colGMTRF.VisibleIndex = 5;
            // 
            // colHMTRF
            // 
            this.colHMTRF.FieldName = "HMTRF";
            this.colHMTRF.Name = "colHMTRF";
            this.colHMTRF.Visible = true;
            this.colHMTRF.VisibleIndex = 6;
            // 
            // colHASTA
            // 
            this.colHASTA.FieldName = "HASTA";
            this.colHASTA.Name = "colHASTA";
            this.colHASTA.Visible = true;
            this.colHASTA.VisibleIndex = 7;
            // 
            // colXTRF
            // 
            this.colXTRF.FieldName = "XTRF";
            this.colXTRF.Name = "colXTRF";
            this.colXTRF.Visible = true;
            this.colXTRF.VisibleIndex = 8;
            // 
            // colXAD
            // 
            this.colXAD.FieldName = "XAD";
            this.colXAD.Name = "colXAD";
            this.colXAD.Visible = true;
            this.colXAD.VisibleIndex = 9;
            // 
            // colXKD
            // 
            this.colXKD.FieldName = "XKD";
            this.colXKD.Name = "colXKD";
            this.colXKD.Visible = true;
            this.colXKD.VisibleIndex = 10;
            // 
            // colXIDX
            // 
            this.colXIDX.FieldName = "XIDX";
            this.colXIDX.Name = "colXIDX";
            this.colXIDX.Visible = true;
            this.colXIDX.VisibleIndex = 11;
            // 
            // colXSWA
            // 
            this.colXSWA.FieldName = "XSWA";
            this.colXSWA.Name = "colXSWA";
            this.colXSWA.Visible = true;
            this.colXSWA.VisibleIndex = 12;
            // 
            // colXSWB
            // 
            this.colXSWB.FieldName = "XSWB";
            this.colXSWB.Name = "colXSWB";
            this.colXSWB.Visible = true;
            this.colXSWB.VisibleIndex = 13;
            // 
            // colXSWC
            // 
            this.colXSWC.FieldName = "XSWC";
            this.colXSWC.Name = "colXSWC";
            this.colXSWC.Visible = true;
            this.colXSWC.VisibleIndex = 14;
            // 
            // colXNMN
            // 
            this.colXNMN.FieldName = "XNMN";
            this.colXNMN.Name = "colXNMN";
            this.colXNMN.Visible = true;
            this.colXNMN.VisibleIndex = 15;
            // 
            // colGDRF
            // 
            this.colGDRF.FieldName = "GDRF";
            this.colGDRF.Name = "colGDRF";
            this.colGDRF.Visible = true;
            this.colGDRF.VisibleIndex = 16;
            // 
            // colPRRF
            // 
            this.colPRRF.FieldName = "PRRF";
            this.colPRRF.Name = "colPRRF";
            this.colPRRF.Visible = true;
            this.colPRRF.VisibleIndex = 17;
            // 
            // colGRRF
            // 
            this.colGRRF.FieldName = "GRRF";
            this.colGRRF.Name = "colGRRF";
            this.colGRRF.Visible = true;
            this.colGRRF.VisibleIndex = 18;
            // 
            // colKAPRF
            // 
            this.colKAPRF.FieldName = "KAPRF";
            this.colKAPRF.Name = "colKAPRF";
            this.colKAPRF.Visible = true;
            this.colKAPRF.VisibleIndex = 19;
            // 
            // colSNC
            // 
            this.colSNC.FieldName = "SNC";
            this.colSNC.Name = "colSNC";
            this.colSNC.Visible = true;
            this.colSNC.VisibleIndex = 20;
            // 
            // colSNCTXT
            // 
            this.colSNCTXT.FieldName = "SNCTXT";
            this.colSNCTXT.Name = "colSNCTXT";
            this.colSNCTXT.Visible = true;
            this.colSNCTXT.VisibleIndex = 21;
            // 
            // colSNCONC
            // 
            this.colSNCONC.FieldName = "SNCONC";
            this.colSNCONC.Name = "colSNCONC";
            this.colSNCONC.Visible = true;
            this.colSNCONC.VisibleIndex = 22;
            // 
            // colLMTMIN
            // 
            this.colLMTMIN.FieldName = "LMTMIN";
            this.colLMTMIN.Name = "colLMTMIN";
            this.colLMTMIN.Visible = true;
            this.colLMTMIN.VisibleIndex = 23;
            // 
            // colLMTMAX
            // 
            this.colLMTMAX.FieldName = "LMTMAX";
            this.colLMTMAX.Name = "colLMTMAX";
            this.colLMTMAX.Visible = true;
            this.colLMTMAX.VisibleIndex = 24;
            // 
            // colLMTEH
            // 
            this.colLMTEH.FieldName = "LMTEH";
            this.colLMTEH.Name = "colLMTEH";
            this.colLMTEH.Visible = true;
            this.colLMTEH.VisibleIndex = 25;
            // 
            // colON1
            // 
            this.colON1.FieldName = "ON1";
            this.colON1.Name = "colON1";
            this.colON1.Visible = true;
            this.colON1.VisibleIndex = 26;
            // 
            // colON2
            // 
            this.colON2.FieldName = "ON2";
            this.colON2.Name = "colON2";
            this.colON2.Visible = true;
            this.colON2.VisibleIndex = 27;
            // 
            // colON3
            // 
            this.colON3.FieldName = "ON3";
            this.colON3.Name = "colON3";
            this.colON3.Visible = true;
            this.colON3.VisibleIndex = 28;
            // 
            // colINFO
            // 
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 29;
            // 
            // colON1TS
            // 
            this.colON1TS.FieldName = "ON1TS";
            this.colON1TS.Name = "colON1TS";
            this.colON1TS.Visible = true;
            this.colON1TS.VisibleIndex = 30;
            // 
            // colON2TS
            // 
            this.colON2TS.FieldName = "ON2TS";
            this.colON2TS.Name = "colON2TS";
            this.colON2TS.Visible = true;
            this.colON2TS.VisibleIndex = 31;
            // 
            // colON3TS
            // 
            this.colON3TS.FieldName = "ON3TS";
            this.colON3TS.Name = "colON3TS";
            this.colON3TS.Visible = true;
            this.colON3TS.VisibleIndex = 32;
            // 
            // colPRNTS
            // 
            this.colPRNTS.FieldName = "PRNTS";
            this.colPRNTS.Name = "colPRNTS";
            this.colPRNTS.Visible = true;
            this.colPRNTS.VisibleIndex = 33;
            // 
            // colSNCHTML
            // 
            this.colSNCHTML.FieldName = "SNCHTML";
            this.colSNCHTML.Name = "colSNCHTML";
            this.colSNCHTML.Visible = true;
            this.colSNCHTML.VisibleIndex = 34;
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
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
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("d0ad7f01-cf27-495a-a98b-300fa61fc9c2");
            this.qsDockPanel.Location = new System.Drawing.Point(0, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.Options.ShowCloseButton = false;
            this.qsDockPanel.Options.ShowMaximizeButton = false;
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(200, 310);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 283);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.qsDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 310);
            // 
            // RprCLxf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 310);
            this.Controls.Add(this.rprCLGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "RprCLxf";
            this.Text = "RprCLxf";
            this.Load += new System.EventHandler(this.RprCLxf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprCLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprCLGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.qsDockPanel.ResumeLayout(false);
            this.hideContainerLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetRpr dataSetRpr;
        private System.Windows.Forms.BindingSource rprCLBindingSource;
        private DataSetRprTableAdapters.RprCLTableAdapter rprCLTableAdapter;
        private DevExpress.XtraGrid.GridControl rprCLGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGBRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGLSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colKBLTS;
        private DevExpress.XtraGrid.Columns.GridColumn colRPRTS;
        private DevExpress.XtraGrid.Columns.GridColumn colDMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colHMTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colHASTA;
        private DevExpress.XtraGrid.Columns.GridColumn colXTRF;
        private DevExpress.XtraGrid.Columns.GridColumn colXAD;
        private DevExpress.XtraGrid.Columns.GridColumn colXKD;
        private DevExpress.XtraGrid.Columns.GridColumn colXIDX;
        private DevExpress.XtraGrid.Columns.GridColumn colXSWA;
        private DevExpress.XtraGrid.Columns.GridColumn colXSWB;
        private DevExpress.XtraGrid.Columns.GridColumn colXSWC;
        private DevExpress.XtraGrid.Columns.GridColumn colXNMN;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRF;
        private DevExpress.XtraGrid.Columns.GridColumn colPRRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGRRF;
        private DevExpress.XtraGrid.Columns.GridColumn colKAPRF;
        private DevExpress.XtraGrid.Columns.GridColumn colSNC;
        private DevExpress.XtraGrid.Columns.GridColumn colSNCTXT;
        private DevExpress.XtraGrid.Columns.GridColumn colSNCONC;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMIN;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTMAX;
        private DevExpress.XtraGrid.Columns.GridColumn colLMTEH;
        private DevExpress.XtraGrid.Columns.GridColumn colON1;
        private DevExpress.XtraGrid.Columns.GridColumn colON2;
        private DevExpress.XtraGrid.Columns.GridColumn colON3;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colON1TS;
        private DevExpress.XtraGrid.Columns.GridColumn colON2TS;
        private DevExpress.XtraGrid.Columns.GridColumn colON3TS;
        private DevExpress.XtraGrid.Columns.GridColumn colPRNTS;
        private DevExpress.XtraGrid.Columns.GridColumn colSNCHTML;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
    }
}