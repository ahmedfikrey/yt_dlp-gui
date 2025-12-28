
using System;
using System.Collections.Generic;
using System.Data;

using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace yt_dlp
{
    public class Dal : IDisposable
    {
        #region Validation Part

        
        public bool isroot(string path)
        {
            return string.Equals(
            Path.GetFullPath(path).TrimEnd(Path.DirectorySeparatorChar),
            Path.GetPathRoot(path).TrimEnd(Path.DirectorySeparatorChar),
            StringComparison.OrdinalIgnoreCase);
        }


        public bool isstringempty(string x)
        {
            if (string.IsNullOrEmpty(x) || string.IsNullOrWhiteSpace(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsUrlValid(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public bool IsValidIPAddress(string ipAddress)
        {
            // Regular expression for validating IPv4 addresses
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(ipAddress, pattern);
        }

        #endregion

        #region Hashing
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion

        #region Styles

        public void DGVStyle(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ScrollBars = ScrollBars.Both;
        }

        public void btnstyle(Button btn, string path, bool reverse = false)
        {
            if (File.Exists(path))
            {
                btn.Image = Image.FromFile(path);
                if (reverse == false)
                {
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    btn.ImageAlign = ContentAlignment.MiddleRight;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                }


            }
        }


        public void btnstyleBG(Button btn, string path, int wl)
        {
            btn.Text = string.Empty;
            btn.Size = new Size(wl, wl);
            if (File.Exists(path))
            {
                //btn.Image = Image.FromFile(path);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Image.FromFile(path);

            }
        }

        public void CenterScreenForm(Form frm)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int formWidth = frm.Width;
            int formHeight = frm.Height;

            frm.Left = (screenWidth - formWidth) / 2;
            frm.Top = (screenHeight - formHeight) / 2;

        }



        #endregion

        #region Get Pathes

        public string getpath(string foldername = null)
        {
            string path;
            if (foldername == null)
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images\\");
            }
            else
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images\\" + foldername + "\\");
            }
            
            return path;
        }




        #endregion

        




        #region Dispose
        public void Dispose()
        {

        }
        #endregion

    }
}
