namespace yt_dlp
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            gboxlist = new GroupBox();
            rblist = new RadioButton();
            rbvideo = new RadioButton();
            tburl = new TextBox();
            btndownload = new Button();
            btnupdate = new Button();
            cbxdefault = new CheckBox();
            btnopenpath = new Button();
            btnstop = new Button();
            btnabout = new Button();
            tooltip1 = new ToolTip(components);
            linkLabel1 = new LinkLabel();
            cbxaot = new CheckBox();
            gboxlist.SuspendLayout();
            SuspendLayout();
            // 
            // gboxlist
            // 
            gboxlist.Controls.Add(rblist);
            gboxlist.Controls.Add(rbvideo);
            gboxlist.Location = new Point(470, 11);
            gboxlist.Name = "gboxlist";
            gboxlist.Size = new Size(161, 42);
            gboxlist.TabIndex = 0;
            gboxlist.TabStop = false;
            // 
            // rblist
            // 
            rblist.AutoSize = true;
            rblist.Location = new Point(93, 15);
            rblist.Name = "rblist";
            rblist.Size = new Size(65, 21);
            rblist.TabIndex = 1;
            rblist.TabStop = true;
            rblist.Text = "Playlist";
            rblist.UseVisualStyleBackColor = true;
            rblist.CheckedChanged += rblist_CheckedChanged;
            // 
            // rbvideo
            // 
            rbvideo.AutoSize = true;
            rbvideo.Location = new Point(15, 15);
            rbvideo.Name = "rbvideo";
            rbvideo.Size = new Size(60, 21);
            rbvideo.TabIndex = 0;
            rbvideo.TabStop = true;
            rbvideo.Text = "Video";
            rbvideo.UseVisualStyleBackColor = true;
            rbvideo.CheckedChanged += rbvideo_CheckedChanged;
            // 
            // tburl
            // 
            tburl.Location = new Point(16, 55);
            tburl.Name = "tburl";
            tburl.Size = new Size(615, 25);
            tburl.TabIndex = 1;
            // 
            // btndownload
            // 
            btndownload.Location = new Point(221, 12);
            btndownload.Name = "btndownload";
            btndownload.Size = new Size(40, 40);
            btndownload.TabIndex = 3;
            btndownload.Text = "Download";
            btndownload.UseVisualStyleBackColor = true;
            btndownload.Click += btndownload_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(359, 12);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(40, 40);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // cbxdefault
            // 
            cbxdefault.AutoSize = true;
            cbxdefault.Location = new Point(20, 22);
            cbxdefault.Name = "cbxdefault";
            cbxdefault.Size = new Size(169, 21);
            cbxdefault.TabIndex = 5;
            cbxdefault.Text = "Default download folder";
            cbxdefault.UseVisualStyleBackColor = true;
            cbxdefault.CheckedChanged += cbxdefault_CheckedChanged;
            // 
            // btnopenpath
            // 
            btnopenpath.Location = new Point(267, 12);
            btnopenpath.Name = "btnopenpath";
            btnopenpath.Size = new Size(40, 40);
            btnopenpath.TabIndex = 7;
            btnopenpath.Text = "Open Path";
            btnopenpath.UseVisualStyleBackColor = true;
            btnopenpath.Click += btnopenpath_Click;
            // 
            // btnstop
            // 
            btnstop.Location = new Point(313, 12);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(40, 40);
            btnstop.TabIndex = 8;
            btnstop.Text = "Terminate";
            btnstop.UseVisualStyleBackColor = true;
            btnstop.Click += btnstop_Click;
            // 
            // btnabout
            // 
            btnabout.Location = new Point(405, 12);
            btnabout.Name = "btnabout";
            btnabout.Size = new Size(40, 40);
            btnabout.TabIndex = 9;
            btnabout.Text = "about...";
            btnabout.UseVisualStyleBackColor = true;
            btnabout.Click += btnabout_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(529, 83);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 17);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "buy me a coffee";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cbxaot
            // 
            cbxaot.AutoSize = true;
            cbxaot.Location = new Point(20, 84);
            cbxaot.Name = "cbxaot";
            cbxaot.Size = new Size(109, 21);
            cbxaot.TabIndex = 11;
            cbxaot.Text = "Always on top";
            cbxaot.UseVisualStyleBackColor = true;
            cbxaot.CheckedChanged += cbxaot_CheckedChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 105);
            Controls.Add(cbxaot);
            Controls.Add(linkLabel1);
            Controls.Add(btnabout);
            Controls.Add(btnstop);
            Controls.Add(btnopenpath);
            Controls.Add(cbxdefault);
            Controls.Add(btnupdate);
            Controls.Add(btndownload);
            Controls.Add(tburl);
            Controls.Add(gboxlist);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            gboxlist.ResumeLayout(false);
            gboxlist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxlist;
        private RadioButton rblist;
        private RadioButton rbvideo;
        private TextBox tburl;
        private Button btndownload;
        private Button btnupdate;
        private CheckBox cbxdefault;
        private Button btnopenpath;
        private Button btnstop;
        private Button btnabout;
        private ToolTip tooltip1;
        private LinkLabel linkLabel1;
        private CheckBox cbxaot;
    }
}