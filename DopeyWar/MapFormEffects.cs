using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DopeyWar
{
    public partial class MapForm
    {
        private void DrawMissile(int sX, int sY, int gX, int gY)
        {
            Pen myPen;

            Graphics formGraphics = CreateGraphics();

            int x = sX + (gX - sX) / 2;
            int y = sY + (gY - sY) / 2;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            Point startPoint = new Point(sX, sY);
            Point midPoint = new Point(x - rno.Next(5, 50), y - rno.Next(10, 100));
            Point hittedRandTarget = new Point(gX + rno.Next(-20, 20), gY + rno.Next(-20, 20));
            Point[] points = new Point[3] { startPoint, midPoint, hittedRandTarget };
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!

            myPen = new Pen(Color.OrangeRed, 2);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - 5, hittedRandTarget.Y - 3, 10, 6);
            myPen = new Pen(Color.Yellow, 1);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - 10, hittedRandTarget.Y - 6, 20, 12);

            myPen = new Pen(Color.Red, 3);
            formGraphics.DrawCurve(myPen, points);

            formGraphics.Dispose();
        }
    }
}
