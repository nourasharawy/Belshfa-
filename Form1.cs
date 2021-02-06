using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ya_rab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            user_show_product_Load l = new user_show_product_Load("");
            //   login l = new login();
            l.Show();
            this.Hide();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            sign_in l = new sign_in();
            l.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void skip_btn_Click(object sender, EventArgs e)
        {
            skip_login2 s = new skip_login2();
            s.Show();
            this.Hide();
        }
    }
}
