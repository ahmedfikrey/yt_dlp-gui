using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_dlp
{
    public partial class frmabout : Form
    {

        #region Main Variables

        string general_path = new Dal().getpath();

        #region Up and down labels
        int x = 255;
        int y = 2;
        int z = 255;
        #endregion

        #region Middle Labels

        #region General
        Font font = new Font("Tahoma", 12);
        int mostup;
        int mostdown;
        #endregion

        #region Heights
        int h01 = 50;
        int h02 = 100;
        int h03 = 150;
        int h04 = 200;
        int h05 = 250;
        int h06 = 300;
        int h07 = 350;
        //int h08 = 400;
        //int h09 = 450;
        //int h10 = 500;
        //int h11 = 550;
        //int h12 = 600;
        //int h13 = 650;
        //int h14 = 700;
        //int h15 = 750;
        //int h16 = 800;
        //int h17 = 850;
        //int h18 = 900;
        //int h19 = 950;
        //int h20 = 1000;
        #endregion

        #endregion




        #endregion




        public frmabout()
        {
            InitializeComponent();



            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            StartPosition = FormStartPosition.CenterScreen;

            timer1.Start();


            //pblogo.Location = new Point(10, 50);
            //pblogo1.Location = new Point(50, 50);

            if (File.Exists(general_path + Static.logo))
            {
                pblogo.Image = Image.FromFile(general_path + Static.logo);
                pblogo.SizeMode = PictureBoxSizeMode.StretchImage;

                pblogo1.Image = Image.FromFile(general_path + Static.logo);
                pblogo1.SizeMode = PictureBoxSizeMode.StretchImage;
            }



            mostup = 50;
            mostdown = Height - 100;

            BackColor = Color.Black;

            #region Fonts and colors
            //lbltop.ForeColor = lbldown.ForeColor = Color.Magenta;
            lbl1.ForeColor = lbl2.ForeColor = lbl4.ForeColor = lbl5.ForeColor = Color.Cyan;
            lbl3.ForeColor = Color.Red;
            #endregion

            #region Label Name
            lbl1.Text = @"Version 1.1.0";
            lbl2.Text = $@"Application Has been Developed by";
            lbl3.Text = @"Ahmed Fekry";
            lbl4.Text = @"Ahmed.fikrey@gmail.com";
            lbl5.Text = @"01003343379 - 01001112786";
            lbl6.Text = @"gggggggggggg";
            lbl7.Text = @"kkkkkkkkkkkkk";
            #endregion




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //#region Up and down labels
            //lbltop.SetBounds(x, y, 1, 1);
            //lbldown.SetBounds(z, Height - 70, 1, 1);
            //x++;
            //z--;
            //if (x >= Width)
            //{
            //    x = 1;
            //}
            //if (z <= -255)
            //{
            //    z = 1100;
            //}
            //#endregion

            #region Middle Labels
            lbl1.SetBounds((Width - TextRenderer.MeasureText(lbl1.Text, font).Width) / 2, h01, 1, 1);
            h01--;
            if (h01 <= mostup)
            {
                h01 = mostdown;
            }

            lbl2.SetBounds((Width - TextRenderer.MeasureText(lbl2.Text, font).Width) / 2, h02, 1, 1);
            h02--;
            if (h02 <= mostup)
            {
                h02 = mostdown;
            }

            lbl3.SetBounds((Width - TextRenderer.MeasureText(lbl3.Text, font).Width) / 2, h03, 1, 1);
            h03--;
            if (h03 <= mostup)
            {
                h03 = mostdown;
            }
            lbl4.SetBounds((Width - TextRenderer.MeasureText(lbl4.Text, font).Width) / 2, h04, 1, 1);
            h04--;
            if (h04 <= mostup)
            {
                h04 = mostdown;
            }
            lbl5.SetBounds((Width - TextRenderer.MeasureText(lbl5.Text, font).Width) / 2, h05, 1, 1);
            h05--;
            if (h05 <= mostup)
            {
                h05 = mostdown;
            }
            //lbl6.SetBounds((Width - TextRenderer.MeasureText(lbl6.Text, font).Width) / 2, h06, 1, 1);
            //h06--;
            //if (h06 <= mostup)
            //{
            //    h06 = mostdown;
            //}
            //lbl7.SetBounds((Width - TextRenderer.MeasureText(lbl7.Text, font).Width) / 2, h07, 1, 1);
            //h07--;
            //if (h07 <= mostup)
            //{
            //    h07 = mostdown;
            //}
            #endregion
        }

        private void frmabout_Resize(object sender, EventArgs e)
        {
            Size = new Size(577, 442);

        }

        private void frmabout_LocationChanged(object sender, EventArgs e)
        {
            new Dal().CenterScreenForm(this);
        }
    }
}
