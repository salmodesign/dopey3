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
        private void DrawMissile(int startX, int startY, int goalX, int goalY)
        {
            Pen myPen;

            Graphics formGraphics = CreateGraphics();

            int x = startX + (goalX - startX) / 2;
            int y = startY + (goalY - startY) / 2;

            double fX = Scaling.FactorX;
            double fY = Scaling.FactorY;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            Point startPoint = new Point(startX, startY);
            Point midPoint = new Point(x - rno.Next(5, 50), y - rno.Next(10, 100));

            int xOffset = (int)(60 * Scaling.FactorX);
            int yOffset = (int)(60 * Scaling.FactorY);

            Point hittedRandTarget = new Point(goalX + rno.Next(-xOffset/3, xOffset/3), goalY + rno.Next(-yOffset/3, yOffset/3));

            Point[] points = new Point[3] { startPoint, midPoint, hittedRandTarget };
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!

            myPen = new Pen(Color.OrangeRed, 2);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - xOffset/12, hittedRandTarget.Y - yOffset/20, xOffset/6, yOffset/10);
            myPen = new Pen(Color.Yellow, 1);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - xOffset/6, hittedRandTarget.Y - yOffset/10, xOffset/3, yOffset/5);

            myPen = new Pen(Color.LightBlue, 3);
            formGraphics.DrawCurve(myPen, points);

            formGraphics.Dispose();
        }
    }
}
