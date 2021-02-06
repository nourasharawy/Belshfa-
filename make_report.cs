using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace ya_rab
{
    public partial class make_report : Form
    {
        CrystalReport1 cr;
        public make_report()
        {
            InitializeComponent();
        }

        private void make_report_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();

            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void make_report_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
