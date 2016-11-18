

using System.Collections.Generic;
using System.Drawing;

namespace Super_Breakout
{
    class CollisionChecker
    {
        private List<GameObject> _all;

        public CollisionChecker(List<GameObject> all)
        {
            _all = all;
        }

        public void CheckCollision()
        {
            foreach(var b in _all)
            {
                if(b is Ball)
                {
                    foreach(var g in _all)
                    {
                        if(b.IsActive && g.IsActive && b != g && b.GetRect().IntersectsWith(g.GetRect()))
                        {
                            Rectangle inter = b.GetRect();
                            inter.Intersect(g.GetRect());
                            b.Collided(g, inter);
                            g.Collided(b, inter);
                            break;
                        }
                    }
                }
            }
        }
    }
}
