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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ML3
{
    public partial class XTxf : DevExpress.XtraEditors.XtraForm
    {

        public XTxf()
        {
            InitializeComponent();
        }

        private void XTxf_Load(object sender, EventArgs e)
        {
            FillDB();
        }

        #region ToolStrip

        private void XTxf_FormClosing(object sender, FormClosingEventArgs e)
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
            dataSet.XT.Rows[gridView1.GetFocusedDataSourceRowIndex()].RejectChanges();
        }

        private void FillDB()
        {
            try
            {
                xTTableAdapter.ClearBeforeFill = true;
                xTTableAdapter.Fill(dataSet.XT, "XTRF > 0", "");
                xNTableAdapter.Fill(dataSet.XN, 0);
                xMTableAdapter.Fill(dataSet.XM, 0);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private DialogResult UpdateDB()
        {
            if (!Validate())
                return DialogResult.Cancel;
            xTBindingSource.EndEdit();

            DialogResult dr = DialogResult.OK;

            if (dataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var. Kaydetmek istiyormusunuz?", "Update", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < dataSet.XT.Rows.Count; i++)
                    {
                        // States: Added, Modified, Deletede, Unchanged
                        if (dataSet.XT.Rows[i].RowState == DataRowState.Added || dataSet.XT.Rows[i].RowState == DataRowState.Modified)
                        {
                            xTTableAdapter.Update(dataSet.XT.Rows[i]);
                            xTTableAdapter.Fill(dataSet.XT, $"XTRF = {dataSet.XT.Rows[i]["XTRF", DataRowVersion.Original]}", Program.USR);
                        }
                    }
                }
            }
            return dr;
        }

        #endregion ToolStrip

        #region AutoEdit
        private bool _AllowEdit = false;

        private void xTGridControl_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
                _AllowEdit = false;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
                _AllowEdit = true;
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = !_AllowEdit;
        }
        #endregion AutoEdit
    }
}