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
    public partial class ApprovedPosts : Form
    {
        public ApprovedPosts()
        {
            InitializeComponent();
        }

        private void ApprovedPosts_Load(object sender, EventArgs e)
        {
            approvedPosts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool postidspecified = true;
            if (e.ColumnIndex == 0)
            {
                localhost.Post post = server.getpost(e.RowIndex, postidspecified);
                PostDetails pd = new PostDetails();
                pd.setTitle(post.Title);
                pd.setCategory(post.Category);
                pd.setdescription(post.Description);
                pd.Show();
            }
        }

        public void approvedPosts()
        {
            localhost.Service1 server = new localhost.Service1();
            localhost.Post PRO = new localhost.Post();
            BindingSource bs = new BindingSource();
            bs.DataSource = server.getapprovedpost();
            dgapproved.DataSource = bs;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }

        private void pendingPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingPostsAdmin ppa = new PendingPostsAdmin();
            this.Hide();
            ppa.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }
    }
}
