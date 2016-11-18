using System.Drawing;
using System.Windows.Forms;

namespace Super_Breakout
{
    class PlayerSlider : GameObject
    {

        public PlayerSlider(Size screenSize)
        {
            TextureSize = new Size(width: screenSize.Height / 6, height: screenSize.Height / 30);
            TextureLocation = new Point(x: screenSize.Width / 2 - screenSize.Width / 16, y: (int)((screenSize.Height - 18) * 0.95));
            Texture = new Bitmap(Properties.Resources.paddle, TextureSize);
            IsActive = true;
        }

        public override void Collided(GameObject collider, Rectangle intersected)
        {
            //throw new NotImplementedException();
        }

    }
}
