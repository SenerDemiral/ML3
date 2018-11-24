namespace ML3
{
    partial class MainXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainXF));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TanimToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.mtdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MTHtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.queriesTableAdapter = new ML3.DataSet1TableAdapters.QueriesTableAdapter();
            this.persistentRepository = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.SexRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.EHrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.TelRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TCKNoRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexRepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EHrepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCKNoRepositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanimToolStripDropDownButton,
            this.MTHtoolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TanimToolStripDropDownButton
            // 
            this.TanimToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TanimToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtdToolStripMenuItem,
            this.mtgToolStripMenuItem});
            this.TanimToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("TanimToolStripDropDownButton.Image")));
            this.TanimToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TanimToolStripDropDownButton.Name = "TanimToolStripDropDownButton";
            this.TanimToolStripDropDownButton.Size = new System.Drawing.Size(66, 22);
            this.TanimToolStripDropDownButton.Text = "Tanımlar";
            // 
            // mtdToolStripMenuItem
            // 
            this.mtdToolStripMenuItem.Name = "mtdToolStripMenuItem";
            this.mtdToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mtdToolStripMenuItem.Tag = "MTD";
            this.mtdToolStripMenuItem.Text = "Doktor";
            this.mtdToolStripMenuItem.Click += new System.EventHandler(this.mtdToolStripMenuItem_Click);
            // 
            // mtgToolStripMenuItem
            // 
            this.mtgToolStripMenuItem.Name = "mtgToolStripMenuItem";
            this.mtgToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mtgToolStripMenuItem.Text = "Sigorta, Lab, Kurum";
            this.mtgToolStripMenuItem.Click += new System.EventHandler(this.mtgToolStripMenuItem_Click);
            // 
            // MTHtoolStripButton
            // 
            this.MTHtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MTHtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("MTHtoolStripButton.Image")));
            this.MTHtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MTHtoolStripButton.Name = "MTHtoolStripButton";
            this.MTHtoolStripButton.Size = new System.Drawing.Size(42, 22);
            this.MTHtoolStripButton.Text = "Kişiler";
            this.MTHtoolStripButton.Click += new System.EventHandler(this.MTHtoolStripButton_Click);
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Red;
            this.tabbedView1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tabbedView1.RootContainer.Element = null;
            // 
            // dockManager
            // 
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
            // persistentRepository
            // 
            this.persistentRepository.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SexRepositoryItemImageComboBox,
            this.EHrepositoryItemCheckEdit,
            this.TelRepositoryItemTextEdit,
            this.TCKNoRepositoryItemTextEdit});
            // 
            // SexRepositoryItemImageComboBox
            // 
            this.SexRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SexRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("E", "E", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("K", "-", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("X", "X", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("-", "-", -1)});
            this.SexRepositoryItemImageComboBox.Name = "SexRepositoryItemImageComboBox";
            // 
            // EHrepositoryItemCheckEdit
            // 
            this.EHrepositoryItemCheckEdit.DisplayValueChecked = "Evet";
            this.EHrepositoryItemCheckEdit.DisplayValueUnchecked = "Hayır";
            this.EHrepositoryItemCheckEdit.Name = "EHrepositoryItemCheckEdit";
            this.EHrepositoryItemCheckEdit.ValueChecked = "E";
            this.EHrepositoryItemCheckEdit.ValueUnchecked = "H";
            // 
            // TelRepositoryItemTextEdit
            // 
            this.TelRepositoryItemTextEdit.Mask.EditMask = "\\d\\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d";
            this.TelRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TelRepositoryItemTextEdit.Mask.UseMaskAsDisplayFormat = true;
            this.TelRepositoryItemTextEdit.Name = "TelRepositoryItemTextEdit";
            // 
            // TCKNoRepositoryItemTextEdit
            // 
            this.TCKNoRepositoryItemTextEdit.Mask.EditMask = "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.TCKNoRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TCKNoRepositoryItemTextEdit.Name = "TCKNoRepositoryItemTextEdit";
            // 
            // MainXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "MainXF";
            this.Text = "MainXF";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexRepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EHrepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCKNoRepositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.ToolStripDropDownButton TanimToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem mtdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtgToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.ToolStripButton MTHtoolStripButton;
        public DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository;
        public DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox SexRepositoryItemImageComboBox;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit EHrepositoryItemCheckEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TelRepositoryItemTextEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TCKNoRepositoryItemTextEdit;
    }
}