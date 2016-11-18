using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    public partial class HighScoreWindow : Form
    {
        public HighScoreWindow()
        {   
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void HighScoreWindow_Load(object sender, EventArgs e)
        {

        }

        private void _backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var a = new MenuWindow()
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
        };
            a.ShowDialog();
            Close();
        }

    }
}
