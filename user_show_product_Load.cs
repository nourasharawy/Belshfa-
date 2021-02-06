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
    public partial class user_show_product_Load : Form
    {
        string ordb = "data source= orcl ; user id=scott ; password= tiger; ";
        OracleConnection conn;

        OracleDataAdapter adabter;
        OracleCommandBuilder builder;
        DataSet ds;
        bool apper = false;
        public string add = "";
        public string pa_un= "";
        public string pa_emial = "";
        public string ph_un = "";
        public string ph_emial ="";
        public string m_name = "";
        public Int32 m_price = 0;

        public user_show_product_Load(string un)
        {
            InitializeComponent();
            pro_price_txt.Text = un;

        }

        private void user_show_product_Load_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT  * from medical_product";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                showpro_cbm_box.Items.Add(dr[0]);
                m_price = Convert.ToInt32(dr[1].ToString());
            }
            dr.Close();

        }

        private void user_show_product_Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void showpro_cbm_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(showpro_cbm_box.SelectedItem.ToString());
            showpro_cbm_box.Text = "";
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                showpro_cbm_box.Text = "";
            }
            showpro_cbm_box.Text = "";
        }

        private void clear_al_btnl_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            showpro_cbm_box.Text = "";
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = @"select ph.ph_city , ph.ph_email ,ph.ph_username  from pharmacy ph , medical_product m , has h  
                                 where ph.ph_username = h.ph_username 
                                 and m.m_name = h.m_name
                                 and m.m_name=:mp";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("mp", showpro_cbm_box.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();

            bool f = false;
            while (dr.Read())
            {
                if (dr[0].ToString() == add)
                {

                    ph_emial = dr[1].ToString();
                    ph_un = dr[2].ToString();
                    m_name = showpro_cbm_box.SelectedItem.ToString();
                    f = true;
               
                }

            }
            if (f == false)
            {
                ph_emial = "nourasharawy056@gmail.com";
                ph_un = "abseia";
            }
            dr.Close();



            buy b = new buy(pa_un, ph_un, ph_emial, m_name,m_price);
           // b.ShowDialog();
            b.Show();
            this.Hide();
        }

        
        private void More_info_btn_Click(object sender, EventArgs e)
        {
            string constr = "data source= orcl ; user id=scott ; password= tiger;";

            string cmdstr = @"select  * from medical_product
                            WHERE m_name = :product";

            adabter = new OracleDataAdapter(cmdstr, constr);
            adabter.SelectCommand.Parameters.Add("product", showpro_cbm_box.SelectedItem.ToString());
            ds = new DataSet();
            adabter.Fill(ds);
            show_pro_dataGridView1.DataSource = ds.Tables[0];
        }

        private void Done_user_bnt_Click(object sender, EventArgs e)
        {
            bool found = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select  pa_username, pa_password, pa_city, pa_email
                                from patient
                                ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr[0].ToString() == user_Name_txt.Text && dr[1].ToString() == USer_pass_txt.Text)
                {
                    pa_un = dr[0].ToString();
                    pa_emial = dr[3].ToString();
                    add = dr[2].ToString();
                    found = true;
                  
                }
            }

            clear_al_btnl.Visible = true;
            delete_btn.Visible = true;
            Buy_btn.Visible = true;
            More_info_btn.Visible = true;

            listBox1.Visible = true;
            show_pro_dataGridView1.Visible = true;
            showpro_cbm_box.Visible = true;
        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            if (apper == false)
            {
                label3.Visible = true;
                label4.Visible = true;

                user_Name_txt.Visible = true;
                USer_pass_txt.Visible = true;

                Done_user_bnt.Visible = true;
                user_label.Visible = true;
                
                User_btn.Visible = false;

                apper = true;
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void user_show_product_Load_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void done_dmin_btn_Click(object sender, EventArgs e)
        {
            bool found2 = false;


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ph_username, ph_password  from pharmacy";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == Admin_us_txt.Text && dr[1].ToString() == Admin_pass_txt.Text)
                {
                    MessageBox.Show("data right");
                    found2 = true;
                   
                }
            }
            dr.Close();
            if (found2 == false)
                MessageBox.Show("some thing is wrong");

            else
            {
                Admin a = new Admin(Admin_us_txt.Text);
                a.Show();
                this.Hide();
            }
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            if (apper == false)
            {
                label1.Visible = true;
                label2.Visible = true;


                Admin_us_txt.Visible = true;
                Admin_pass_txt.Visible = true;

                done_dmin_btn.Visible = true;
                admin_lable.Visible = true;

                User_btn.Visible = false;
                Admin_btn.Visible = false;

                apper = true;
            }
        }
    }
}
