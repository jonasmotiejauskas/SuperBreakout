namespace Super_Breakout
{
    partial class MenuWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainMenuLabel = new System.Windows.Forms.Label();
            this._quitButton = new System.Windows.Forms.Button();
            this._editorButton = new System.Windows.Forms.Button();
            this._highScoreButton = new System.Windows.Forms.Button();
            this._playButton = new System.Windows.Forms.Button();
            this.chooseLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _mainMenuLabel
            // 
            this._mainMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._mainMenuLabel.AutoSize = true;
            this._mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this._mainMenuLabel.Font = new System.Drawing.Font("Power Red and Green", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainMenuLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._mainMenuLabel.Location = new System.Drawing.Point(188, 9);
            this._mainMenuLabel.Name = "_mainMenuLabel";
            this._mainMenuLabel.Size = new System.Drawing.Size(427, 116);
            this._mainMenuLabel.TabIndex = 0;
            this._mainMenuLabel.Text = "Main Menu";
            this._mainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _quitButton
            // 
            this._quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._quitButton.BackColor = System.Drawing.Color.Transparent;
            this._quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._quitButton.Font = new System.Drawing.Font("Power Red and Green", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._quitButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._quitButton.Location = new System.Drawing.Point(194, 466);
            this._quitButton.Name = "_quitButton";
            this._quitButton.Size = new System.Drawing.Size(395, 83);
            this._quitButton.TabIndex = 1;
            this._quitButton.Text = "Quit Game";
            this._quitButton.UseVisualStyleBackColor = false;
            this._quitButton.Click += new System.EventHandler(this._quitButton_Click);
            // 
            // _editorButton
            // 
            this._editorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._editorButton.BackColor = System.Drawing.Color.Transparent;
            this._editorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editorButton.Font = new System.Drawing.Font("Power Red and Green", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editorButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._editorButton.Location = new System.Drawing.Point(194, 357);
            this._editorButton.Name = "_editorButton";
            this._editorButton.Size = new System.Drawing.Size(395, 83);
            this._editorButton.TabIndex = 2;
            this._editorButton.Text = "Map Editor";
            this._editorButton.UseVisualStyleBackColor = false;
            this._editorButton.Click += new System.EventHandler(this._editorButton_Click);
            // 
            // _highScoreButton
            // 
            this._highScoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._highScoreButton.BackColor = System.Drawing.Color.Transparent;
            this._highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._highScoreButton.Font = new System.Drawing.Font("Power Red and Green", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._highScoreButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._highScoreButton.Location = new System.Drawing.Point(194, 247);
            this._highScoreButton.Name = "_highScoreButton";
            this._highScoreButton.Size = new System.Drawing.Size(395, 83);
            this._highScoreButton.TabIndex = 3;
            this._highScoreButton.Text = "Highscores";
            this._highScoreButton.UseVisualStyleBackColor = false;
            this._highScoreButton.Click += new System.EventHandler(this._highScoreButton_Click);
            // 
            // _playButton
            // 
            this._playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._playButton.BackColor = System.Drawing.Color.Transparent;
            this._playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._playButton.Font = new System.Drawing.Font("Power Red and Green", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._playButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._playButton.Location = new System.Drawing.Point(194, 128);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(395, 83);
            this._playButton.TabIndex = 4;
            this._playButton.Text = "Play Game";
            this._playButton.UseVisualStyleBackColor = false;
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // chooseLevel
            // 
            this.chooseLevel.FormattingEnabled = true;
            this.chooseLevel.Location = new System.Drawing.Point(614, 156);
            this.chooseLevel.Name = "chooseLevel";
            this.chooseLevel.Size = new System.Drawing.Size(142, 21);
            this.chooseLevel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Power Red and Green", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(595, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Your Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Super_Breakout.Properties.Resources.breakout_bg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseLevel);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this._highScoreButton);
            this.Controls.Add(this._editorButton);
            this.Controls.Add(this._quitButton);
            this.Controls.Add(this._mainMenuLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Breakout";
            this.Load += new System.EventHandler(this.MenuWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _mainMenuLabel;
        private System.Windows.Forms.Button _quitButton;
        private System.Windows.Forms.Button _editorButton;
        private System.Windows.Forms.Button _highScoreButton;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.ComboBox chooseLevel;
        private System.Windows.Forms.Label label1;
    }
}

