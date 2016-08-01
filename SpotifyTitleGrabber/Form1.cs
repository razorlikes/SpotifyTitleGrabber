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
            textBox_CurrentSongFile.Text = Environment.CurrentDirectory + "\\CurrentSong.txt";
            textBox_SongListFile.Text = Environment.CurrentDirectory + "\\SongList.txt";
        }

        public void DetectSpotify()
        {
            foreach (var p in Process.GetProcessesByName("Spotify"))
            {
                if (p.MainWindowTitle != "")
                {
                    label_ProgramStatus.Text = "Spotify detected!";
                    spotifyProcess = p;
                    return;
                }
            }
            label_ProgramStatus.Text = "Can't detect Spotify. Check if it's running!";
        }

        private void timer_NameRefresh_Tick(object sender, EventArgs e)
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
                    {
                        titleNameOld = titleName;
                        label_TitleName.Text = titleName;
                        File.WriteAllText(textBox_CurrentSongFile.Text, titleName);
                        File.AppendAllText(textBox_SongListFile.Text, titleName + Environment.NewLine);
                    }
                }
                else if (spotifyProcess.MainWindowTitle == "Drag")
                    return;
                else
                {
                    titleName = spotifyProcess.MainWindowTitle;
                    if (titleName != titleNameOld)
                    {
                        titleNameOld = titleName;
                        label_TitleName.Text = titleName;
                        File.WriteAllText(textBox_CurrentSongFile.Text, titleName);
                        File.AppendAllText(textBox_SongListFile.Text, titleName + Environment.NewLine);
                    }
                }
            }
            else DetectSpotify();
        }
    }
}
