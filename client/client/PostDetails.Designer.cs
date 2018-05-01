namespace client
{
    partial class PostDetails
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txttitleS = new System.Windows.Forms.TextBox();
            this.txtcategoryS = new System.Windows.Forms.TextBox();
            this.txtdescriptionS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(60, 46);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(27, 13);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(60, 114);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(49, 13);
            this.lblcategory.TabIndex = 1;
            this.lblcategory.Text = "Category";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(60, 176);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(60, 13);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description";
            // 
            // txttitleS
            // 
            this.txttitleS.Location = new System.Drawing.Point(178, 46);
            this.txttitleS.Name = "txttitleS";
            this.txttitleS.Size = new System.Drawing.Size(100, 20);
            this.txttitleS.TabIndex = 3;
            // 
            // txtcategoryS
            // 
            this.txtcategoryS.Location = new System.Drawing.Point(178, 111);
            this.txtcategoryS.Name = "txtcategoryS";
            this.txtcategoryS.Size = new System.Drawing.Size(100, 20);
            this.txtcategoryS.TabIndex = 4;
            // 
            // txtdescriptionS
            // 
            this.txtdescriptionS.Location = new System.Drawing.Point(178, 176);
            this.txtdescriptionS.Multiline = true;
            this.txtdescriptionS.Name = "txtdescriptionS";
            this.txtdescriptionS.Size = new System.Drawing.Size(165, 92);
            this.txtdescriptionS.TabIndex = 5;
            // 
            // PostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 328);
            this.Controls.Add(this.txtdescriptionS);
            this.Controls.Add(this.txtcategoryS);
            this.Controls.Add(this.txttitleS);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lbltitle);
            this.Name = "PostDetails";
            this.Text = "PostDetails";
            this.Load += new System.EventHandler(this.PostDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txttitleS;
        private System.Windows.Forms.TextBox txtcategoryS;
        private System.Windows.Forms.TextBox txtdescriptionS;
    }
}