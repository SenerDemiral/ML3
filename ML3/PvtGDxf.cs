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
using DevExpress.XtraPivotGrid;

namespace ML3
{
    public partial class PvtGDxf : DevExpress.XtraEditors.XtraForm
    {
        public PvtGDxf()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pvtGDTableAdapter.Fill(this.dataSetPvt.PvtGD, iQRYToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            if (!e.IsColumn)
            {
                List<PivotGridField> fields;
                if (e.Field == null)
                    fields = pivotGridControl1.GetFieldsByArea(PivotArea.RowArea).ToList();
                else
                    fields = pivotGridControl1.GetFieldsByArea(PivotArea.RowArea).Where(field => field.AreaIndex > e.Field.AreaIndex).ToList();
                if (e.ValueType == PivotGridValueType.GrandTotal
                    || e.ValueType == PivotGridValueType.Total
                    || e.IsCollapsed)
                    e.DisplayText += " = " + e.CreateDrillDownDataSource().Cast<PivotDrillDownDataRow>().GroupBy(row => GetUniqueCombinations(row, fields)).Count();
            }

        }

        public string GetUniqueCombinations(PivotDrillDownDataRow row, List<PivotGridField> fields)
        {
            string key = string.Empty;

            foreach (PivotGridField field in fields)
            {
                key += row[field].ToString() + "|";
            }
            return key;
        }

    }
}