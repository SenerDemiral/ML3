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
    public partial class qsvRprCLxc : DevExpress.XtraEditors.XtraUserControl
    {
        public DataSetRpr.RprCLDataTable FDT;
        public string searchQry;
        private int focusedRecord = 0;

        public qsvRprCLxc()
        {
            InitializeComponent();
        }

        private void qsvRprCLxc_Load(object sender, EventArgs e)
        {
            Program.MF.qsRestore("qsvRprCL", 0, dataSetQry.qsRprCL);
            if (dataSetQry.qsRprCL.Rows.Count == 0)
            {
                var newRow = dataSetQry.qsRprCL.NewqsRprCLRow();
                dataSetQry.qsRprCL.Rows.Add(newRow);
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
                Program.MF.qsSave("qsvRprCL", 0, dataSetQry.qsRprCL);

                if (dataSetQry.qsRprCL.Rows.Count == 0)
                {
                    qsvGridControl.AddNewRecord();
                    qsvGridControl.SetCellValue(rowRowCnt, qsvGridControl.FocusedRecord, 1000);
                }

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
                nor = rprCLTableAdapter.Fill(FDT, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("qsvRprCL", nor);

                Program.MF.qsSave("qsvRprCL", 0, dataSetQry.qsRprCL);

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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSex, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"Sex = '{view.GetCellValue(rowSex, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDgmTrhGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"MT.DgmTrh >= '{view.GetCellValue(rowDgmTrhGE, view.FocusedRecord):dd.MM.yyyy}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDgmTrhLT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"MT.DgmTrh < '{view.GetCellValue(rowDgmTrhLT, view.FocusedRecord):dd.MM.yyyy}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowGlsTrhGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"GlsTS >= '{view.GetCellValue(rowGlsTrhGE, view.FocusedRecord):dd.MM.yyyy}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowGlsTrhLT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"GlsTS < '{view.GetCellValue(rowGlsTrhLT, view.FocusedRecord):dd.MM.yyyy}'");
            }


            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowxKd, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"XT.Kd starting '{view.GetCellValue(rowxKd, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowxNmn, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"XT.Nmn starting '{view.GetCellValue(rowxNmn, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowxSwA, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"XT.SwA starting '{view.GetCellValue(rowxSwA, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowxSwB, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"XT.SwB starting '{view.GetCellValue(rowxSwB, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowxSwC, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine($"XT.SwC starting '{view.GetCellValue(rowxSwC, view.FocusedRecord)}'");
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRowCnt, view.FocusedRecord)))
            {
                sb.AppendLine($"rows {view.GetCellValue(rowRowCnt, view.FocusedRecord)}");
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }

    }
}
