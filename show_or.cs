using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace ya_rab
{
    public partial class show_or : Form
    {
        public string ph_ysername = "";
        public string pa_add = "";
        public Int32 price;
        public string pa_un = "";
        OracleDataAdapter adabter1;
        OracleDataAdapter adabter2;
        OracleCommandBuilder builder;
        DataSet ds;

        public show_or(string un)
        {
            InitializeComponent();
            ph_ysername = un;
        }

        private void show_or_Load(object sender, EventArgs e)
        {
            string constr = "data source= orcl ; user id=scott ; password= tiger;";
            ds = new DataSet();

            adabter1 = new OracleDataAdapter("select * from patient", constr);
            adabter1.Fill(ds ,"paient");

            adabter2 = new OracleDataAdapter("select * from order_medical", constr);
            adabter2.Fill(ds, "product");

            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["PA_USERNAME"],
                                                  ds.Tables[1].Columns["PA_USERNAME"]);
            ds.Relations.Add(r);

            BindingSource bs_master = new BindingSource(ds, "paient");
            BindingSource bs_child = new BindingSource(bs_master, "fk");


            dgv_master.DataSource = bs_master;
            dgv_child.DataSource = bs_child;
           
        }

        private void show_or_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void show_or_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adabter2);
            adabter2.Update(ds.Tables[0]);
            MessageBox.Show("Done Sir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void dgv_master_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_master.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pa_email_txt.Text = dgv_master.Rows[e.RowIndex].Cells["PA_EMAIL"].FormattedValue.ToString();
                pa_add = dgv_master.Rows[e.RowIndex].Cells["PA_CITY"].FormattedValue.ToString();
                pa_un = dgv_master.Rows[e.RowIndex].Cells["PA_USERNAME"].FormattedValue.ToString();
            }
        }

        private void Delivery_btn_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage("nourasharawy056@gmail.com", Pa_email_txt.Text, ph_ysername ,"product Name : "+pro_name_txt.Text +"patient add :" + pa_add );
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("nourasharawy056@gmail.com", "26266415ag");//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("Mail Send");
        }

        private void confimarion_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage("nourasharawy056@gmail.com", Pa_email_txt.Text, ph_ysername, "dear : " +pa_un  +"Kindly know that your Order Done ." + "The Order is : " +pro_name_txt.Text + "Andy Your address is :" + pa_add);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("nourasharawy056@gmail.com", "26266415ag");//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("Mail Send");
        }
    }
}
