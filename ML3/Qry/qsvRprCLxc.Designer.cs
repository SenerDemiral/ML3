namespace ML3.Qry
{
    partial class qsvRprCLxc
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dataNavigator2 = new DevExpress.XtraEditors.DataNavigator();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.qryMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.qsvGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rprCLTableAdapter = new ML3.DataSetRprTableAdapters.RprCLTableAdapter();
            this.qsRprCLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQry = new ML3.DataSetQry();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSex = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDgmTrhGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDgmTrhLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGlsTrhGE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowGlsTrhLT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowxKd = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowxNmn = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowxSwA = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowxSwB = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowxSwC = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowQRY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRowCnt = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsRprCLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQry)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dataNavigator2);
            this.layoutControl2.Controls.Add(this.simpleButton1);
            this.layoutControl2.Controls.Add(this.qryMemoEdit);
            this.layoutControl2.Controls.Add(this.qsvGridControl);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(1);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(237, 490);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dataNavigator2
            // 
            this.dataNavigator2.DataSource = this.qsRprCLBindingSource;
            this.dataNavigator2.Location = new System.Drawing.Point(5, 5);
            this.dataNavigator2.Name = "dataNavigator2";
            this.dataNavigator2.Size = new System.Drawing.Size(227, 19);
            this.dataNavigator2.StyleController = this.layoutControl2;
            this.dataNavigator2.TabIndex = 7;
            this.dataNavigator2.Text = "dataNavigator2";
            this.dataNavigator2.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 463);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(227, 22);
            this.simpleButton1.StyleController = this.layoutControl2;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // qryMemoEdit
            // 
            this.qryMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qsRprCLBindingSource, "QRY", true));
            this.qryMemoEdit.Location = new System.Drawing.Point(5, 292);
            this.qryMemoEdit.Name = "qryMemoEdit";
            this.qryMemoEdit.Size = new System.Drawing.Size(227, 167);
            this.qryMemoEdit.StyleController = this.layoutControl2;
            this.qryMemoEdit.TabIndex = 5;
            // 
            // qsvGridControl
            // 
            this.qsvGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.qsvGridControl.DataSource = this.qsRprCLBindingSource;
            this.qsvGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.qsvGridControl.Location = new System.Drawing.Point(5, 28);
            this.qsvGridControl.Name = "qsvGridControl";
            this.qsvGridControl.RecordWidth = 123;
            this.qsvGridControl.RowHeaderWidth = 77;
            this.qsvGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.rowSex,
            this.rowDgmTrhGE,
            this.rowDgmTrhLT,
            this.rowGlsTrhGE,
            this.rowGlsTrhLT,
            this.rowxKd,
            this.rowxNmn,
            this.rowxSwA,
            this.rowxSwB,
            this.rowxSwC,
            this.rowRowCnt,
            this.rowQRY});
            this.qsvGridControl.Size = new System.Drawing.Size(227, 260);
            this.qsvGridControl.TabIndex = 4;
            this.qsvGridControl.HiddenEditor += new System.EventHandler(this.qsvGridControl_HiddenEditor);
            this.qsvGridControl.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.qsvGridControl_EditorKeyDown);
            this.qsvGridControl.VisibleChanged += new System.EventHandler(this.qsvGridControl_VisibleChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(237, 490);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.qsvGridControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(231, 264);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.qryMemoEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 287);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(231, 171);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButton1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 458);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(231, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dataNavigator2;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(231, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // rprCLTableAdapter
            // 
            this.rprCLTableAdapter.ClearBeforeFill = true;
            // 
            // qsRprCLBindingSource
            // 
            this.qsRprCLBindingSource.DataMember = "qsRprCL";
            this.qsRprCLBindingSource.DataSource = this.dataSetQry;
            // 
            // dataSetQry
            // 
            this.dataSetQry.DataSetName = "DataSetQry";
            this.dataSetQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "qs Name";
            this.editorRow1.Properties.FieldName = "qsName";
            // 
            // rowSex
            // 
            this.rowSex.Name = "rowSex";
            this.rowSex.Properties.Caption = "Sex";
            this.rowSex.Properties.FieldName = "Sex";
            // 
            // rowDgmTrhGE
            // 
            this.rowDgmTrhGE.Name = "rowDgmTrhGE";
            this.rowDgmTrhGE.Properties.Caption = "DğmTrh >=";
            this.rowDgmTrhGE.Properties.FieldName = "DgmTrhGE";
            // 
            // rowDgmTrhLT
            // 
            this.rowDgmTrhLT.Name = "rowDgmTrhLT";
            this.rowDgmTrhLT.Properties.Caption = "DğmTrh <";
            this.rowDgmTrhLT.Properties.FieldName = "DgmTrhLT";
            // 
            // rowGlsTrhGE
            // 
            this.rowGlsTrhGE.Name = "rowGlsTrhGE";
            this.rowGlsTrhGE.Properties.Caption = "GlşTrh >=";
            this.rowGlsTrhGE.Properties.FieldName = "GlsTrhGE";
            // 
            // rowGlsTrhLT
            // 
            this.rowGlsTrhLT.Name = "rowGlsTrhLT";
            this.rowGlsTrhLT.Properties.Caption = "GlşTrh <";
            this.rowGlsTrhLT.Properties.FieldName = "GlsTrhLT";
            // 
            // rowxKd
            // 
            this.rowxKd.Height = 16;
            this.rowxKd.Name = "rowxKd";
            this.rowxKd.Properties.Caption = "iKd";
            this.rowxKd.Properties.FieldName = "xKd";
            // 
            // rowxNmn
            // 
            this.rowxNmn.Name = "rowxNmn";
            this.rowxNmn.Properties.Caption = "iNmn";
            this.rowxNmn.Properties.FieldName = "xNmn";
            // 
            // rowxSwA
            // 
            this.rowxSwA.Name = "rowxSwA";
            this.rowxSwA.Properties.Caption = "iSwA";
            this.rowxSwA.Properties.FieldName = "xSwA";
            // 
            // rowxSwB
            // 
            this.rowxSwB.Name = "rowxSwB";
            this.rowxSwB.Properties.Caption = "iSwB";
            this.rowxSwB.Properties.FieldName = "xSwB";
            // 
            // rowxSwC
            // 
            this.rowxSwC.Name = "rowxSwC";
            this.rowxSwC.Properties.Caption = "iSwC";
            this.rowxSwC.Properties.FieldName = "xSwC";
            // 
            // rowQRY
            // 
            this.rowQRY.Name = "rowQRY";
            this.rowQRY.Properties.Caption = "QRY";
            this.rowQRY.Properties.FieldName = "QRY";
            // 
            // rowRowCnt
            // 
            this.rowRowCnt.Name = "rowRowCnt";
            this.rowRowCnt.Properties.Caption = "#Row";
            this.rowRowCnt.Properties.FieldName = "RowCnt";
            // 
            // qsvRprCLxc
            // 
            this.Controls.Add(this.layoutControl2);
            this.Name = "qsvRprCLxc";
            this.Size = new System.Drawing.Size(237, 490);
            this.Load += new System.EventHandler(this.qsvRprCLxc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qryMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qsRprCLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DataSetQry dataSetQry;
        private System.Windows.Forms.BindingSource qsRprCLBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraVerticalGrid.VGridControl qsvGridControl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSex;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDgmTrhGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGlsTrhGE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowGlsTrhLT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowxKd;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowxNmn;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowxSwA;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowxSwB;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowxSwC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit qryMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.DataNavigator dataNavigator2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DataSetRprTableAdapters.RprCLTableAdapter rprCLTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowQRY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDgmTrhLT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRowCnt;
    }
}
