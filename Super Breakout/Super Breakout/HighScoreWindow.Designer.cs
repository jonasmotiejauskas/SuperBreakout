namespace Super_Breakout
{
    partial class HighScoreWindow
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
            this._backButton = new System.Windows.Forms.Button();
            this._mainMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _backButton
            // 
            this._backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._backButton.BackColor = System.Drawing.Color.Transparent;
            this._backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._backButton.Font = new System.Drawing.Font("Power Red and Green", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._backButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._backButton.Location = new System.Drawing.Point(194, 466);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(395, 83);
            this._backButton.TabIndex = 5;
            this._backButton.Text = "Back to Menu";
            this._backButton.UseVisualStyleBackColor = false;
            this._backButton.Click += new System.EventHandler(this._backButton_Click);
            // 
            // _mainMenuLabel
            // 
            this._mainMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._mainMenuLabel.AutoSize = true;
            this._mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this._mainMenuLabel.Font = new System.Drawing.Font("Power Red and Green", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainMenuLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._mainMenuLabel.Location = new System.Drawing.Point(147, 9);
            this._mainMenuLabel.Name = "_mainMenuLabel";
            this._mainMenuLabel.Size = new System.Drawing.Size(525, 116);
            this._mainMenuLabel.TabIndex = 6;
            this._mainMenuLabel.Text = "High Scores";
            this._mainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Super_Breakout.Properties.Resources.breakout_bg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._mainMenuLabel);
            this.Controls.Add(this._backButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HighScoreWindow";
            this.Text = "Super Breakout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Label _mainMenuLabel;
    }
}