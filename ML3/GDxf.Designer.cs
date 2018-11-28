namespace ML3
{
    partial class GDxf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDxf));
            this.dataSet1 = new ML3.DataSet1();
            this.gdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdTableAdapter = new ML3.DataSet1TableAdapters.GDTableAdapter();
            this.gdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gdGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGDRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGBRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTRF = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPopup = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingNavigator)).BeginInit();
            this.gdBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gdBindingSource
            // 
            this.gdBindingSource.DataMember = "GD";
            this.gdBindingSource.DataSource = this.dataSet1;
            // 
            // gdTableAdapter
            // 
            this.gdTableAdapter.ClearBeforeFill = true;
            // 
            // gdBindingNavigator
            // 
            this.gdBindingNavigator.AddNewItem = null;
            this.gdBindingNavigator.BindingSource = this.gdBindingSource;
            this.gdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gdBindingNavigator.CountItemFormat = "{0}";
            this.gdBindingNavigator.DeleteItem = null;
            this.gdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripLabel1});
            this.gdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gdBindingNavigator.MoveFirstItem = null;
            this.gdBindingNavigator.MoveLastItem = null;
            this.gdBindingNavigator.MoveNextItem = null;
            this.gdBindingNavigator.MovePreviousItem = null;
            this.gdBindingNavigator.Name = "gdBindingNavigator";
            this.gdBindingNavigator.PositionItem = null;
            this.gdBindingNavigator.Size = new System.Drawing.Size(1296, 25);
            this.gdBindingNavigator.TabIndex = 0;
            this.gdBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // gdGridControl
            // 
            this.gdGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdGridControl.DataSource = this.gdBindingSource;
            this.gdGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdGridControl.Location = new System.Drawing.Point(0, 25);
            this.gdGridControl.MainView = this.gridView1;
            this.gdGridControl.Name = "gdGridControl";
            this.gdGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riPopup,
            this.repositoryItemRichTextEdit1});
            this.gdGridControl.Size = new System.Drawing.Size(1296, 276);
            this.gdGridControl.TabIndex = 2;
            this.gdGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGDRF,
            this.colPRRF,
            this.colGRRF,
            this.colGBRF,
            this.colXTRF,
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
            this.colFYT,
            this.colTBFYT,
            this.colKDY});
            this.gridView1.GridControl = this.gdGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            // 
            // colGDRF
            // 
            this.colGDRF.FieldName = "GDRF";
            this.colGDRF.Name = "colGDRF";
            this.colGDRF.Visible = true;
            this.colGDRF.VisibleIndex = 0;
            // 
            // colPRRF
            // 
            this.colPRRF.FieldName = "PRRF";
            this.colPRRF.Name = "colPRRF";
            this.colPRRF.Visible = true;
            this.colPRRF.VisibleIndex = 1;
            // 
            // colGRRF
            // 
            this.colGRRF.FieldName = "GRRF";
            this.colGRRF.Name = "colGRRF";
            this.colGRRF.Visible = true;
            this.colGRRF.VisibleIndex = 2;
            // 
            // colGBRF
            // 
            this.colGBRF.FieldName = "GBRF";
            this.colGBRF.Name = "colGBRF";
            this.colGBRF.Visible = true;
            this.colGBRF.VisibleIndex = 3;
            // 
            // colXTRF
            // 
            this.colXTRF.FieldName = "XTRF";
            this.colXTRF.Name = "colXTRF";
            this.colXTRF.Visible = true;
            this.colXTRF.VisibleIndex = 4;
            // 
            // colKAPRF
            // 
            this.colKAPRF.FieldName = "KAPRF";
            this.colKAPRF.Name = "colKAPRF";
            this.colKAPRF.Visible = true;
            this.colKAPRF.VisibleIndex = 5;
            // 
            // colSNC
            // 
            this.colSNC.FieldName = "SNC";
            this.colSNC.Name = "colSNC";
            this.colSNC.Visible = true;
            this.colSNC.VisibleIndex = 6;
            // 
            // colSNCTXT
            // 
            this.colSNCTXT.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.colSNCTXT.FieldName = "SNCTXT";
            this.colSNCTXT.Name = "colSNCTXT";
            this.colSNCTXT.Visible = true;
            this.colSNCTXT.VisibleIndex = 7;
            // 
            // colSNCONC
            // 
            this.colSNCONC.FieldName = "SNCONC";
            this.colSNCONC.Name = "colSNCONC";
            this.colSNCONC.Visible = true;
            this.colSNCONC.VisibleIndex = 8;
            // 
            // colLMTMIN
            // 
            this.colLMTMIN.FieldName = "LMTMIN";
            this.colLMTMIN.Name = "colLMTMIN";
            this.colLMTMIN.Visible = true;
            this.colLMTMIN.VisibleIndex = 9;
            // 
            // colLMTMAX
            // 
            this.colLMTMAX.FieldName = "LMTMAX";
            this.colLMTMAX.Name = "colLMTMAX";
            this.colLMTMAX.Visible = true;
            this.colLMTMAX.VisibleIndex = 10;
            // 
            // colLMTEH
            // 
            this.colLMTEH.FieldName = "LMTEH";
            this.colLMTEH.Name = "colLMTEH";
            this.colLMTEH.Visible = true;
            this.colLMTEH.VisibleIndex = 11;
            // 
            // colON1
            // 
            this.colON1.FieldName = "ON1";
            this.colON1.Name = "colON1";
            this.colON1.Visible = true;
            this.colON1.VisibleIndex = 12;
            // 
            // colON2
            // 
            this.colON2.FieldName = "ON2";
            this.colON2.Name = "colON2";
            this.colON2.Visible = true;
            this.colON2.VisibleIndex = 13;
            // 
            // colON3
            // 
            this.colON3.FieldName = "ON3";
            this.colON3.Name = "colON3";
            this.colON3.Visible = true;
            this.colON3.VisibleIndex = 14;
            // 
            // colINFO
            // 
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 15;
            // 
            // colON1TS
            // 
            this.colON1TS.FieldName = "ON1TS";
            this.colON1TS.Name = "colON1TS";
            this.colON1TS.Visible = true;
            this.colON1TS.VisibleIndex = 16;
            // 
            // colON2TS
            // 
            this.colON2TS.FieldName = "ON2TS";
            this.colON2TS.Name = "colON2TS";
            this.colON2TS.Visible = true;
            this.colON2TS.VisibleIndex = 17;
            // 
            // colON3TS
            // 
            this.colON3TS.FieldName = "ON3TS";
            this.colON3TS.Name = "colON3TS";
            this.colON3TS.Visible = true;
            this.colON3TS.VisibleIndex = 18;
            // 
            // colPRNTS
            // 
            this.colPRNTS.FieldName = "PRNTS";
            this.colPRNTS.Name = "colPRNTS";
            this.colPRNTS.Visible = true;
            this.colPRNTS.VisibleIndex = 19;
            // 
            // colFYT
            // 
            this.colFYT.FieldName = "FYT";
            this.colFYT.Name = "colFYT";
            this.colFYT.Visible = true;
            this.colFYT.VisibleIndex = 20;
            // 
            // colTBFYT
            // 
            this.colTBFYT.FieldName = "TBFYT";
            this.colTBFYT.Name = "colTBFYT";
            this.colTBFYT.Visible = true;
            this.colTBFYT.VisibleIndex = 21;
            // 
            // colKDY
            // 
            this.colKDY.FieldName = "KDY";
            this.colKDY.Name = "colKDY";
            this.colKDY.Visible = true;
            this.colKDY.VisibleIndex = 22;
            // 
            // riPopup
            // 
            this.riPopup.AutoHeight = false;
            this.riPopup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riPopup.Name = "riPopup";
            this.riPopup.PopupControl = this.popupContainerControl1;
            this.riPopup.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.riPopup_QueryResultValue);
            this.riPopup.QueryDisplayText += new DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(this.riPopup_QueryDisplayText);
            this.riPopup.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.riPopup_QueryPopUp);
            this.riPopup.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.riPopup_CloseUp);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.richEditControl1);
            this.popupContainerControl1.Location = new System.Drawing.Point(392, 12);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(262, 196);
            this.popupContainerControl1.TabIndex = 3;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(262, 196);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Rtf;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // GDxf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 301);
            this.Controls.Add(this.popupContainerControl1);
            this.Controls.Add(this.gdGridControl);
            this.Controls.Add(this.gdBindingNavigator);
            this.Name = "GDxf";
            this.Text = "GDxf";
            this.Load += new System.EventHandler(this.GDxf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdBindingNavigator)).EndInit();
            this.gdBindingNavigator.ResumeLayout(false);
            this.gdBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gdBindingSource;
        private DataSet1TableAdapters.GDTableAdapter gdTableAdapter;
        private System.Windows.Forms.BindingNavigator gdBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private DevExpress.XtraGrid.GridControl gdGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRF;
        private DevExpress.XtraGrid.Columns.GridColumn colPRRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGRRF;
        private DevExpress.XtraGrid.Columns.GridColumn colGBRF;
        private DevExpress.XtraGrid.Columns.GridColumn colXTRF;
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
        private DevExpress.XtraGrid.Columns.GridColumn colFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colTBFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colKDY;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton revertToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit riPopup;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
    }
}