namespace ML3.Qry
{
    partial class qsvMTHxc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.qsMTHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQry = new ML3.DataSetQry();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowqsName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMtRF = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowAd = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTCKNo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmTel = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGs = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.mthTableAdapter = new ML3.DataSet1TableAdapters.MTHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsMTHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsMTHBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(6, 224);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(203, 83);
            this.qryMemoEdit.StyleController = this.layoutControl1;
            this.qryMemoEdit.TabIndex = 8;
            // 
            // qsMTHBindingSource
            // 
            this.qsMTHBindingSource.DataMember = "qsMTH";
            this.qsMTHBindingSource.DataSource = this.dataSetQry;
            // 
            // dataSetQry
            // 
            this.dataSetQry.DataSetName = "DataSetQry";
            this.dataSetQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.qsvGridControl);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.qryMemoEdit);
            this.layoutControl1.Controls.Add(this.dataNavigator1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(1);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(215, 339);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.DataSource = this.qsMTHBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(6, 29);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.RecordWidth = 118;
            this.qsvGridControl.RowHeaderWidth = 82;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowqsName,
            this.rowMtRF,
            this.rowAd,
            this.rowTCKNo,
            this.rowmTel,
            this.rowTAGs,
            this.rowQRY});
            this.qsvGridControl.Size = new System.Drawing.Size(203, 191);
            this.qsvGridControl.TabIndex = 10;
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // rowqsName
            // 
            this.rowqsName.Name = "rowqsName";
            this.rowqsName.Properties.Caption = "qs";
            this.rowqsName.Properties.FieldName = "qsName";
            // 
            // rowMtRF
            // 
            this.rowMtRF.Name = "rowMtRF";
            this.rowMtRF.Properties.Caption = "MtRF";
            this.rowMtRF.Properties.FieldName = "MtRF";
            // 
            // rowAd
            // 
            this.rowAd.Name = "rowAd";
            this.rowAd.Properties.Caption = "Ad";
            this.rowAd.Properties.FieldName = "Ad";
            // 
            // rowTCKNo
            // 
            this.rowTCKNo.Name = "rowTCKNo";
            this.rowTCKNo.Properties.Caption = "TCKNo";
            this.rowTCKNo.Properties.FieldName = "TCKNo";
            // 
            // rowmTel
            // 
            this.rowmTel.Name = "rowmTel";
            this.rowmTel.Properties.Caption = "mTel";
            this.rowmTel.Properties.FieldName = "mTel";
            // 
            // rowTAGs
            // 
            this.rowTAGs.Name = "rowTAGs";
            this.rowTAGs.Properties.Caption = "TAGs";
            this.rowTAGs.Properties.FieldName = "TAGs";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            this.rowQRY.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 311);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(203, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.DataSource = this.qsMTHBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(6, 6);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(190, 19);
            this.dataNavigator1.StyleController = this.layoutControl1;
            this.dataNavigator1.TabIndex = 6;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator1.TextStringFormat = "{0}/{1}";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(215, 339);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataNavigator1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(207, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.qryMemoEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 218);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(207, 87);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 305);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.qsvGridControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(207, 195);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // mthTableAdapter
            // 
            this.mthTableAdapter.ClearBeforeFill = true;
            // 
            // qsvMTHxc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "qsvMTHxc";
            this.Size = new System.Drawing.Size(215, 339);
            this.Load += new System.EventHandler(this.qsvMTHxc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsMTHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private System.Windows.Forms.BindingSource qsMTHBindingSource;
        private DataSetQry dataSetQry;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowqsName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMtRF;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAd;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTCKNo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmTel;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGs;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DataSet1TableAdapters.MTHTableAdapter mthTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
    }
}
