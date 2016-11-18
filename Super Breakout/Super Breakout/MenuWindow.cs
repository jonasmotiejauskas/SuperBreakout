using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    public partial class MenuWindow : Form
    {
        private List<LevelInformation> allLevels;

        public MenuWindow()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
            chooseLevel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            allLevels = new List<LevelInformation>();
            string[] names = Directory.GetFiles(@"C:\Users\Vartotojas\Source\BreakoutRepos\SuperBreakout\Super Breakout\Super Breakout\bin\Debug", "*.bin");
            IFormatter formatter = new BinaryFormatter();
            foreach(var n in names)
            {
                Stream stream = new FileStream(n, FileMode.Open, FileAccess.Read, FileShare.Read);
                LevelInformation obj = (LevelInformation)formatter.Deserialize(stream);
                allLevels.Add(obj);
                stream.Close();
            }

            foreach (var a in allLevels)
            {
                chooseLevel.Items.Add(a.LevelName);
            }

            chooseLevel.SelectedItem = "";

        }

        private void _quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _highScoreButton_Click(object sender, EventArgs e)
        {
            Hide();
            var a = new HighScoreWindow() {
                Location = Location
            };
            a.ShowDialog();
            Close();
        }

        private void _playButton_Click(object sender, EventArgs e)
        {
            Hide();
            var a = new GameWindow();
            LevelInformation level;
            foreach (var lvl in allLevels)
            {
                if(lvl.LevelName == (string)chooseLevel.SelectedItem)
                {
                    a.LevelInfo = lvl;
                    break;
                }
            }
            a.ShowDialog();
            Close();
        }

        private void _editorButton_Click(object sender, EventArgs e)
        {
            Hide();
            var a = new MapEditor()
            {
                Location = Location
            };
            a.ShowDialog();
            Close();
        }
    }

    public struct screenResolution
    {
        public int screenResWidth;
        public int screenResHeight;

        public screenResolution(int screenResWidth, int screenResHeight)
        {
            this.screenResHeight = screenResHeight;
            this.screenResWidth = screenResWidth;
        }

        public override string ToString()
        {
            return new StringBuilder().Append(screenResWidth.ToString())
                .Append("x").Append(screenResHeight.ToString()).ToString();
        }
    }

}
