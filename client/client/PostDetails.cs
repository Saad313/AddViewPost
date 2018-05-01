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
    public partial class PostDetails : Form
    {
        private localhost.Post postShow;
        public PostDetails()
        {
            InitializeComponent();
        }

        public PostDetails(localhost.Post post)
        {
            InitializeComponent();
            postShow = post;
        }

        private void PostDetails_Load(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();

            txttitleS.Text = postShow.Title;
            txtcategoryS.Text = postShow.Category;
            txtdescriptionS.Text = postShow.Description;
        }
    }
}
