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
            this.tmrNameRefresh = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgramStatus = new System.Windows.Forms.Label();
            this.openFileDialog_TitleName = new System.Windows.Forms.OpenFileDialog();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbxCurrentSongFile = new System.Windows.Forms.TextBox();
            this.btnCurrentSongFile = new System.Windows.Forms.Button();
            this.groupBox_Files = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSongListFile = new System.Windows.Forms.TextBox();
            this.btnSongListFile = new System.Windows.Forms.Button();
            this.groupBox_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrNameRefresh
            // 
            this.tmrNameRefresh.Enabled = true;
            this.tmrNameRefresh.Interval = 500;
            this.tmrNameRefresh.Tick += new System.EventHandler(this.tmrNameRefresh_Tick);
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
            // lblProgramStatus
            // 
            this.lblProgramStatus.AutoSize = true;
            this.lblProgramStatus.Location = new System.Drawing.Point(4, 39);
            this.lblProgramStatus.Name = "lblProgramStatus";
            this.lblProgramStatus.Size = new System.Drawing.Size(97, 13);
            this.lblProgramStatus.TabIndex = 0;
            this.lblProgramStatus.Text = "Detecting Spotify...";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(4, 54);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(102, 13);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Waiting for Spotify...";
            // 
            // tbxCurrentSongFile
            // 
            this.tbxCurrentSongFile.Location = new System.Drawing.Point(6, 34);
            this.tbxCurrentSongFile.Name = "tbxCurrentSongFile";
            this.tbxCurrentSongFile.Size = new System.Drawing.Size(240, 20);
            this.tbxCurrentSongFile.TabIndex = 3;
            // 
            // btnCurrentSongFile
            // 
            this.btnCurrentSongFile.Location = new System.Drawing.Point(252, 33);
            this.btnCurrentSongFile.Name = "btnCurrentSongFile";
            this.btnCurrentSongFile.Size = new System.Drawing.Size(39, 22);
            this.btnCurrentSongFile.TabIndex = 1;
            this.btnCurrentSongFile.Text = "...";
            this.btnCurrentSongFile.UseVisualStyleBackColor = true;
            // 
            // groupBox_Files
            // 
            this.groupBox_Files.Controls.Add(this.label3);
            this.groupBox_Files.Controls.Add(this.label2);
            this.groupBox_Files.Controls.Add(this.tbxSongListFile);
            this.groupBox_Files.Controls.Add(this.btnSongListFile);
            this.groupBox_Files.Controls.Add(this.tbxCurrentSongFile);
            this.groupBox_Files.Controls.Add(this.btnCurrentSongFile);
            this.groupBox_Files.Location = new System.Drawing.Point(7, 75);
            this.groupBox_Files.Name = "groupBox_Files";
            this.groupBox_Files.Size = new System.Drawing.Size(297, 102);
            this.groupBox_Files.TabIndex = 0;
            this.groupBox_Files.TabStop = false;
            this.groupBox_Files.Text = "File Paths";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Currently playing song file";
            // 
            // tbxSongListFile
            // 
            this.tbxSongListFile.Location = new System.Drawing.Point(6, 74);
            this.tbxSongListFile.Name = "tbxSongListFile";
            this.tbxSongListFile.Size = new System.Drawing.Size(240, 20);
            this.tbxSongListFile.TabIndex = 4;
            // 
            // btnSongListFile
            // 
            this.btnSongListFile.Location = new System.Drawing.Point(252, 73);
            this.btnSongListFile.Name = "btnSongListFile";
            this.btnSongListFile.Size = new System.Drawing.Size(38, 22);
            this.btnSongListFile.TabIndex = 2;
            this.btnSongListFile.Text = "...";
            this.btnSongListFile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 184);
            this.Controls.Add(this.groupBox_Files);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.lblProgramStatus);
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

        private System.Windows.Forms.Timer tmrNameRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgramStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog_TitleName;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TextBox tbxCurrentSongFile;
        private System.Windows.Forms.Button btnCurrentSongFile;
        private System.Windows.Forms.GroupBox groupBox_Files;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSongListFile;
        private System.Windows.Forms.Button btnSongListFile;
    }
}

