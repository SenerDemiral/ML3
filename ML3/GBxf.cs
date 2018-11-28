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

            colGBRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGBRF.AppearanceCell.Options.UseBackColor = true;
            colGBRF.OptionsColumn.FixedWidth = true;
            colGBRF.OptionsColumn.ReadOnly = true;
            colGBRF.Width = 50;
        }

        private void gBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            gbBindingSource.EndEdit();
            gbTableAdapter.Update(dataSet1.GB);

        }

        private void GBxf_Load(object sender, EventArgs e)
        {

            if (MTHRow != null)
            {
                Text = $"{MTHRow.AD} [GB]";
                toolStripLabel1.Text = $"{MTHRow.AD} ● {MTHRow.SEX} ● {MTHRow.DGMTRH:dd.MM.yy}";

                colHMTRF.Visible = false;

                gbTableAdapter.Fill(dataSet1.GB, $"HMTRF = {MTHRow.MTRF}", Program.USR);


            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void revertToolStripButton_Click(object sender, EventArgs e)
        {

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
                    MdiParent = Program.MF,
                    GBRow = (DataSet1.GBRow)gridView1.GetFocusedDataRow(),
                    MTHRow = this.MTHRow
                };
                Program.MF.frms[frm].Show();
            }

        }
    }
}