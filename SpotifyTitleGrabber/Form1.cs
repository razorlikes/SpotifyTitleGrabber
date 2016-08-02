using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SpotifyTitleGrabber
{
    public partial class MainForm : Form
    {
        Process spotifyProcess;
        string titleNameOld = "", titleName;

        public MainForm()
        {
            InitializeComponent();
            DetectSpotify();
            tbxCurrentSongFile.Text = Environment.CurrentDirectory + "\\CurrentSong.txt";
            tbxSongListFile.Text = Environment.CurrentDirectory + "\\SongList.txt";
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
            if (titleName != titleNameOld)
            {
                titleNameOld = titleName;
                lblTitleName.Text = titleName;
                File.WriteAllText(tbxCurrentSongFile.Text, titleName);
                File.AppendAllText(tbxSongListFile.Text, titleName + Environment.NewLine);
            }
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
                    RefreshName(titleName);
                }
                else if (spotifyProcess.MainWindowTitle == "Drag")
                    return;
                else
                {
                    titleName = spotifyProcess.MainWindowTitle;
                    RefreshName(titleName);
                }
            }
            else DetectSpotify();
        }
    }
}
