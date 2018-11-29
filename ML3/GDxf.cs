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
using DevExpress.XtraRichEdit;

namespace ML3
{
    public partial class GDxf : DevExpress.XtraEditors.XtraForm
    {
        public DataSet1.GBRow GBRow = null;
        public DataSet1.MTHRow MTHRow = null;

        public GDxf()
        {
            InitializeComponent();

            gdGridControl.ExternalRepository = Program.MF.persistentRepository;
            colLMTEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colXTRF.ColumnEdit = Program.MF.XTLrepositoryItemGridLookUpEdit;

            colON1TS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colON2TS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colON3TS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colPRNTS.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
            colSNCTXT.ColumnEdit = Program.MF.MemoRepositoryItemMemoExEdit;
            //colSNCTXT.ColumnEdit = Program.MF.repositoryItemRichTextEdit1;

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

            colGDRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGDRF.AppearanceCell.Options.UseBackColor = true;
            colGDRF.OptionsColumn.FixedWidth = true;
            colGDRF.OptionsColumn.ReadOnly = true;
            colGDRF.Width = 60;

            colPRRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colPRRF.AppearanceCell.Options.UseBackColor = true;
            colPRRF.OptionsColumn.FixedWidth = true;
            colPRRF.OptionsColumn.ReadOnly = true;
            colPRRF.Width = 60;

            colGBRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGBRF.AppearanceCell.Options.UseBackColor = true;
            colGBRF.OptionsColumn.FixedWidth = true;
            colGBRF.OptionsColumn.ReadOnly = true;
            colGBRF.Width = 60;

            colGRRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGRRF.AppearanceCell.Options.UseBackColor = true;
            colGRRF.OptionsColumn.FixedWidth = true;
            colGRRF.OptionsColumn.ReadOnly = true;
            colGRRF.Width = 60;

            gdTableAdapter.ClearBeforeFill = false;

        }

        private void GDxf_Load(object sender, EventArgs e)
        {
            FillDB();
        }

        private void GDxf_FormClosing(object sender, FormClosingEventArgs e)
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
            if (GBRow != null)
            {
                if (MTHRow == null)
                    MTHRow = Program.MF.GetMTHRow(GBRow.HMTRF);

                Text = $"[GD]●{MTHRow.AD}";
                toolStripLabel1.Text = $"{MTHRow.AD} ● {MTHRow.SEX} ● Dğm:{MTHRow.DGMTRH:yyyy.MM.dd} ● Glş:{GBRow.GLSTS:dd.MM.yy}";

                gdTableAdapter.Fill(dataSet1.GD, $"GBRF = {GBRow.GBRF}", Program.USR);
            }
        }

        private DialogResult UpdateDB()
        {
            if (!Validate())
                return DialogResult.Cancel;
            gdBindingSource.EndEdit();

            DialogResult dr = DialogResult.OK;

            if (dataSet1.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var. Kaydetmek istiyormusunuz?", "Update", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < dataSet1.GD.Rows.Count; i++)
                    {
                        // States: Added, Modified, Deletede, Unchanged
                        if (dataSet1.GD.Rows[i].RowState == DataRowState.Added || dataSet1.GD.Rows[i].RowState == DataRowState.Modified)
                        {
                            gdTableAdapter.Update(dataSet1.GD.Rows[i]);
                            gdTableAdapter.Fill(dataSet1.GD, $"GDRF = {dataSet1.GD.Rows[i]["GDRF", DataRowVersion.Original]}", Program.USR);
                        }
                    }
                }
            }
            return dr;
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(colGDRF, Program.MF.GET_PK("G"));
        }



    }
}