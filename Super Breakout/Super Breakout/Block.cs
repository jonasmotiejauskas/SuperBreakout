using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Breakout
{
    
    class Block : GameObject
    {
        public event EventHandler<CollisionEventArgs> OnCollisionEnter;

        public PictureBox IdleLayer = new PictureBox();

        public Block(Size s, Point p)
        {
            IdleLayer.Size = s;
            IdleLayer.Location = p;
            TextureSize = s;
            TextureLocation = p;
            Texture = new Bitmap(Properties.Resources.Block, TextureSize);
            IdleLayer.BackgroundImage = Texture;
            IdleLayer.BackgroundImageLayout = ImageLayout.Stretch;
            IsActive = true;
            IdleLayer.MouseClick += IdleLayer_MouseClick;
        }

        private void IdleLayer_MouseClick(object sender, MouseEventArgs e)
        {
            (IdleLayer.Parent as GameWindow).GameWindow_MouseClick(sender, e);
        }

        public override void Collided(GameObject collider, Rectangle intersected)
        {
            IsActive = false;
            if (OnCollisionEnter != null) OnCollisionEnter(this, new CollisionEventArgs());
        }
    }
}
