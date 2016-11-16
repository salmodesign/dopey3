using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DopeyWar
{
    public partial class MapForm
    {
        private Point[] _path;
        private Point _hittedTarget;
        private int _timerCounter;

        private void CreateMissilePath(Nation attacker, Nation defender)
        {
            int startX = attacker.PositionX;
            int startY = attacker.PositionY;
            int goalX = defender.PositionX;
            int goalY = defender.PositionY;

            double distance = Math.Sqrt((Math.Pow(startX - goalX, 2) + Math.Pow(startY - goalY, 2)));

            int offset = (int)(Scaling.FactorX * 12); //Offset is depending on scaling!



            //Pick the target by a random offset:
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _hittedTarget = new Point(goalX + rno.Next(-offset, offset), goalY + rno.Next(-offset, offset));

            offset *= (int)(distance * 0.006); //Offset is now depending on distance and scaling!

            int last = 8; //Index of last element in _path array

            //_path[last] = _hittedTarget;
            //_path[0] = new Point(startX, startY);

            //_path[last/(1*2)] = GetRandMidpoint(_path[0], _path[last], offset); //midpoint

            //_path[last/(1*4)] = GetRandMidpoint(_path[0], _path[last/(1*2)], offset/2); //1/4
            //_path[last/(3*4)] = GetRandMidpoint(_path[last/(1*2)], _path[last], offset/2); //3/4

            //_path[last/(1*8)] = GetRandMidpoint(_path[0], _path[last/(1*4)], offset/4);
            //_path[last/(3*8)] = GetRandMidpoint(_path[last/(1*4)], _path[last/(1*2)], offset/4);
            //_path[last/(5*8)] = GetRandMidpoint(_path[last/(1*2)], _path[last/(3*4)], offset / 4);
            //_path[last/(7*8)] = GetRandMidpoint(_path[last/(3*4)], _path[last], offset / 4);


            //---

            Point start = new Point(startX, startY);
            Point mid = GetRandMidpoint(start, _hittedTarget, offset);

            Point p1 = GetRandMidpoint(start, mid, offset / 2);
            Point p2 = GetRandMidpoint(mid, _hittedTarget, offset / 2);

            Point q1 = GetRandMidpoint(start, p1, 0);
            Point q2 = GetRandMidpoint(p1, mid, 0);
            Point q3 = GetRandMidpoint(mid, p2, 0);
            Point q4 = GetRandMidpoint(p2, _hittedTarget, 0);

            _path = new Point[] { start, q1, p1, q2, mid, q3, p2, q4, _hittedTarget };

        }

        private Point GetRandMidpoint(Point p1, Point p2, int offset)
        {
            int x = p1.X + (p2.X - p1.X) / 2;
            int y = p1.Y + (p2.Y - p1.Y) / 2;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            return new Point(x + rno.Next(-offset, offset), y + rno.Next(-offset, offset));
        }

        private void DrawMissilePath()
        {
            Graphics fg = CreateGraphics();
            fg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!
            fg.DrawCurve(new Pen(Color.LightBlue, 3), _path, 0, _timerCounter, 0.5F);
            fg.Dispose();

        }

        private void DrawHittedTarget()
        {
            int offset = (int)(Scaling.FactorX * 12);
            Pen myPen;
            Graphics fg = CreateGraphics();
            fg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!
            myPen = new Pen(Color.OrangeRed, 2);
            fg.DrawEllipse(myPen, _hittedTarget.X - offset/4, _hittedTarget.Y - offset / 8, offset / 2, offset / 4);
            myPen = new Pen(Color.Yellow, 1);
            fg.DrawEllipse(myPen, _hittedTarget.X - offset/2, _hittedTarget.Y - offset / 4, offset, offset / 2);
            fg.Dispose();
        }

        private void CelebrateWinner(Nation winner)
        {
            Point winnerPoint = new Point(winner.PositionX, winner.PositionY);
            Point labelWinnerPoint = new Point(winner.PositionX, winner.PositionY - 25);

            Controls.Add(new Label { Location = labelWinnerPoint, AutoSize = true, BackColor = Color.Black, ForeColor = Color.Green, Text = winner + "\nWINNER" });

            string name = @"..\..\" + winner.ToString() + ".gif";
            string sound = @"..\..\" + winner.ToString() + ".wav";
            PictureBox pb = new PictureBox()
            {
                Location = winnerPoint,
                Size = new Size(200, 100),
                ImageLocation = name,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(pb);
            pb.BringToFront();
            _anthemSound = new SoundPlayer(sound);
            _anthemSound.Play();
        }
    }
}
