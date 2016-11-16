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

            _hittedTarget = GetHittedRandomTarget(goalX, goalY, offset);

            offset *= (int)(distance * 0.01);       //Offset is now depending on distance and scaling!
            int last = _path.Length - 1;            
            int start = last / 2;                   //Start with index of midpoint between start and goal
            int current = start;                    
            bool allPointsDefined = false;

            _path[0] = new Point(startX, startY);   //Set the starting point (index 0) in array
            _path[last] = _hittedTarget;            //Set the target point (last index) in array

            while (!allPointsDefined)               //Loop sets the rest of the points in array
            {
                //Make the current point to a midpoint between the closest defined points
                _path[current] = GetRandMidpoint(_path[current - start], _path[current + start], offset);

                current = current + 2*start; //Increase current index two times the start value

                if (current >= last)         //If the end of array is reached
                {
                    start = start / 2;       //Set a new starting index
                    current = start;
                    offset = offset / 4;
                }   

                if (start == 0)              //At the end... start = start/2 will give start == 0
                    allPointsDefined = true; //Means all points in array are filled!
            }
        }

        private Point GetHittedRandomTarget(int pX, int pY, int offset)
        {
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            return new Point(pX + rno.Next(-offset, offset), pY + rno.Next(-offset, offset));
        }

        private Point GetRandMidpoint(Point p1, Point p2, int offset)
        {
            int x = p1.X + (p2.X - p1.X) / 2;
            int y = p1.Y + (p2.Y - p1.Y) / 2;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            return new Point(x + rno.Next(-offset, 0), y + rno.Next(-offset, 0));
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
