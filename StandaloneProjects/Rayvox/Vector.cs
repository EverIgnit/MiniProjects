using System;
using System.Windows.Forms;

namespace Rayvox
{
    public class Vector
    {
        int A, B;
        public double Deg { get; set; }
        public Vector()
        {

        }
        public Vector(int X1, int Y1, int X2, int Y2)
        {
            A = X2 - X1;
            B = Y2 - Y1;
            DegWith(X1, Y1, X1, Settings.Width);
        }
        public void DegWith(int X1, int Y1, int X2, int Y2)
        {
            int A1 = X2 - X1;
            int B1 = Y2 - Y1;
            double value = (A * A1 + B * B1) / (Math.Sqrt(A * A + B1 * B1) * Math.Sqrt(A * A + A1 * A1));
            Deg = Math.Acos(value);
        }
    }
}
