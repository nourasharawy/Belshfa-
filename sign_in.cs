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

namespace ya_rab
{
    public partial class sign_in : Form
    {
        string ordb = "data source= orcl ; user id=scott ; password= tiger; ";
        OracleConnection conn;
        public sign_in()
        {
            InitializeComponent();
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }
        public char gender;
        private void Done_btn_Click(object sender, EventArgs e)
        {
            if (cust_female_rd_btn.Checked == true)
                gender = 'F';
            else if (cust_female_rd_btn.Checked == true)
                gender = 'M';
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into patient values (:username,:password,:name ,:age ,:email,:gender ,:city,:history  )";

            cmd.Parameters.Add("username", cust_un_txt.Text);
            cmd.Parameters.Add("password", cust_password_txt.Text);
            cmd.Parameters.Add("name", cust_name_txt.Text);
            cmd.Parameters.Add("age", cust_Age_txt.Text);
            cmd.Parameters.Add("email", cust_mail_txt.Text);
            cmd.Parameters.Add("gender", gender);
            cmd.Parameters.Add("city", cust_city_txt.Text);
            cmd.Parameters.Add("history", cust_hd_txt.Text);


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("new customer is added");
            }
        }

        private void sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void sign_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
