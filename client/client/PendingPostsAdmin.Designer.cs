namespace client
{
    partial class PendingPostsAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgPendingAdmin = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmdapprove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingAdmin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPendingAdmin
            // 
            this.dgPendingAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendingAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail});
            this.dgPendingAdmin.Location = new System.Drawing.Point(12, 55);
            this.dgPendingAdmin.Name = "dgPendingAdmin";
            this.dgPendingAdmin.Size = new System.Drawing.Size(348, 213);
            this.dgPendingAdmin.TabIndex = 0;
            this.dgPendingAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPendingAdmin_CellContentClick);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Click Here";
            this.Detail.UseColumnTextForLinkValue = true;
            // 
            // cmdapprove
            // 
            this.cmdapprove.Location = new System.Drawing.Point(315, 274);
            this.cmdapprove.Name = "cmdapprove";
            this.cmdapprove.Size = new System.Drawing.Size(75, 23);
            this.cmdapprove.TabIndex = 1;
            this.cmdapprove.Text = "Approve";
            this.cmdapprove.UseVisualStyleBackColor = true;
            this.cmdapprove.Click += new System.EventHandler(this.cmdapprove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.approvedPostsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // approvedPostsToolStripMenuItem
            // 
            this.approvedPostsToolStripMenuItem.Name = "approvedPostsToolStripMenuItem";
            this.approvedPostsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.approvedPostsToolStripMenuItem.Text = "ApprovedPosts";
            this.approvedPostsToolStripMenuItem.Click += new System.EventHandler(this.approvedPostsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // PendingPostsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 309);
            this.Controls.Add(this.cmdapprove);
            this.Controls.Add(this.dgPendingAdmin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PendingPostsAdmin";
            this.Text = "PendingPostsAdmin";
            this.Load += new System.EventHandler(this.PendingPostsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingAdmin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPendingAdmin;
        private System.Windows.Forms.DataGridViewLinkColumn Detail;
        private System.Windows.Forms.Button cmdapprove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}