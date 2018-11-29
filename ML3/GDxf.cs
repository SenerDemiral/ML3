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

            colGDRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGDRF.AppearanceCell.Options.UseBackColor = true;
            colGDRF.OptionsColumn.FixedWidth = true;
            colGDRF.OptionsColumn.ReadOnly = true;
            colGDRF.Width = 50;

            colPRRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colPRRF.AppearanceCell.Options.UseBackColor = true;
            colPRRF.OptionsColumn.FixedWidth = true;
            colPRRF.OptionsColumn.ReadOnly = true;
            colPRRF.Width = 50;

            colGBRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGBRF.AppearanceCell.Options.UseBackColor = true;
            colGBRF.OptionsColumn.FixedWidth = true;
            colGBRF.OptionsColumn.ReadOnly = true;
            colGBRF.Width = 50;

            colGRRF.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro;
            colGRRF.AppearanceCell.Options.UseBackColor = true;
            colGRRF.OptionsColumn.FixedWidth = true;
            colGRRF.OptionsColumn.ReadOnly = true;
            colGRRF.Width = 50;

        }

        private void gDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gdBindingSource.EndEdit();
            this.gdTableAdapter.Update(this.dataSet1.GD);

        }

        private void GDxf_Load(object sender, EventArgs e)
        {
            if (GBRow != null)
            {
                Text = $"{GBRow.GLSTS:dd.MM.yy} [GD]";
                toolStripLabel1.Text = $"{MTHRow.AD} ● {MTHRow.SEX} ● Dğm:{MTHRow.DGMTRH:dd.MM.yy} ● Glş:{GBRow.GLSTS:dd.MM.yy}";

                //colHMTRF.Visible = false;

                gdTableAdapter.Fill(dataSet1.GD, $"GBRF = {GBRow.GBRF}", Program.USR);


            }

        }

    }
}