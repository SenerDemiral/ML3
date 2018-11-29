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
    public partial class MTDxf : DevExpress.XtraEditors.XtraForm
    {
        public MTDxf()
        {
            InitializeComponent();

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;

            colMTRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colMTRF.AppearanceCell.Options.UseBackColor = true;
            colMTRF.OptionsColumn.FixedWidth = true;
            colMTRF.OptionsColumn.ReadOnly = true;
            colMTRF.Width = 60;

        }

        private void MTDxf_Load(object sender, EventArgs e)
        {
            //Text = $"[MTD]●{MTHRow.AD}";
            //toolStripLabel1.Text = $"{MTHRow.AD} ● {MTHRow.SEX} ● {MTHRow.DGMTRH:dd.MM.yy}";

            //colHMTRF.Visible = false;

            mtdTableAdapter.Fill(dataSet1.MTD, "MTRF > 0", Program.USR);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void gBToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    MTDRow = (DataSet1.MTDRow)gridView1.GetFocusedDataRow()
                };
                Program.MF.frms[frm].Show();
            }

        }
    }
}