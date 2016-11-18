namespace Super_Breakout
{
    partial class MapEditor
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
            this._mapName = new System.Windows.Forms.TextBox();
            this._saveMapButton = new System.Windows.Forms.Button();
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
            // _mapName
            // 
            this._mapName.Location = new System.Drawing.Point(194, 405);
            this._mapName.MaxLength = 25;
            this._mapName.Name = "_mapName";
            this._mapName.Size = new System.Drawing.Size(174, 20);
            this._mapName.TabIndex = 6;
            // 
            // _saveMapButton
            // 
            this._saveMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._saveMapButton.BackColor = System.Drawing.Color.Transparent;
            this._saveMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveMapButton.Font = new System.Drawing.Font("Power Red and Green", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveMapButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this._saveMapButton.Location = new System.Drawing.Point(194, 431);
            this._saveMapButton.Name = "_saveMapButton";
            this._saveMapButton.Size = new System.Drawing.Size(174, 29);
            this._saveMapButton.TabIndex = 7;
            this._saveMapButton.Text = "Save Map";
            this._saveMapButton.UseVisualStyleBackColor = false;
            this._saveMapButton.Click += new System.EventHandler(this._saveMapButton_Click);
            // 
            // _mainMenuLabel
            // 
            this._mainMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._mainMenuLabel.AutoSize = true;
            this._mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this._mainMenuLabel.Font = new System.Drawing.Font("Power Red and Green", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainMenuLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._mainMenuLabel.Location = new System.Drawing.Point(374, 405);
            this._mainMenuLabel.Name = "_mainMenuLabel";
            this._mainMenuLabel.Size = new System.Drawing.Size(259, 45);
            this._mainMenuLabel.TabIndex = 8;
            this._mainMenuLabel.Text = "Enter Map Name";
            this._mainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Super_Breakout.Properties.Resources.breakout_bg;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._mainMenuLabel);
            this.Controls.Add(this._saveMapButton);
            this.Controls.Add(this._mapName);
            this.Controls.Add(this._backButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MapEditor";
            this.Text = "Super Breakout";
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button _backButton;

        #endregion

        private System.Windows.Forms.TextBox _mapName;
        private System.Windows.Forms.Button _saveMapButton;
        private System.Windows.Forms.Label _mainMenuLabel;
    }
}