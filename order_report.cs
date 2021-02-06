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
    public partial class order_report : Form
    {
        CrystalReport3 cr3;
        public order_report()
        {
            InitializeComponent();
        }

        private void order_report_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void order_report_Load(object sender, EventArgs e)
        {

            cr3 = new CrystalReport3();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            cr3.SetParameterValue(0,Staet_txt.Text);
            cr3.SetParameterValue(1, End_txt.Text);
            crystalReportViewer1.ReportSource = cr3;
        }
    }
}
