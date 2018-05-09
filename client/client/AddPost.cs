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
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }

        private void cmdaddpost_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            server.addpost(txtposttitle.Text, txtpostcategory.Text, txtpostdescription.Text);
            if (string.IsNullOrWhiteSpace(txtposttitle.Text) && string.IsNullOrWhiteSpace(txtpostcategory.Text) && string.IsNullOrWhiteSpace(txtpostdescription.Text))
            {
                MessageBox.Show("Empty");
            }
            else
            {
                MessageBox.Show("Posted Succesfully Now Wait For Approval");
                
            }
            txtposttitle.Text = "";
            txtpostcategory.Text = "";
            txtpostdescription.Text = "";
        }

        private void lblapprovalrequest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PendingPostUser ppu = new PendingPostUser();
            this.Hide();
            ppu.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingPostUser ppu = new PendingPostUser();
            this.Hide();
            ppu.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }

        private void AddPost_Load(object sender, EventArgs e)
        {

        }
      
    }
}
