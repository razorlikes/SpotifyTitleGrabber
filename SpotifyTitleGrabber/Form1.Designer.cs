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
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbxCurrentSongFile = new System.Windows.Forms.TextBox();
            this.btnCurrentSongFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSongListFile = new System.Windows.Forms.TextBox();
            this.btnSongListFile = new System.Windows.Forms.Button();
            this.saveCurrentFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveListFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxTitleFormatNoRemix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTitleFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(353, 28);
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
            this.lblTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleName.AutoEllipsis = true;
            this.lblTitleName.Location = new System.Drawing.Point(4, 54);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(353, 13);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Waiting for Spotify...";
            // 
            // tbxCurrentSongFile
            // 
            this.tbxCurrentSongFile.Location = new System.Drawing.Point(6, 34);
            this.tbxCurrentSongFile.Name = "tbxCurrentSongFile";
            this.tbxCurrentSongFile.Size = new System.Drawing.Size(291, 20);
            this.tbxCurrentSongFile.TabIndex = 3;
            // 
            // btnCurrentSongFile
            // 
            this.btnCurrentSongFile.Location = new System.Drawing.Point(302, 33);
            this.btnCurrentSongFile.Name = "btnCurrentSongFile";
            this.btnCurrentSongFile.Size = new System.Drawing.Size(39, 22);
            this.btnCurrentSongFile.TabIndex = 1;
            this.btnCurrentSongFile.Text = "...";
            this.btnCurrentSongFile.UseVisualStyleBackColor = true;
            this.btnCurrentSongFile.Click += new System.EventHandler(this.btnCurrentSongFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSongListFile);
            this.groupBox1.Controls.Add(this.btnSongListFile);
            this.groupBox1.Controls.Add(this.tbxCurrentSongFile);
            this.groupBox1.Controls.Add(this.btnCurrentSongFile);
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Paths";
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
            this.tbxSongListFile.Size = new System.Drawing.Size(291, 20);
            this.tbxSongListFile.TabIndex = 4;
            // 
            // btnSongListFile
            // 
            this.btnSongListFile.Location = new System.Drawing.Point(302, 73);
            this.btnSongListFile.Name = "btnSongListFile";
            this.btnSongListFile.Size = new System.Drawing.Size(39, 22);
            this.btnSongListFile.TabIndex = 2;
            this.btnSongListFile.Text = "...";
            this.btnSongListFile.UseVisualStyleBackColor = true;
            this.btnSongListFile.Click += new System.EventHandler(this.btnSongListFile_Click);
            // 
            // saveCurrentFileDialog
            // 
            this.saveCurrentFileDialog.FileName = "CurrentSong.txt";
            this.saveCurrentFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveCurrentFileDialog.OverwritePrompt = false;
            // 
            // saveListFileDialog
            // 
            this.saveListFileDialog.FileName = "SongList.txt";
            this.saveListFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxTitleFormatNoRemix);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxTitleFormat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // tbxTitleFormatNoRemix
            // 
            this.tbxTitleFormatNoRemix.Location = new System.Drawing.Point(116, 42);
            this.tbxTitleFormatNoRemix.Name = "tbxTitleFormatNoRemix";
            this.tbxTitleFormatNoRemix.Size = new System.Drawing.Size(225, 20);
            this.tbxTitleFormatNoRemix.TabIndex = 5;
            this.tbxTitleFormatNoRemix.Text = "%a - %t";
            this.tbxTitleFormatNoRemix.Validated += new System.EventHandler(this.tbxTitleFormatNoRemix_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Title format no remix:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "PLEASE NOTE: This works with the naming scheme Spotify uses for their titles. It " +
    "may not work with files you import to your playlists!";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "%a = Album name;  %t = Title name;  %r = Remix (if available)";
            // 
            // tbxTitleFormat
            // 
            this.tbxTitleFormat.Location = new System.Drawing.Point(116, 15);
            this.tbxTitleFormat.Name = "tbxTitleFormat";
            this.tbxTitleFormat.Size = new System.Drawing.Size(225, 20);
            this.tbxTitleFormat.TabIndex = 1;
            this.tbxTitleFormat.Text = "%a - %t - %r";
            this.tbxTitleFormat.Validated += new System.EventHandler(this.tbxTitleFormat_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title format:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.lblProgramStatus);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spotify Title Grabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrNameRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgramStatus;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TextBox tbxCurrentSongFile;
        private System.Windows.Forms.Button btnCurrentSongFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSongListFile;
        private System.Windows.Forms.Button btnSongListFile;
        private System.Windows.Forms.SaveFileDialog saveCurrentFileDialog;
        private System.Windows.Forms.SaveFileDialog saveListFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxTitleFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTitleFormatNoRemix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

