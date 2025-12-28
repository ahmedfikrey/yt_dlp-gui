using System.Diagnostics;

namespace yt_dlp
{
    public partial class frmMain : Form
    {


        string hashhosh = "\"";
        string selectedFolderPath = "", Buttonimgpath;
        private Process process;
        string plurls = "plurls.txt";


        #region Main Functions

        private string Get_Path_Selection()
        {


            if (cbxdefault.Checked)
            {
                selectedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            }
            else
            {

                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {

                    folderBrowserDialog.Description = "Select a folder";

                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFolderPath = folderBrowserDialog.SelectedPath;

                        if (new Dal().isroot(selectedFolderPath))
                        {
                            MessageBox.Show("Root Drive is not valid, Default Folder has been selected");
                            cbxdefault.Checked = true;
                            selectedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                        }


                    }
                    else
                    {

                        //MessageBox.Show(@"ERROR !! Download Operation can't be completed without choosing download folder", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        MessageBox.Show($@"Default Folder has been selected");
                        cbxdefault.Checked = true;
                        selectedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    }


                }



            }

            return selectedFolderPath;
        }

        private void checked_changed()
        {
            if (rbvideo.Checked)
            {
                tooltip1.SetToolTip(btndownload, @"Download video");
            }
            else if (rblist.Checked)
            {
                tooltip1.SetToolTip(btndownload, @"Download Playlist");

            }
        }


        private void EnableControlls(bool enable)
        {
            if (enable)
            {
                cbxdefault.Enabled = true;
                tburl.Enabled = true;
                gboxlist.Enabled = true;
                btndownload.Enabled = true;
            }
            else
            {
                cbxdefault.Enabled = false;
                tburl.Enabled = false;
                gboxlist.Enabled = false;
                btndownload.Enabled = false;
            }
        }


        #endregion


        #region Run Command Function


        private void AppendLine(string text)
        {
            //tboutput.Clear();


            //if (tboutput.InvokeRequired)
            //{
            //    tboutput.Invoke(new Action<string>(AppendLine), text);
            //}
            //else
            //{
            //    tboutput.AppendText(text + Environment.NewLine);

            //    // 🔸 Autoscroll to bottom
            //    tboutput.SelectionStart = tboutput.Text.Length;
            //    tboutput.ScrollToCaret();
            //}

        }

        private void RunCommandAndCaptureOutput(string command)
        {
            process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            // When output is received
            process.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Update label from UI thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        //tboutput.Text += e.Data + Environment.NewLine;
                        AppendLine(e.Data);
                    });
                }
            };

            // When error is received
            process.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        //tboutput.Text += "ERROR: " + e.Data + Environment.NewLine;
                        AppendLine(e.Data);
                    });
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private async Task downloadplaylist(string PlayListUrl, string finalpath)
        {

            #region Delete Old File if Exists
            if (File.Exists(plurls))
            {
                File.Delete(plurls);
            }
            #endregion


            string cmd = $@"yt-dlp.exe --flat-playlist --print-to-file {hashhosh}url{hashhosh} {plurls} {hashhosh}{PlayListUrl}{hashhosh}";

            process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + cmd;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;



            //start
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();

            //start download

            if (File.Exists(plurls))
            {
                foreach (string url in File.ReadLines(plurls))
                {

                    string command = $@"yt-dlp.exe -S vcodec:h264,res,acodec:m4a -P {finalpath}  {url}";

                    #region MyRegion


                    //Task.Run(() =>
                    //{
                    //    ProcessStartInfo startInfo = new ProcessStartInfo
                    //    {
                    //        FileName = "cmd.exe",
                    //        Arguments = "/c" + $@"yt-dlp.exe -S vcodec:h264,res,acodec:m4a -P {finalpath}  {url}", // /C executes command and then terminates
                    //        UseShellExecute = false,
                    //        RedirectStandardOutput = true,
                    //        CreateNoWindow = true
                    //    };

                    //    using (Process process = new Process { StartInfo = startInfo })
                    //    {
                    //        process.Start();
                    //        string output = process.StandardOutput.ReadToEnd();
                    //        process.WaitForExit();
                    //        MessageBox.Show(output);
                    //    }
                    //});

                    //await Task.WhenAll();

                    #endregion

                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = "cmd.exe",
                        Arguments = "/c" + command,
                        UseShellExecute = true
                    };

                    Process.Start(psi);


                }
            }




        }

        private async Task downloadvideo(string videourl, string finalpath)
        {
            string command = $@"yt-dlp.exe -S vcodec:h264,res,acodec:m4a -P {finalpath}  {videourl}";
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/c" + command,
                UseShellExecute = true
            };

            Process.Start(psi);
        }



        #endregion



        public frmMain()
        {
            InitializeComponent();

            this.AcceptButton = btndownload;
            tburl.Focus();
            Text = "yt_dlp gui";
            //tboutput.Anchor = AnchorStyles.Right;


            #region Styles

            //tooltip
            tooltip1.SetToolTip(gboxlist, "Select download type");
            tooltip1.SetToolTip(btnupdate, "Update the software to the latest version");
            tooltip1.SetToolTip(btnstop, "Terminate the process");
            tooltip1.SetToolTip(btnopenpath, "Open Download Folder");
            tooltip1.SetToolTip(btnabout, "about the developer");


            Buttonimgpath = new Dal().getpath("Buttons");
            new Dal().btnstyleBG(btndownload, Buttonimgpath + Static.download, 40);
            new Dal().btnstyleBG(btnupdate, Buttonimgpath + Static.update, 40);
            new Dal().btnstyleBG(btnabout, Buttonimgpath + Static.about, 40);
            new Dal().btnstyleBG(btnstop, Buttonimgpath + Static.stop, 40);
            new Dal().btnstyleBG(btnopenpath, Buttonimgpath + Static.open, 40);



            #endregion


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Main feature

            rbvideo.Checked = true;

            cbxdefault.Checked = true;

            cbxaot.Checked = false;

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            #endregion
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            #region Test only

            //MessageBox.Show(hashhosh + tburl.Text + hashhosh);



            #endregion


            #region Validation

            if (new Dal().isstringempty(tburl.Text))
            {
                MessageBox.Show(@"The Url is empty!! Please input the Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }



            if (!new Dal().IsUrlValid(tburl.Text))
            {
                MessageBox.Show(@"URL is not Valid!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                return;
            }



            #endregion



            EnableControlls(false);



            string Url = tburl.Text;


            #region Folder Selection



            String FinalPath = hashhosh + selectedFolderPath + hashhosh;


            #endregion



            #region Run the command

            if (rbvideo.Checked)
            {
                //string Video = $@"yt-dlp.exe -S vcodec:h264,res,acodec:m4a -P {FinalPath}  {tburl.Text}";

                //RunCommandAndCaptureOutput(Video);
                downloadvideo(tburl.Text, FinalPath);


            }
            else if (rblist.Checked)
            {
                //string list = $@"yt-dlp.exe -S vcodec:h264,res,acodec:m4a -P {FinalPath} {hashhosh} {tburl.Text} {hashhosh}";

                //RunCommandAndCaptureOutput(list);

                downloadplaylist(tburl.Text, FinalPath);
            }


            #endregion


            EnableControlls(true);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //RunCommandAndCaptureOutput("yt-dlp.exe -U");

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/c" + "yt-dlp.exe -U",
                UseShellExecute = true
            };

            Process.Start(psi);

        }

        private void rbvideo_CheckedChanged(object sender, EventArgs e)
        {
            checked_changed();
        }

        private void rblist_CheckedChanged(object sender, EventArgs e)
        {
            checked_changed();
        }

        private void btnopenpath_Click(object sender, EventArgs e)
        {
            if (new Dal().isstringempty(selectedFolderPath))
            {
                MessageBox.Show("Invalid path");

            }
            else
            {

                try
                {
                    Process.Start("explorer.exe", selectedFolderPath);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbxdefault_CheckedChanged(object sender, EventArgs e)
        {
            Get_Path_Selection();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
                process.Dispose();
                process = null;
                AppendLine("=== Process stopped ===");
            }
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            frmabout frm = new frmabout();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = "https://buymeacoffee.com/ahmed.fikrey",
                    Arguments = ""
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open link: " + ex.Message);
                Clipboard.SetText("https://buymeacoffee.com/ahmed.fikrey");
                MessageBox.Show("Link has been copied.... you now can paste in browser!!");
            }
        }

        private void cbxaot_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxaot.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
