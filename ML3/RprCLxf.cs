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
    public partial class RprCLxf : DevExpress.XtraEditors.XtraForm
    {
        Qry.qsvRprCLxc qsFrm = new Qry.qsvRprCLxc();


        public RprCLxf()
        {
            InitializeComponent();
        }

        private void RprCLxf_Load(object sender, EventArgs e)
        {
            qsFrm.FDT = dataSetRpr.RprCL;
            qsFrm.Dock = DockStyle.Fill;

            qsDockPanel.Controls.Add(qsFrm);

        }
    }
}