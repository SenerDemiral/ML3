using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ML3.Qry
{
    public partial class qsvMTHxc : DevExpress.XtraEditors.XtraUserControl
    {
        public DataSet1.MTHDataTable FDT;
        public string searchQry;
        private int focusedRecord = 0;

        public qsvMTHxc()
        {
            InitializeComponent();
        }

        private void qsvMTHxc_Load(object sender, EventArgs e)
        {
            Program.MF.qsRestore("qsvMTH", 0, dataSetQry.qsMTH);
            if (dataSetQry.qsMTH.Rows.Count == 0)
            {
                var newRow = dataSetQry.qsMTH.NewqsMTHRow();
                dataSetQry.qsMTH.Rows.Add(newRow);
            }

        }

        private void qsvGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.Handled = true;
            }
        }

        private void qsvGridControl_VisibleChanged(object sender, EventArgs e)
        {
            qsvGridControl.FocusedRecord = focusedRecord;
        }

        private void qsvGridControl_HiddenEditor(object sender, EventArgs e)
        {
            prepareQry();
        }

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                qsvGridControl.DeleteRecord(qsvGridControl.FocusedRecord);
                Program.MF.qsSave("qsvTST", 0, dataSetQry.qsMTH);

                if (dataSetQry.qsMTH.Rows.Count == 0)
                    qsvGridControl.AddNewRecord();

                e.Handled = true;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            int nor = 0;
            Program.MF.startSW();
            focusedRecord = qsvGridControl.FocusedRecord;
            searchQry = qryMemoEdit.Text;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                FDT.Rows.Clear();
                nor = mthTableAdapter.Fill(FDT, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("MTH", nor);

                Program.MF.qsSave("qsvMTH", 0, dataSetQry.qsMTH);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel;
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

        private void prepareQry()
        {
            var view = qsvGridControl;
            view.CloseEditor();

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowMtRF, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"MTRF in ({view.GetCellValue(rowMtRF, view.FocusedRecord)})");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAd, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"upper(AD) containing upper('{view.GetCellDisplayText(rowAd, view.FocusedRecord)}')");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTCKNo, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"TCKNo containing '{view.GetCellDisplayText(rowTCKNo, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowmTel, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"mTel containing '{view.GetCellDisplayText(rowmTel, view.FocusedRecord)}'");
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }

    }
}
