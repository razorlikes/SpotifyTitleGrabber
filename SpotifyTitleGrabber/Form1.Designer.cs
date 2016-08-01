namespace SpotifyTitleGrabber
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer_NameRefresh = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_ProgramStatus = new System.Windows.Forms.Label();
            this.openFileDialog_TitleName = new System.Windows.Forms.OpenFileDialog();
            this.label_TitleName = new System.Windows.Forms.Label();
            this.textBox_CurrentSongFile = new System.Windows.Forms.TextBox();
            this.button_CurrentSongFile = new System.Windows.Forms.Button();
            this.groupBox_Files = new System.Windows.Forms.GroupBox();
            this.textBox_SongListFile = new System.Windows.Forms.TextBox();
            this.button_SongListFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_NameRefresh
            // 
            this.timer_NameRefresh.Enabled = true;
            this.timer_NameRefresh.Interval = 500;
            this.timer_NameRefresh.Tick += new System.EventHandler(this.timer_NameRefresh_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "This program will read out the title of the currently playing track in Spotify an" +
    "d write it into a file.";
            // 
            // label_ProgramStatus
            // 
            this.label_ProgramStatus.AutoSize = true;
            this.label_ProgramStatus.Location = new System.Drawing.Point(4, 39);
            this.label_ProgramStatus.Name = "label_ProgramStatus";
            this.label_ProgramStatus.Size = new System.Drawing.Size(97, 13);
            this.label_ProgramStatus.TabIndex = 0;
            this.label_ProgramStatus.Text = "Detecting Spotify...";
            // 
            // label_TitleName
            // 
            this.label_TitleName.AutoSize = true;
            this.label_TitleName.Location = new System.Drawing.Point(4, 54);
            this.label_TitleName.Name = "label_TitleName";
            this.label_TitleName.Size = new System.Drawing.Size(102, 13);
            this.label_TitleName.TabIndex = 0;
            this.label_TitleName.Text = "Waiting for Spotify...";
            // 
            // textBox_CurrentSongFile
            // 
            this.textBox_CurrentSongFile.Location = new System.Drawing.Point(6, 34);
            this.textBox_CurrentSongFile.Name = "textBox_CurrentSongFile";
            this.textBox_CurrentSongFile.Size = new System.Drawing.Size(240, 20);
            this.textBox_CurrentSongFile.TabIndex = 3;
            // 
            // button_CurrentSongFile
            // 
            this.button_CurrentSongFile.Location = new System.Drawing.Point(252, 33);
            this.button_CurrentSongFile.Name = "button_CurrentSongFile";
            this.button_CurrentSongFile.Size = new System.Drawing.Size(39, 22);
            this.button_CurrentSongFile.TabIndex = 1;
            this.button_CurrentSongFile.Text = "...";
            this.button_CurrentSongFile.UseVisualStyleBackColor = true;
            // 
            // groupBox_Files
            // 
            this.groupBox_Files.Controls.Add(this.label3);
            this.groupBox_Files.Controls.Add(this.label2);
            this.groupBox_Files.Controls.Add(this.textBox_SongListFile);
            this.groupBox_Files.Controls.Add(this.button_SongListFile);
            this.groupBox_Files.Controls.Add(this.textBox_CurrentSongFile);
            this.groupBox_Files.Controls.Add(this.button_CurrentSongFile);
            this.groupBox_Files.Location = new System.Drawing.Point(7, 75);
            this.groupBox_Files.Name = "groupBox_Files";
            this.groupBox_Files.Size = new System.Drawing.Size(297, 102);
            this.groupBox_Files.TabIndex = 0;
            this.groupBox_Files.TabStop = false;
            this.groupBox_Files.Text = "File Paths";
            // 
            // textBox_SongListFile
            // 
            this.textBox_SongListFile.Location = new System.Drawing.Point(6, 74);
            this.textBox_SongListFile.Name = "textBox_SongListFile";
            this.textBox_SongListFile.Size = new System.Drawing.Size(240, 20);
            this.textBox_SongListFile.TabIndex = 4;
            // 
            // button_SongListFile
            // 
            this.button_SongListFile.Location = new System.Drawing.Point(252, 73);
            this.button_SongListFile.Name = "button_SongListFile";
            this.button_SongListFile.Size = new System.Drawing.Size(38, 22);
            this.button_SongListFile.TabIndex = 2;
            this.button_SongListFile.Text = "...";
            this.button_SongListFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Currently playing song file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Song list file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 184);
            this.Controls.Add(this.groupBox_Files);
            this.Controls.Add(this.label_TitleName);
            this.Controls.Add(this.label_ProgramStatus);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 115);
            this.Name = "MainForm";
            this.Text = "Spotify Title Grabber";
            this.groupBox_Files.ResumeLayout(false);
            this.groupBox_Files.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_NameRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ProgramStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog_TitleName;
        private System.Windows.Forms.Label label_TitleName;
        private System.Windows.Forms.TextBox textBox_CurrentSongFile;
        private System.Windows.Forms.Button button_CurrentSongFile;
        private System.Windows.Forms.GroupBox groupBox_Files;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SongListFile;
        private System.Windows.Forms.Button button_SongListFile;
    }
}

