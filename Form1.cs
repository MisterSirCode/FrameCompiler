using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FrameCompiler
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        int fileCount = 0;
        Font firacode;
        string appPath = Application.StartupPath;
        string fiStart;
        int fiDNum;
        string fiExt;

        public Form1()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.firacodeFont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.firacodeFont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.firacodeFont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            firacode = new Font(fonts.Families[0], 14.0F);

            VideoLengthLabel.Font = firacode;
            FrameRangeDialog.Title = "Select the First Frame of your Render";
            FrameRangeDialog.Filter = "PNG files|*.png|JPEG files|*.jpeg;*.jpg";
        }

        private void SelectFramesButton_Click(object sender, EventArgs e)
        {
            FrameRangeDialog.ShowDialog();
        }

        private void UpdatePredictedTime()
        {
            float selectedFPS = float.Parse((string)FramesPerSecond.SelectedItem);
            float seconds = (float)fileCount / selectedFPS;
            int ms = (int)Math.Round((seconds - Math.Floor(seconds)) * 100);
            int sc = (int)(((seconds / 60) - Math.Floor(seconds / 60)) * 60);
            int mn = (int)((seconds / 60 / 60) - Math.Floor(seconds / 60 / 60));
            int hr = (int)Math.Floor(seconds / 60 / 60);
            VideoLengthLabel.Text = hr.ToString("00") + ":" + mn.ToString("00") + ":" + sc.ToString("00") + "." + ms.ToString("00");
        }

        private void InitializeVideo()
        {
            FileInfo fi = new FileInfo(FrameRangeDialog.FileName);
            DirectoryInfo directory = fi.Directory;
            Match matchinit = Regex.Match(fi.Name, @"(\d+)\.[a-z]+$");
            fiStart = Regex.Replace(fi.Name, @"(\d+)\.[a-z]+$", "");
            fiExt = fi.Extension;
            if (matchinit.Success)
            {
                fiDNum = (matchinit.Groups[1].Value).Length;
                string wilds = new string('*', fiDNum);
                string matcher = Regex.Replace(fi.Name, @"(\d+)\.[a-z]+$", wilds) + fi.Extension;
                FileInfo[] files = directory.GetFiles(matcher, SearchOption.TopDirectoryOnly);
                fileCount = files.Length;
            }
            UpdatePredictedTime();
        }

        private void FrameRangeDialog_FileOk(object sender, CancelEventArgs e)
        {
            RenderBox.Load(FrameRangeDialog.FileName);
            InitializeVideo();
        }

        private string RenderCommandFinal()
        {
            string file = fiStart + "%0" + fiDNum + "d" + fiExt; 
            string dirc = "cd " + appPath + " & ";
            string fmpc = "ffmpeg -r " + (string)FramesPerSecond.SelectedItem + " -i " + file +
                " -vcodec libx264 -pix_fmt yuv420p " + fiStart + "." + ((string)FormatType.SelectedItem).ToLowerInvariant();
            return dirc + fmpc;
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            string command = RenderCommandFinal();
            ProcessStartInfo startinfo = new ProcessStartInfo("cmd", "/c " + RenderCommandFinal());
            startinfo.RedirectStandardOutput = true;
            startinfo.UseShellExecute = false;
            startinfo.CreateNoWindow = false;
            Process proc = new Process();
            proc.StartInfo = startinfo;
            proc.Start();
        }

        private void FramesPerSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePredictedTime();
        }

        private void FramesPerSecond_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdatePredictedTime();
        }
    }
}
