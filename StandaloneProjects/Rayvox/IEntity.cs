using System.Windows.Forms;

namespace Rayvox
{
    interface IEntity
    {
        int X { get; set; }
        int Y { get; set; }
        void Draw(PaintEventArgs e);
    }
}
