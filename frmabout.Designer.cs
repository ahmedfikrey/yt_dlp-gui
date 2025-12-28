namespace yt_dlp
{
    partial class frmabout
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
            timer1 = new System.Windows.Forms.Timer(components);
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            pblogo = new PictureBox();
            pblogo1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pblogo1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 192);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 227);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "label2";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(12, 255);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(38, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "label3";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(12, 283);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(38, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "label4";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(12, 309);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(38, 15);
            lbl5.TabIndex = 4;
            lbl5.Text = "label5";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(12, 333);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(38, 15);
            lbl6.TabIndex = 5;
            lbl6.Text = "label6";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(12, 360);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(38, 15);
            lbl7.TabIndex = 6;
            lbl7.Text = "label7";
            // 
            // pblogo
            // 
            pblogo.Location = new Point(401, 77);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(100, 50);
            pblogo.TabIndex = 7;
            pblogo.TabStop = false;
            // 
            // pblogo1
            // 
            pblogo1.Location = new Point(35, 77);
            pblogo1.Name = "pblogo1";
            pblogo1.Size = new Size(100, 50);
            pblogo1.TabIndex = 8;
            pblogo1.TabStop = false;
            // 
            // frmabout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 403);
            Controls.Add(pblogo1);
            Controls.Add(pblogo);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmabout";
            Text = "frmabout";
            LocationChanged += frmabout_LocationChanged;
            Resize += frmabout_Resize;
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pblogo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private PictureBox pblogo;
        private PictureBox pblogo1;
    }
}