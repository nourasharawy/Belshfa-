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
    public partial class skip_login2 : Form
    {
        CrystalReport2 cr2;

        public skip_login2()
        {
            InitializeComponent();
        }

        private void skip_login2_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr2.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void skip_login2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr2;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
