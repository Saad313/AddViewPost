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
    public partial class PendingPostsAdmin : Form
    {
        public PendingPostsAdmin()
        {
            InitializeComponent();
        }

        private void dgPendingAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        public void showPostPend()
        {
            localhost.Service1 server = new localhost.Service1();
            localhost.Post PRO = new localhost.Post();
            BindingSource bs = new BindingSource();
            bs.DataSource = server.getPendingpostlist();
            dgPendingAdmin.DataSource = bs;
          
        }

        private void PendingPostsAdmin_Load(object sender, EventArgs e)
        {
            showPostPend();
        }

        private void cmdapprove_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            int selectedrowindex = dgPendingAdmin.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgPendingAdmin.Rows[selectedrowindex];
            string i = selectedRow.Cells[5].Value.ToString();
            server.approvePost(i);
            showPostPend();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            this.Hide();
            R.Show();
        }

        private void approvedPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApprovedPosts ap = new ApprovedPosts();
            this.Hide();
            ap.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }
    }
}
