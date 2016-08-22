using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SpotifyTitleGrabber
{
    public partial class MainForm : Form
    {
        Process spotifyProcess;
        string titleNameOld, titleName, splitArg = " - ", formattedTitle;
        string[] splittedTitle;

        public MainForm()
        {
            InitializeComponent();
            DetectSpotify();

            if (Properties.Settings.Default.ListPath.Length > 0)
                tbxSongListFile.Text = Properties.Settings.Default.ListPath;
            else tbxSongListFile.Text = Environment.CurrentDirectory + "\\SongList.txt";
            if (Properties.Settings.Default.CurrentSongPath.Length > 0)
                tbxCurrentSongFile.Text = Properties.Settings.Default.CurrentSongPath;
            else tbxCurrentSongFile.Text = Environment.CurrentDirectory + "\\CurrentSong.txt";

            if (Properties.Settings.Default.TitleFormat.Length > 0)
                tbxTitleFormat.Text = Properties.Settings.Default.TitleFormat;
            if (Properties.Settings.Default.TitleFormatNoRemix.Length > 0)
                tbxTitleFormatNoRemix.Text = Properties.Settings.Default.TitleFormatNoRemix;

            saveCurrentFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveListFileDialog.InitialDirectory = Environment.CurrentDirectory;
        }

        public void DetectSpotify()
        {
            foreach (var p in Process.GetProcessesByName("Spotify"))
            {
                if (p.MainWindowTitle != "")
                {
                    lblProgramStatus.Text = "Spotify detected!";
                    spotifyProcess = p;
                    return;
                }
            }
            lblProgramStatus.Text = "Can't detect Spotify. Check if it's running!";
        }
        
        public void RefreshName(string titleName)
        {
            titleNameOld = titleName;
            splittedTitle = Regex.Split(titleName, splitArg);
            if (splittedTitle[0] == titleName)
                formattedTitle = titleName;
            else if (splittedTitle.GetLength(0) == 2)
                formattedTitle = tbxTitleFormatNoRemix.Text.Replace("%a", splittedTitle[0]).Replace("%t", splittedTitle[1]);
            else if (splittedTitle.GetLength(0) == 3)
                formattedTitle = tbxTitleFormat.Text.Replace("%a", splittedTitle[0]).Replace("%t", splittedTitle[1]).Replace("%r", splittedTitle[2]);
            lblTitleName.Text = formattedTitle;
            toolTip.SetToolTip(lblTitleName, lblTitleName.Text);
            File.WriteAllText(tbxCurrentSongFile.Text, formattedTitle);
            File.AppendAllText(tbxSongListFile.Text, titleName + Environment.NewLine);
        }

        private void tmrNameRefresh_Tick(object sender, EventArgs e)
        {
            if (spotifyProcess != null)
            {
                spotifyProcess.Refresh();
                if (spotifyProcess.HasExited)
                    DetectSpotify();
                else if (spotifyProcess.MainWindowTitle == "Spotify")
                {
                    titleName = "Currently no song playing!";
                    if (titleName != titleNameOld)
                        RefreshName(titleName);
                }
                else if (spotifyProcess.MainWindowTitle == "Drag")
                    return;
                else
                {
                    titleName = spotifyProcess.MainWindowTitle;
                    if (titleName != titleNameOld)
                        RefreshName(titleName);
                }
            }
            else DetectSpotify();
        }

        private void btnCurrentSongFile_Click(object sender, EventArgs e)
        {
            DialogResult crntFile = saveCurrentFileDialog.ShowDialog();
            if (crntFile == DialogResult.OK)
            {
                if (saveCurrentFileDialog.FileName != tbxCurrentSongFile.Text & File.Exists(tbxCurrentSongFile.Text) & !File.Exists(saveCurrentFileDialog.FileName))
                    File.Move(tbxCurrentSongFile.Text, saveCurrentFileDialog.FileName);
                tbxCurrentSongFile.Text = saveCurrentFileDialog.FileName;
                Properties.Settings.Default.CurrentSongPath = saveCurrentFileDialog.FileName;
            }      
        }

        private void btnSongListFile_Click(object sender, EventArgs e)
        {
            DialogResult lstFile = saveListFileDialog.ShowDialog();
            if (lstFile == DialogResult.OK)
            {
                if (saveListFileDialog.FileName != tbxSongListFile.Text & File.Exists(tbxSongListFile.Text) & !File.Exists(saveListFileDialog.FileName))
                    File.Move(tbxSongListFile.Text, saveListFileDialog.FileName);
                tbxSongListFile.Text = saveListFileDialog.FileName;
                Properties.Settings.Default.ListPath = saveListFileDialog.FileName;
            }
        }

        private void tbxTitleFormat_Validated(object sender, EventArgs e)
        {
            if (titleName != null)
                RefreshName(titleName);
        }

        private void tbxTitleFormatNoRemix_Validated(object sender, EventArgs e)
        {
            if (titleName != null)
                RefreshName(titleName);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TitleFormat = tbxTitleFormat.Text;
            Properties.Settings.Default.TitleFormatNoRemix = tbxTitleFormatNoRemix.Text;
            Properties.Settings.Default.Save();
        }
    }
}