using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ML3
{
    public partial class GBxf : DevExpress.XtraEditors.XtraForm
    {
        public DataSet1.MTHRow MTHRow = null;
        public DataSet1.MTDRow MTDRow = null;
        public DataSet1.MTGRow MTGRow = null;

        public GBxf()
        {
            InitializeComponent();

            gbGridControl.ExternalRepository = Program.MF.persistentRepository;
            colAKTEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colTDTEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colDMTRF.ColumnEdit = Program.MF.MTDLrepositoryItemGridLookUpEdit;
            colGMTRF.ColumnEdit = Program.MF.MTGLrepositoryItemGridLookUpEdit;

            colGLSTS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colKBLTS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colRPRTS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colDGMTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

            colGBRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGBRF.AppearanceCell.Options.UseBackColor = true;
            colGBRF.OptionsColumn.FixedWidth = true;
            colGBRF.OptionsColumn.ReadOnly = true;
            colGBRF.Width = 60;

            gbTableAdapter.ClearBeforeFill = false;
        }

        private void gBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            gbBindingSource.EndEdit();
            gbTableAdapter.Update(dataSet1.GB);

        }

        private void GBxf_Load(object sender, EventArgs e)
        {
            FillDB();
        }

        private void GBxf_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (readOnly)
            //    return;

            DialogResult dr = UpdateDB();
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
            else
                DialogResult = DialogResult.Yes;
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = UpdateDB();
            if (dr != DialogResult.Cancel)
                FillDB();
        }

        private void revertToolStripButton_Click(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            dataSet1.GB.Rows[gridView1.GetFocusedDataSourceRowIndex()].RejectChanges();
        }

        private void FillDB()
        {
            if (MTHRow != null)
            {
                Text = $"[GB]●{MTHRow.AD}";
                toolStripLabel1.Text = $"{MTHRow.AD} ● {MTHRow.SEX} ● {MTHRow.DGMTRH:yyyy.MM.dd}";

                colHMTRF.Visible = false;

                gbTableAdapter.Fill(dataSet1.GB, $"HMTRF = {MTHRow.MTRF}", Program.USR);
            }
            if (MTDRow != null)
            {
                Text = $"[GB]●{MTDRow.AD}";

                toolStripLabel1.Text = "";

                colHMTRF.Visible = false;

                gbTableAdapter.Fill(dataSet1.GB, $"DMTRF = {MTDRow.MTRF}", Program.USR);
            }
        }

        private DialogResult UpdateDB()
        {
            if (!Validate())
                return DialogResult.Cancel;
            gbBindingSource.EndEdit();

            DialogResult dr = DialogResult.OK;

            if (dataSet1.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var. Kaydetmek istiyormusunuz?", "Update", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < dataSet1.GB.Rows.Count; i++)
                    {
                        // States: Added, Modified, Deletede, Unchanged
                        if (dataSet1.GB.Rows[i].RowState == DataRowState.Added || dataSet1.GB.Rows[i].RowState == DataRowState.Modified)
                        {
                            gbTableAdapter.Update(dataSet1.GB.Rows[i]);
                            gbTableAdapter.Fill(dataSet1.GB, $"GBRF = {dataSet1.GB.Rows[i]["GBRF", DataRowVersion.Original]}", Program.USR);
                        }
                    }
                }
            }
            return dr;
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(colGBRF, Program.MF.GET_PK("G"));
        }

        private void gDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frm = gridView1.GetFocusedRowCellValue(colGBRF).ToString();
            if (!Program.MF.frms.ContainsKey(frm))
                Program.MF.frms[frm] = null;

            var doc = Program.MF.documentManager.GetDocument(Program.MF.frms[frm]);
            if (doc != null)
                Program.MF.tabbedView1.Controller.Activate(doc);
            else
            {
                Program.MF.frms[frm] = new GDxf
                {
                    //MdiParent = Program.MF,
                    GBRow = (DataSet1.GBRow)gridView1.GetFocusedDataRow(),
                    MTHRow = this.MTHRow
                };
                Program.MF.frms[frm].ShowDialog();
            }

        }
    }
}