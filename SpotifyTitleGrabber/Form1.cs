using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SpotifyTitleGrabber
{
    public partial class MainForm : Form
    {
        Process spotifyProcess;
        string titleNameOld, titleName, splitArg = " - ", formattedTitle;
        string[] splittedTitle;
        bool createList;

        public MainForm()
        {
            InitializeComponent();
            DetectSpotify();

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg"))
                firstRun();

            //read out the settings file and apply its values to the form
            var cfg = Configuration.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg");
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
            createList = cfg.CreateList;
            if (createList == true)
                cbxCreateList.CheckState = CheckState.Checked;
            else
            {
                cbxCreateList.CheckState = CheckState.Unchecked;
                tbxSongListFile.Enabled = false;
                btnSongListFile.Enabled = false;
            }

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

        public void firstRun()
        {
            var cfgx = new Configuration();

            cfgx.ListPath = tbxSongListFile.Text = Environment.CurrentDirectory + "\\SongList.txt";
            cfgx.CurrentSongPath = tbxCurrentSongFile.Text = Environment.CurrentDirectory + "\\CurrentSong.txt";
            cfgx.TitleFormat = tbxTitleFormat.Text;
            cfgx.TitleFormatNoRemix = tbxTitleFormatNoRemix.Text;
            cfgx.CreateList = false;

            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber");
            cfgx.SaveToFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg");

            MessageBox.Show("The configuration file was not found.\nThe program has created a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (createList == true)
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
                saveCurrentFileDialog.Dispose();
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
                saveListFileDialog.Dispose();
            }
        }

        private void cbxCreateList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCreateList.Checked)
            {
                tbxSongListFile.Enabled = true;
                btnSongListFile.Enabled = true;
                createList = true;
            }
            else if (!cbxCreateList.Checked)
            {
                createList = false;
                tbxSongListFile.Enabled = false;
                btnSongListFile.Enabled = false;
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
            var cfg = new Configuration();

            cfg.ListPath = tbxSongListFile.Text;
            cfg.CurrentSongPath = tbxCurrentSongFile.Text;
            cfg.TitleFormat = tbxTitleFormat.Text;
            cfg.TitleFormatNoRemix = tbxTitleFormatNoRemix.Text;
            cfg.CreateList = createList;

            try
            {
                cfg.SaveToFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg");
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("This user has no right to access:\n" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The folder: " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg\nDoes not exist. The program will now create it.", "Error", MessageBoxButtons.OK);
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber");
                cfg.SaveToFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\razorlikes\\SpotifyTitleGrabber\\config.cfg");
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }

    public class Configuration
    {
        public string TitleFormatNoRemix { get; set; }
        public string TitleFormat { get; set; }
        public string ListPath { get; set; }
        public string CurrentSongPath { get; set; }
        public bool CreateList { get; set; }

        #region XmlSerialization Support

        public void SaveToFile(string filePath)
        {
            SaveToFile(new FileInfo(filePath));
        }

        public void SaveToFile(FileInfo fi)
        {
            using (FileStream fs = fi.Open(FileMode.Create, FileAccess.Write))
            {
                SerializeXml(fs);
            }
        }

        public static Configuration FromFile(string filePath)
        {
            return FromFile(new FileInfo(filePath));
        }

        public static Configuration FromFile(FileInfo fi)
        {
            using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Read))
            {
                return DeserializeXml(fs);
            }
        }

        private void SerializeXml(Stream serializationStream)
        {
            new XmlSerializer(typeof(Configuration)).Serialize(serializationStream, this);
        }

        private static Configuration DeserializeXml(Stream serializationStream)
        {
            return (Configuration)new XmlSerializer(typeof(Configuration)).Deserialize(serializationStream);
        }

        #endregion
    }
}