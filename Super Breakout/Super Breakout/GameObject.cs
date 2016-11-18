using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    class CollisionEventArgs : EventArgs
    {

    }

    abstract class GameObject
    {
        public bool IsActive { get; set; }
        public Bitmap Texture { get; set; }
        public Size TextureSize { get; set; }
        public Point TextureLocation { get; set; }

        public abstract void Collided(GameObject collider, Rectangle intersected);

        public Rectangle GetRect() => new Rectangle(
            TextureLocation.X,
            TextureLocation.Y,
            TextureSize.Width,
            TextureSize.Height
        );

        public Point GetCenter() => new Point(
            TextureLocation.X + TextureSize.Width / 2,
            TextureLocation.Y + TextureSize.Height / 2
        );
    }
}
