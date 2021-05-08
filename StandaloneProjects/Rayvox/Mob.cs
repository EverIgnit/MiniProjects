using System.Drawing;
using System.Windows.Forms;

namespace Rayvox
{
    public abstract class Mob : IEntity
    {
        public Mob(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public byte Hp { get; set; }
        public byte Dmg { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Armor { get; set; }
        public bool RecieveDmg(byte Dmg)
        {
            if (Dmg / Armor < Hp && Dmg != 0)
                return true;
            return false;
        }
        // TODO: Реализовать движение моба
        public void Move(int Dir)
        {

        }
        // TODO: Исправить полиморфизм в этом методе:
        public void Draw(PaintEventArgs e) {
            e.Graphics.DrawImage(Textures.Ader, new Rectangle(X, Y, Settings.MobSize, Settings.MobSize));
        }
    }
}
