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
    public partial class delete_pro : Form
    {
        string ph_ysername;
        string ordb = "data source= orcl ; user id=scott ; password= tiger; ";
        OracleConnection conn;

        List<string> ll = new List<string>();
        public delete_pro(string un)
        {
            InitializeComponent();
            //ph_ysername = un;
            textBox1.Text = un;
        }

        private void delete_pro_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from has where ph_username =:ph_username";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ph_username", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1].ToString());
            }

            dr.Close();
        }

        private void delete_pro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void delete_pro_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OracleCommand cmd3 = new OracleCommand();
            //cmd3.Connection = conn;
            //// cmd3.Parameters.Add("pharmacy_name", textBox1.Text);
            //cmd3.CommandText = "delete_product_has";
            //cmd3.CommandType = CommandType.StoredProcedure;
            //cmd3.Parameters.Add("pharmacy_name", textBox1.Text);
            //cmd3.Parameters.Add("product_id_name", comboBox1.SelectedItem.ToString());
            //cmd3.ExecuteNonQuery();
            //MessageBox.Show("deleted successfully from table has");

            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.Connection = conn;
            //cmd2.CommandText = "delete_product";
            //cmd2.CommandType = CommandType.StoredProcedure;
            //cmd2.Parameters.Add("m_name", comboBox1.SelectedItem.ToString());
            //cmd2.ExecuteNonQuery();
            //MessageBox.Show("deleted successfully");
            //// ---------------------------------------------------------------
            ////the delete from table medical product has to affect(has) table too
            
        }
    }
}
