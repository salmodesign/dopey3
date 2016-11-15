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

            int offsetX = (int)(Scaling.FactorX * 60);
            int offsetY = (int)(Scaling.FactorY * 60);

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            Point startPoint = new Point(startX, startY);
            Point midPoint = new Point(x - rno.Next(offsetX/12, offsetX), y - rno.Next(offsetY/6, offsetY));
            Point hittedRandTarget = new Point(goalX + rno.Next(-offsetX/3, offsetX/3), goalY + rno.Next(-offsetY/3, offsetY/3));
            Point[] points = new Point[3] { startPoint, midPoint, hittedRandTarget };
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!

            myPen = new Pen(Color.OrangeRed, 2);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - offsetX/12, hittedRandTarget.Y - offsetY/20, offsetX/6, offsetY/10);
            myPen = new Pen(Color.Yellow, 1);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - offsetX/6, hittedRandTarget.Y - offsetY/10, offsetX/3, offsetY/5);

            myPen = new Pen(Color.LightBlue, 3);
            formGraphics.DrawCurve(myPen, points);

            formGraphics.Dispose();
        }
    }
}
