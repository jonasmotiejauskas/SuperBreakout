using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    class Ball : GameObject
    {
        public event Action OnCollisionEnter;

        private int _speedX;
        private int _speedY;
        private Size _screenSize;
        public bool IsLaunched { get; set; }

        public Ball(Size screenSize, Point startPos)
        {
            TextureSize = new Size(height: screenSize.Height / 30, width: screenSize.Height / 30);
            TextureLocation = new Point(x: screenSize.Width / 2 - screenSize.Height / 60, y: (int)((screenSize.Height - 18) * 0.95) - screenSize.Height / 30);
            Texture = new Bitmap(Properties.Resources.ball, TextureSize);
            _screenSize = screenSize;

            IsActive = true;
            IsLaunched = false;

            _speedX = screenSize.Width / 200;
            _speedY = -screenSize.Height / 100;

        }

        public void Launch()
        {
            IsLaunched = true;
            Move();
        }

        public new void Move()
        {
            WallCollision();
            TextureLocation = new Point(TextureLocation.X + _speedX, TextureLocation.Y + _speedY);
        }

        public void WallCollision()
        {
            if (TextureLocation.X > _screenSize.Width - TextureSize.Width)
            {
                if (OnCollisionEnter != null) OnCollisionEnter();
                _speedX = -Math.Abs(_speedX);
            }
            if (TextureLocation.X < 0)
            {
                if (OnCollisionEnter != null) OnCollisionEnter();
                _speedX = Math.Abs(_speedX);
            }
                
            if (TextureLocation.Y < 0)
            {
                if (OnCollisionEnter != null) OnCollisionEnter();
                _speedY = Math.Abs(_speedY);
            }
                
            if (TextureLocation.Y > _screenSize.Height - TextureSize.Height)
            {
                if (OnCollisionEnter != null) OnCollisionEnter();
                _speedY = -Math.Abs(_speedY);
            }
                
        }

        public override void Collided(GameObject collider, Rectangle intersected)
        {
            if (OnCollisionEnter != null) OnCollisionEnter();

            if (intersected.Width >= intersected.Height)
            {
                if (GetCenter().Y <= collider.GetCenter().Y)
                    _speedY = -Math.Abs(_speedY);
                if (GetCenter().Y > collider.GetCenter().Y)
                    _speedY = Math.Abs(_speedY);
            }
            if (intersected.Width <= intersected.Height)
            {
                if (GetCenter().X <= collider.GetCenter().X)
                    _speedX = -Math.Abs(_speedX);
                if (GetCenter().X > collider.GetCenter().X)
                    _speedX = Math.Abs(_speedX);
            }

            if (!(collider is PlayerSlider)) return;
            
            if(GetCenter().X < collider.GetCenter().X)
            {
                if(Math.Abs(_speedX) <= 11)
                    _speedX -= 2;
            }
            else
            {
                if (Math.Abs(_speedX) <= 11)
                    _speedX += 2;
            }
        }
    }
}
