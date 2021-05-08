using System.Drawing;
using System.Windows.Forms;

namespace Rayvox
{
    public class Ader : Mob, IEntity
    {
        public Ader(int X, int Y) : base(X, Y)
        {
            Hp = 100;
            Armor = 1.0;
            Dmg = 20;
        }
        public new void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Textures.Ader, new Rectangle(X, Y, Settings.MobSize, Settings.MobSize));
        }
    }
}
