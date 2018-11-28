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
            //colSNCTXT.ColumnEdit = Program.MF.MemoRepositoryItemMemoExEdit;
            //colSNCTXT.ColumnEdit = Program.MF.repositoryItemRichTextEdit1;

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

        private void riPopup_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = richEditControl1.Document.RtfText;
        }

        private void riPopup_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e)
        {
            e.DisplayText = richEditControl1.Document.Text;
        }

        private void riPopup_QueryPopUp(object sender, CancelEventArgs e)
        {
            BaseEdit editor = (BaseEdit)sender;
            richEditControl1.Document.RtfText = editor.EditValue.ToString();
        }

        private void riPopup_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (!e.AcceptValue)
            {
                PopupContainerEdit pSender = (PopupContainerEdit)sender;
                RichEditControl rEdit = (RichEditControl)pSender.Properties.PopupControl.Controls[0];
                rEdit.Document.RtfText = e.Value.ToString();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "SNCTXT")
                e.RepositoryItem = riPopup;
        }
    }
}