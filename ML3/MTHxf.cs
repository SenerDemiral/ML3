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

            mthTableAdapter.ClearBeforeFill = false;
        }

        private void MTHxf_Load(object sender, EventArgs e)
        {
            qsFrm.FDT = dataSet.MTH;
            qsFrm.Dock = DockStyle.Fill;

            qsDockPanel.Controls.Add(qsFrm);

            toolStripLabel1.Text = "Şener DEMİRAL, 1960, GlşTrh: 23.11.18";
            Text = "Şener DEMİRAL, 1960, GlşTrh: 23.11.18";

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

            //gridView1.CloseEditor();
            //gridView1.UpdateCurrentRow();
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
                    /*
                    try
                    {
                        mthTableAdapter.Update(dataSet.MTH);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        dr = DialogResult.Abort;
                    }*/
                }
            }
            return dr;
        }


    }
}