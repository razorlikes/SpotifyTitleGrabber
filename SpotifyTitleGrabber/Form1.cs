using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace SpotifyTitleGrabber
{
    public partial class MainForm : Form
    {
        string titleName;
        int PID;

        public MainForm()
        {
            InitializeComponent();

            foreach (var p in Process.GetProcesses())
            {
                if (p.ProcessName == "Spotify" & p.MainWindowTitle != "")
                {
                    label_ProgramStatus.Text = "Spotify detected!";
                    PID = p.Id;
                    return;
                }
                else label_ProgramStatus.Text = "Can't detect Spotify. Check if it's running!";
            }
        }

        private void timer_NameRefresh_Tick(object sender, EventArgs e)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (p.Id == PID)
                {
                    if (p.MainWindowTitle == "Spotify")
                        label_TitleName.Text = "Currently no song playing!";
                    else label_TitleName.Text = p.MainWindowTitle.ToString();
                }
            }
        }
    }
}
