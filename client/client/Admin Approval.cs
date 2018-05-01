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
    public partial class Admin_Approval : Form
    {
        public Admin_Approval()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool postidspecified = true;
            if(e.ColumnIndex == 0)
            {
                localhost.Post post = server.getpost(e.RowIndex, postidspecified);
                
            }
        }

        public void showPosts()
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = server.getpostlist();
            dataGridView1.DataSource = bs;

        }
    }
}
