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
            this.timer_NameRefresh = new System.Windows.Forms.Timer(this.components);
            this.label_Descr1 = new System.Windows.Forms.Label();
            this.label_ProgramStatus = new System.Windows.Forms.Label();
            this.openFileDialog_TitleName = new System.Windows.Forms.OpenFileDialog();
            this.label_TitleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_NameRefresh
            // 
            this.timer_NameRefresh.Enabled = true;
            this.timer_NameRefresh.Interval = 500;
            this.timer_NameRefresh.Tick += new System.EventHandler(this.timer_NameRefresh_Tick);
            // 
            // label_Descr1
            // 
            this.label_Descr1.Location = new System.Drawing.Point(4, 5);
            this.label_Descr1.Name = "label_Descr1";
            this.label_Descr1.Size = new System.Drawing.Size(304, 28);
            this.label_Descr1.TabIndex = 0;
            this.label_Descr1.Text = "This program will read out the title of the currently palying track in Spotify.";
            // 
            // label_ProgramStatus
            // 
            this.label_ProgramStatus.AutoSize = true;
            this.label_ProgramStatus.Location = new System.Drawing.Point(4, 42);
            this.label_ProgramStatus.Name = "label_ProgramStatus";
            this.label_ProgramStatus.Size = new System.Drawing.Size(97, 13);
            this.label_ProgramStatus.TabIndex = 1;
            this.label_ProgramStatus.Text = "Detecting Spotify...";
            // 
            // label_TitleName
            // 
            this.label_TitleName.AutoSize = true;
            this.label_TitleName.Location = new System.Drawing.Point(4, 57);
            this.label_TitleName.Name = "label_TitleName";
            this.label_TitleName.Size = new System.Drawing.Size(102, 13);
            this.label_TitleName.TabIndex = 2;
            this.label_TitleName.Text = "Waiting for Spotify...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 248);
            this.Controls.Add(this.label_TitleName);
            this.Controls.Add(this.label_ProgramStatus);
            this.Controls.Add(this.label_Descr1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spotify Title Grabber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_NameRefresh;
        private System.Windows.Forms.Label label_Descr1;
        private System.Windows.Forms.Label label_ProgramStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog_TitleName;
        private System.Windows.Forms.Label label_TitleName;
    }
}

