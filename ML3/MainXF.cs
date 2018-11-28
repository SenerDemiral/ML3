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
using System.Diagnostics;
using System.Threading;

namespace ML3
{
    public partial class MainXF : DevExpress.XtraEditors.XtraForm
    {
        public Dictionary<string, XtraForm> frms = new Dictionary<string, XtraForm>();

        public MainXF()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
        }

        public void qsSave(string layoutName, int idx, DataTable dt)
        {
            
            System.IO.StringWriter writer = new System.IO.StringWriter();
            dt.WriteXml(writer, XmlWriteMode.IgnoreSchema, false);
            queriesTableAdapter.ZFL_SET(Program.USR, layoutName, idx, writer.ToString());
            
        }

        public void qsRestore(string layoutName, int idx, DataTable dt)
        {
            dt.Clear();
            string text = (string)queriesTableAdapter.ZFL_GET(Program.USR, layoutName, idx);
            if (!string.IsNullOrEmpty(text))
            {
                System.IO.StringReader reader = new System.IO.StringReader(text);
                dt.ReadXml(reader);
                dt.AcceptChanges();
            }
        }

        Stopwatch stopWatch = new Stopwatch();

        public void startSW()
        {
            Cursor.Current = Cursors.WaitCursor;
            stopWatch.Restart();
        }

        public void stopSW(string info, int nor)
        {
            Cursor.Current = Cursors.Default;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            //elapsedTimeToolStripStatusLabel.Text = String.Format("{0:n0} {1} kaydı {2:N3} saniyede okundu", nor, info, ts.TotalSeconds);
        }

        private void mtdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frm = "MTD";
            if (!frms.ContainsKey(frm))
                frms[frm] = null;

            var doc = documentManager.GetDocument(frms[frm]);
            if (doc != null)
                tabbedView1.Controller.Activate(doc);
            else
            {
                frms[frm] = new MTDxf
                {
                    MdiParent = this
                };
                frms[frm].Show();
            }

        }

        public int GET_PK(string tbl)
        {
            int PK = (int)queriesTableAdapter.GET_PK(tbl);
            return PK;
        }

        public void FillLookups()
        {

            Task.Run(() =>
            {
                //sw.Restart();
                //watcher.Start();

                mtglTableAdapter.Fill(dataSet1.MTGL);
                mtdlTableAdapter.Fill(dataSet1.MTDL);
                xtlTableAdapter.Fill(dataSet1.XTL);


                //sw.Stop();
                //InitLookups();
            }).ContinueWith((t) => {

                //toolStripStatusLabel1.Text = $"Lookup recs read in {sw.ElapsedMilliseconds:n0} milisec [{sw.Elapsed}]";
            });

        }

        #region MenuRegion

        private void mtgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frm = "MTG";
            if (!frms.ContainsKey(frm))
                frms[frm] = null;

            var doc = documentManager.GetDocument(frms[frm]);
            if (doc != null)
                tabbedView1.Controller.Activate(doc);
            else
            {
                frms[frm] = new MTGxf
                {
                    MdiParent = this
                };
                frms[frm].Show();
            }
        }

        private void MTHtoolStripButton_Click(object sender, EventArgs e)
        {
            string frm = "MTH";
            if (!frms.ContainsKey(frm))
                frms[frm] = null;

            var doc = documentManager.GetDocument(frms[frm]);
            if (doc != null)
                tabbedView1.Controller.Activate(doc);
            else
            {
                frms[frm] = new MTHxf
                {
                    MdiParent = this
                };
                frms[frm].Show();
            }

        }

        #endregion MenuRegion

        private void MainXF_Load(object sender, EventArgs e)
        {
        }
    }
}