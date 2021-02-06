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
    public partial class buy : Form
    {
        string ordb = "data source= orcl ; user id=scott ; password= tiger; ";
        OracleConnection conn;
        public  Int32 m_p =0;
        public Int32 neworderid;
        public buy(string pa_un, string ph_unm, string ph_mial, string m_name ,Int32 m_price)
        {
            InitializeComponent();
            pa_UN_txt.Text = pa_un;
            Phamacy_un.Text = ph_unm;
            Email_txt.Text = ph_mial;
            M_name.Text = m_name; 
            m_p=m_price;
            
        }

        private void buy_Load(object sender, EventArgs e)
        {
            date_now_lbl.Text = DateTime.Now.ToShortTimeString();//ToShortDateString();//ToLongTimeString();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


          
           // 
            int maxid, newid;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
          //  cmd.CommandText ="insert into order_medical values(:id,:date,:price,:pa_name, 'sent')";
            cmd.CommandText ="getmaxid";
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Parameters.Add("id" ,OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxid=Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newid= maxid+1;
            }
            catch
            {newid =1;};

            neworderid = newid;
            //MessageBox.Show("newid "+newid);
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            //  cmd.CommandText ="insert into order_medical values(:id,:date,:price,:pa_name, :st)";
            c.CommandText = "insert_order";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id",newid);
            c.Parameters.Add("date", Convert.ToDateTime(date_now_lbl.Text));
            c.Parameters.Add("price",m_p );
            c.Parameters.Add("pa_name", pa_UN_txt.Text);
            c.Parameters.Add("st", "sent");
            c.ExecuteNonQuery();
          
                MessageBox.Show("your Request done sir");


                MailMessage msg = new MailMessage("nourasharawy056@gmail.com", Email_txt.Text, pa_UN_txt.Text, "patiet user name : " + pa_UN_txt.Text + "     " + "order id : " + neworderid + "    " + "product name : " + M_name.Text + "     " + "date : " + Convert.ToDateTime(date_now_lbl.Text));
                msg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("nourasharawy056@gmail.com", "26266415ag");//your mail password
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
                MessageBox.Show("Mail Send");


        }

        private void buy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void date_now_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
