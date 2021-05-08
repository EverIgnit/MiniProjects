using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rayvox
{
    public class Bullet :IEntity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public byte ShooterDamage { get; set; }
        public Vector Dir { get; set; }
        public Bullet(Character c)
        {
            X = Convert.ToInt32(c.X + Settings.PlayerSize / 2);
            Y = Convert.ToInt32(c.Y + Settings.PlayerSize / 2);
            Dir = new Vector();
            if (!Settings.MouseMode)
                Dir.Deg = c.Dir.Deg;
            else
            {
                DirectionToMouse();
            }
            ShooterDamage = c.Dmg;
        }
        public void DirectionToMouse()
        {
            Vector V = new Vector(X, Y, Control.MousePosition.X, Control.MousePosition.Y);
            Dir.Deg = V.Deg;
        }
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Textures.Bullet, new Rectangle(X, Y, Settings.BulletSize, Settings.BulletSize));
        }
        public void Move()
        {
            var a = Tuple.Create(Logic.NewCords(X, Y, Dir.Deg, Settings.BulletSpeed));
            X = a.Item1.Item1;
            Y = a.Item1.Item2;
        }
        public bool Touches(Mob mob)
        {
            return true;
        }
    }
}
