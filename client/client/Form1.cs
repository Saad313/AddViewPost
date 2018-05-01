using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();

            if(chkadmin.CheckState == CheckState.Unchecked)
            {
                server.registeruser(txtusername.Text, txtpassword.Text);
                if(string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    MessageBox.Show("Registered as User");
                }
            }
            else
            {
                server.registeradmin(txtusername.Text, txtpassword.Text);
                if (string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    MessageBox.Show("Registered as An Admin");
                }

            }


        }

        private void lbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
