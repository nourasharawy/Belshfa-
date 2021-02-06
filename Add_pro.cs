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
    public partial class Add_pro : Form
    {

        string ph_ysername;
        string ordb = "data source= orcl ; user id=scott ; password= tiger; ";
        OracleConnection conn;

        List<string> ll = new List<string>();
        public Add_pro(string un)
        {
            InitializeComponent();
            ph_ysername = un;
        }

        private void Add_pro_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_product_names ";
            cmd.CommandType = CommandType.StoredProcedure;
            // check name  -> we done that to make sure nothing is repeated

            cmd.Parameters.Add("m_name", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ll.Add(dr[0].ToString());
            }
           
        }

        private void Add_pro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Add_pro_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void Save_changes_btn_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < ll.Count; i++)
            {
                if (ll[i] == name.Text)
                {
                    MessageBox.Show("you have inserted the same name before : ");

                }
                else
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "add_products";
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("m_name", name.Text);
                    int x = Convert.ToInt32(price.Text);
                    cmd2.Parameters.Add("m_price", x);
                    cmd2.Parameters.Add("m_category", category.Text);
                    cmd2.Parameters.Add("m_side_Effect", side.Text);
                    cmd2.Parameters.Add("m_drug", drug.Text);
                    cmd2.Parameters.Add("m_precaution", precaution.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("inserted successfully");
                    break;
                }
            }
            //--------------------------------
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "insert_into_has ";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("ph_username", ph_ysername);
            cmd3.Parameters.Add("m_name", name.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("inserted successfully into table has");

        }
    }
}
