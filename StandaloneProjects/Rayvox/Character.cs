using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rayvox
{
    public class Character : IEntity
    {
        public Vector Dir { get; set; }
        public bool CurrentlyAnimating { get; set; }
        public Bitmap CurrentBitmap { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public byte Hp { get; set; }
        public byte Dmg { get; set; }
        public void Draw(PaintEventArgs e)
        {
            Rayvox.AnimateImage(CurrentBitmap, this);
            ImageAnimator.UpdateFrames();
            e.Graphics.DrawImage(CurrentBitmap, new Rectangle(X, Y, Settings.PlayerSize, Settings.PlayerSize));
        }
        public Character(int X, int Y, Bitmap startBitmap)
        {
            Dir = new Vector();
            this.X = X;
            this.Y = Y;
            CurrentBitmap = startBitmap;
            CurrentlyAnimating = false;
        }
        public bool MoveLeft()
        {
            // TODO: Избавиться от заглушки
            if(!Settings.MouseMode)
                Dir.Deg = Math.PI;
            return X > Settings.PlayerSpeed && ChangeX(Settings.PlayerSpeed*(-1));
        }
        public bool MoveRight()
        {
            if (!Settings.MouseMode)
                Dir.Deg = 0;
            return X < Settings.Width - Settings.PlayerSpeed - Settings.PlayerSize / 2 && ChangeX(Settings.PlayerSpeed);
        }
        public bool MoveUp()
        {
            if (!Settings.MouseMode)
                Dir.Deg = Math.PI / 2 * 3;
            return Y - Settings.PlayerSpeed > 0 && ChangeY(-1* Settings.PlayerSpeed);
        }
        public bool MoveDown()
        {
            if (!Settings.MouseMode)
                Dir.Deg = Math.PI / 2;
            return Y < Settings.Height - Settings.PlayerSpeed - Settings.PlayerSize / 2 && ChangeY(Settings.PlayerSpeed);
        }
        public void Shoot()
        {
            Logic.Bullets.Add(new Bullet(this));
        }
        bool ChangeX(int a)
        {
            X += a;
            return true;
        }
        bool ChangeY(int a)
        {
            Y += a;
            return true;
        }
    }
}
