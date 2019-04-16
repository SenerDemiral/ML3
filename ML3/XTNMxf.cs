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
    public partial class XTNMxf : DevExpress.XtraEditors.XtraForm
    {
        public XTNMxf()
        {
            InitializeComponent();

            xTGridControl.ExternalRepository = Program.MF.persistentRepository;
            colSECEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colPNPEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;
            colSSEH.ColumnEdit = Program.MF.EHrepositoryItemCheckEdit;

        }

        private void xTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetXTNM);

        }

        private void XTNMxf_Load(object sender, EventArgs e)
        {
            xMTableAdapter.Fill(this.dataSetXTNM.XM);
            xNTableAdapter.Fill(this.dataSetXTNM.XN);
            xTTableAdapter.Fill(this.dataSetXTNM.XT);
        }
    }
}