using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    public partial class GameWindow : Form
    {
        // GameLoop Related Things
        readonly Stopwatch _stopWatch = Stopwatch.StartNew();
        private Timer timer = new Timer();
        readonly TimeSpan _targetElapsedTime = TimeSpan.FromTicks(TimeSpan.TicksPerSecond / 120);
        readonly TimeSpan _maxElapsedTime = TimeSpan.FromTicks(TimeSpan.TicksPerSecond / 1000);
        TimeSpan _accumulatedTime;
        TimeSpan _lastTime;
        int a;
        
        // GameObject related things
        private List<GameObject> _allObjects;
        private PlayerSlider _player;
        private Ball _ball;
        private List<Block> _blocks;
        private CollisionChecker _cc;
        internal LevelInformation LevelInfo { get; set; }

        public GameWindow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
            Cursor.Hide();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            StartNewLevel();
        }

        public void StartNewLevel()
        {
            _allObjects = new List<GameObject>();
            _player = new PlayerSlider(this.Size);
            _ball = new Ball(this.Size, _player.TextureLocation);
            BuildBlocks();
            foreach (var b in _blocks)
            {
                _allObjects.Add(b);
                b.OnCollisionEnter += _block_OnCollisionEnter;
                Controls.Add(b.IdleLayer);
            }
            _allObjects.Add(_player);
            _allObjects.Add(_ball);
            _cc = new CollisionChecker(_allObjects);

            _ball.OnCollisionEnter += _ball_OnCollisionEnter;

            timer.Interval = (int)_targetElapsedTime.TotalMilliseconds;
            timer.Tick += Tick;
            timer.Start();

            // Crashina
            /*new Task(() => {
                Stream str = Properties.Resources.BackgroundMusic;
                SoundPlayer snd = new SoundPlayer(str);
                snd.PlayLooping();
            }).Start();*/
        }

        private void _ball_OnCollisionEnter()
        {
            /*new Task(() => {
                Console.Beep(500, 25);
            }).Start();*/
        }

        private void _block_OnCollisionEnter(object sender, CollisionEventArgs e)
        {
            bool isEmpty = true;
            foreach (var b in _blocks)
            {
                if (b.IsActive)
                    isEmpty = false;
            }
            if (isEmpty)
                GameOver();
            if(Controls.Contains((sender as Block).IdleLayer))
                Controls.Remove((sender as Block).IdleLayer);
        }

        void TickWhileIdle(object sender, EventArgs e)
        {
            NativeMethods.Message message;

            while (!NativeMethods.PeekMessage(out message, IntPtr.Zero, 0, 0, 0))
            {
                Tick(sender, e);
            }
        }

        static class NativeMethods
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Message
            {
                public IntPtr hWnd;
                public uint Msg;
                public IntPtr wParam;
                public IntPtr lParam;
                public uint Time;
                public Point Point;
            }

            [DllImport("User32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PeekMessage(out Message message, IntPtr hWnd, uint filterMin, uint filterMax, uint flags);
        }

        void Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = _stopWatch.Elapsed;
            TimeSpan elapsedTime = currentTime - _lastTime;
            _lastTime = currentTime;

            if (elapsedTime > _maxElapsedTime)
            {
                elapsedTime = _maxElapsedTime;
            }

            _accumulatedTime += elapsedTime;

            GameLogic();
            Invalidate();

            while (_accumulatedTime >= _targetElapsedTime)
            {
                _accumulatedTime -= _targetElapsedTime;
            }
        }

        private void GameLogic()
        {
            if (Cursor.Position.X < Width - _player.TextureSize.Width)
            {
                _player.TextureLocation = new Point(Cursor.Position.X, _player.TextureLocation.Y);
            }
            else
            {
                _player.TextureLocation = new Point(Width - _player.TextureSize.Width, _player.TextureLocation.Y);
            }
            if (!_ball.IsLaunched)
            {
                _ball.TextureLocation = new Point(_player.TextureLocation.X + (_player.TextureSize.Width / 2) - _ball.TextureSize.Width / 2, _ball.TextureLocation.Y);
            }
            else
            {
                _cc.CheckCollision();
                _ball.Move();
            }
        }

        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            if (_player.IsActive)
                e.Graphics.DrawImage(_player.Texture, _player.TextureLocation);
            if (_ball.IsActive)
                e.Graphics.DrawImage(_ball.Texture, _ball.TextureLocation);
        }

        private void BuildBlocks()
        {
            _blocks = new List<Block>();
            for(int i = 0; i < 15; i++ )
                for(int j = 0; j < 10; j++ )
                {
                    if (LevelInfo.BlockInfo[i, j] != 0)
                    {
                        _blocks.Add(new Block(new Size((Size.Width - 100) / 15, (Size.Height / 2) / 10), new Point(50 + i * ((Size.Width - 100) / 15), 50 + j * ((Size.Height / 2) / 10))));
                    }
                }
        }

        internal void GameWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_ball.IsLaunched)
            {
                _ball.Launch();
            }
        }

        public void GameOver()
        {
            /*Hide();
            var a = new MenuWindow();
            a.ShowDialog();
            Dispose();
            Close();*/
        }
    }
}
