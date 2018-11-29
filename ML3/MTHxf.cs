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
    public partial class MTHxf : DevExpress.XtraEditors.XtraForm
    {
        Qry.qsvMTHxc qsFrm = new Qry.qsvMTHxc();

        public MTHxf()
        {
            InitializeComponent();

            mthGridControl.ExternalRepository = Program.MF.persistentRepository;
            colSEX.ColumnEdit = Program.MF.SexRepositoryItemImageComboBox;
            colTDTEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colMTEL.ColumnEdit = Program.MF.TelRepositoryItemTextEdit;
            colTCKNO.ColumnEdit = Program.MF.TCKNoRepositoryItemTextEdit;
            colDGMTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;

            colMTRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colMTRF.AppearanceCell.Options.UseBackColor = true;
            colMTRF.OptionsColumn.FixedWidth = true;
            colMTRF.OptionsColumn.ReadOnly = true;
            colMTRF.Width = 60;

            mthTableAdapter.ClearBeforeFill = false;
        }

        private void MTHxf_Load(object sender, EventArgs e)
        {
            qsFrm.FDT = dataSet.MTH;
            qsFrm.Dock = DockStyle.Fill;

            qsDockPanel.Controls.Add(qsFrm);

            //toolStripLabel1.Text = "Şener DEMİRAL, 1960, GlşTrh: 23.11.18";
            //Text = "Şener DEMİRAL, 1960, GlşTrh: 23.11.18";

        }

        private void MTHxf_FormClosing(object sender, FormClosingEventArgs e)
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
            dataSet.MTH.Rows[gridView1.GetFocusedDataSourceRowIndex()].RejectChanges();
        }

        private void FillDB()
        {
            if (!string.IsNullOrEmpty(qsFrm.searchQry))
            {
                mthTableAdapter.ClearBeforeFill = true;
                mthTableAdapter.Fill(dataSet.MTH, qsFrm.searchQry, Program.USR);
                mthTableAdapter.ClearBeforeFill = false;
            }
        }

        private DialogResult UpdateDB()
        {
            if (!Validate())
                return DialogResult.Cancel;
            mthBindingSource.EndEdit();

            DialogResult dr = DialogResult.OK;

            if (dataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var. Kaydetmek istiyormusunuz?", "Update", MessageBoxButtons.YesNoCancel);
                
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < dataSet.MTH.Rows.Count; i++)
                    {
                        // States: Added, Modified, Deletede, Unchanged
                        if (dataSet.MTH.Rows[i].RowState == DataRowState.Added || dataSet.MTH.Rows[i].RowState == DataRowState.Modified)
                        {
                            mthTableAdapter.Update(dataSet.MTH.Rows[i]);
                            mthTableAdapter.Fill(dataSet.MTH, $"MTRF = {dataSet.MTH.Rows[i]["MTRF", DataRowVersion.Original]}", Program.USR);
                        }
                    }
                }
            }
            return dr;
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(colMTRF, Program.MF.GET_PK("M"));
        }

        private void gbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GBxf frm = new GBxf();
            //frm.MdiParent = Program.MF;
            //frm.MTHRow = (DataSet1.MTHRow)gridView1.GetFocusedDataRow();
            //frm.Show();

            string frm = gridView1.GetFocusedRowCellValue(colMTRF).ToString();
            if (!Program.MF.frms.ContainsKey(frm))
                Program.MF.frms[frm] = null;

            var doc = Program.MF.documentManager.GetDocument(Program.MF.frms[frm]);
            if (doc != null)
                Program.MF.tabbedView1.Controller.Activate(doc);
            else
            {
                Program.MF.frms[frm] = new GBxf
                {
                    MdiParent = Program.MF,
                    MTHRow = (DataSet1.MTHRow)gridView1.GetFocusedDataRow()
                };
                Program.MF.frms[frm].Show();
            }

        }

    }
}