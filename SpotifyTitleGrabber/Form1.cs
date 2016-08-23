using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

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

            if (!File.Exists(Environment.CurrentDirectory + "\\config.cfg"))
            {
                var cfgx = new Configuration();

                cfgx.ListPath = tbxSongListFile.Text;
                cfgx.CurrentSongPath = tbxCurrentSongFile.Text;
                cfgx.TitleFormat = tbxTitleFormat.Text;
                cfgx.TitleFormatNoRemix = tbxTitleFormatNoRemix.Text;
                cfgx.SaveToFile(Environment.CurrentDirectory + "\\config.cfg");
            }       

            var cfg = Configuration.FromFile(Environment.CurrentDirectory + "\\config.cfg");

            if (cfg.ListPath.Length > 0)
                tbxSongListFile.Text = cfg.ListPath;
            else tbxSongListFile.Text = Environment.CurrentDirectory + "\\SongList.txt";
            if (cfg.CurrentSongPath.Length > 0)
                tbxCurrentSongFile.Text = cfg.CurrentSongPath;
            else tbxCurrentSongFile.Text = Environment.CurrentDirectory + "\\CurrentSong.txt";

            if (cfg.TitleFormat.Length > 0)
                tbxTitleFormat.Text = cfg.TitleFormat;
            if (cfg.TitleFormatNoRemix.Length > 0)
                tbxTitleFormatNoRemix.Text = cfg.TitleFormatNoRemix;

            saveCurrentFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveListFileDialog.InitialDirectory = Environment.CurrentDirectory;
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

        private void btnCurrentSongFile_Click(object sender, EventArgs e)
        {
            DialogResult crntFile = saveCurrentFileDialog.ShowDialog();
            if (crntFile == DialogResult.OK)
            {
                if (saveCurrentFileDialog.FileName != tbxCurrentSongFile.Text & File.Exists(tbxCurrentSongFile.Text) & !File.Exists(saveCurrentFileDialog.FileName))
                    File.Move(tbxCurrentSongFile.Text, saveCurrentFileDialog.FileName);
                tbxCurrentSongFile.Text = saveCurrentFileDialog.FileName;
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
            var cfg = Configuration.FromFile(Environment.CurrentDirectory + "\\config.cfg");

            cfg.ListPath = tbxSongListFile.Text;
            cfg.CurrentSongPath = tbxCurrentSongFile.Text;
            cfg.TitleFormat = tbxTitleFormat.Text;
            cfg.TitleFormatNoRemix = tbxTitleFormatNoRemix.Text;

            cfg.SaveToFile(Environment.CurrentDirectory + "\\config.cfg");
        }
    }

    [Serializable]
    internal class Configuration
    {
        internal string CurrentSongPath { get; set; }
        internal string ListPath { get; set; }
        internal string TitleFormat { get; set; }
        internal string TitleFormatNoRemix { get; set; }

        internal bool IsValid => File.Exists(CurrentSongPath) && File.Exists(ListPath) && File.Exists(TitleFormat) && File.Exists(TitleFormatNoRemix);

        #region Serialization Support

        internal void SaveToFile(string filePath)
        {
            SaveToFile(new FileInfo(filePath));
        }

        internal void SaveToFile(FileInfo file)
        {
            using (FileStream fs = file.Open(FileMode.Create, FileAccess.Write))
                new BinaryFormatter().Serialize(fs, this);
        }

        internal static Configuration FromFile(string filePath)
        {
            return FromFile(new FileInfo(filePath));
        }

        internal static Configuration FromFile(FileInfo file)
        {
            using (FileStream fs = file.Open(FileMode.Open, FileAccess.Read))
                return (Configuration)new BinaryFormatter().Deserialize(fs);
        }
        #endregion
    }
}