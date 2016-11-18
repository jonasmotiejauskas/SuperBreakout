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
using System.Xml;

namespace Super_Breakout
{
    public partial class MapEditor : Form
    {
        private Button[,] Buttons;
        private int[,] _locations;
        private LevelInformation _levelInf;

        public MapEditor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MapEditor_Load(object sender, EventArgs e)
        {
            Buttons = new Button[15, 10];
            _locations = new int[15, 10];
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 10; j++)
                {
                    Buttons[i, j] = new Button
                    {
                        Size = new Size((Size.Width - 100) / 15, (Size.Height / 2) / 10),
                        Location = new Point(50 + i * ((Size.Width - 100) / 15), 50 + j * ((Size.Height / 2) / 10)),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        TabStop = false,
                        FlatStyle = FlatStyle.Flat
                    };
                    Controls.Add(Buttons[i, j]);
                    Buttons[i, j].Click += Button_Click;
                }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackgroundImage == null)
                (sender as Button).BackgroundImage = new Bitmap(Properties.Resources.Block);
            else
                (sender as Button).BackgroundImage = null;
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

        private void _saveMapButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (Buttons[i, j].BackgroundImage != null)
                    {
                        _locations[i, j] = 1;
                    }
                }
            _levelInf = new LevelInformation()
            {
                LevelName = _mapName.Text,
                BlockInfo = _locations
            };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_levelInf.LevelName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, _levelInf);
            stream.Close();
        }
    }
}
