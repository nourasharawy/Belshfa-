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
    public partial class Admin : Form
    {
       // OracleDataAdapter adabter;
       // OracleCommandBuilder builder;
       // DataSet ds;

        public string username = "";
        public Admin(string un)
        {
            InitializeComponent();
            username = un;
            
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
         //   string constr = "data source= orcl ; user id=scott ; password= tiger;";
         //
         //   string cmdstr = @"select  m.m_name , m.m_price , m.m_category , m.m_side_effect , m.m_drug , m.m_precaution, ph.ph_username
         //                     from pharmacy ph ,  has h  , medical_product m
         //                     where ph.ph_username ='rahma'
         //                     and h.ph_username=ph.ph_username 
         //                     and h.m_name = m.m_name
         //                     ";
         //
         //   adabter = new OracleDataAdapter(cmdstr, constr);
         //   adabter.SelectCommand.Parameters.Add("product", showpro_cbm_box.SelectedItem.ToString());
         //   ds = new DataSet();
         //   adabter.Fill(ds);
         //   da
         //   da.DataSource = ds.Tables[0];
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_pro_btn_Click(object sender, EventArgs e)
        {
            delete_pro d = new delete_pro(username);
            d.Show();
            this.Hide();
        }

        private void Add_pro_btn_Click(object sender, EventArgs e)
        {
            Add_pro add = new Add_pro(username);
            add.Show();
            this.Hide();

        }

        private void show_order_btn_Click(object sender, EventArgs e)
        {
            show_or s = new show_or(username);
            s.Show();
            this.Hide();

        }

        private void make_reprot_btn_Click(object sender, EventArgs e)
        {
            make_report m = new make_report();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_report o = new order_report();
            o.Show();
            this.Hide();
        }
    }
}
