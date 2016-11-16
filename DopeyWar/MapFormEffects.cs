﻿using System;
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
        private Timer _graphicsTimer;
        private Point[] _missilePath;
        private Point _hittedTarget;
        private int _timerCounter;
        private int _offset;

        private void CreateMissilePath(Nation attacker, Nation defender)
        {
            _offset = (int)(Scaling.FactorX * 12);

            int startX = attacker.PositionX;
            int startY = attacker.PositionY;
            int goalX = defender.PositionX;
            int goalY = defender.PositionY;



            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _hittedTarget = new Point(goalX + rno.Next(-_offset, _offset), goalY + rno.Next(-_offset, _offset));

            Point start = new Point(startX, startY);
            Point mid = CreateRandomMidpoint(start, _hittedTarget, _offset);

            Point p1 = CreateRandomMidpoint(start, mid, _offset / 2);
            Point p2 = CreateRandomMidpoint(mid, _hittedTarget, _offset / 2);

            Point q1 = CreateRandomMidpoint(start, p1, 0);
            Point q2 = CreateRandomMidpoint(p1, mid, 0);
            Point q3 = CreateRandomMidpoint(mid, p2, 0);
            Point q4 = CreateRandomMidpoint(p2, _hittedTarget, 0);


            _missilePath = new Point[] { start, q1, p1, q2, mid, q3, p2, q4, _hittedTarget };

            //_graphicsTimer.Start();
        }

        private Point CreateRandomMidpoint(Point p1, Point p2, int offset)
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
            fg.DrawCurve(new Pen(Color.LightBlue, 3), _missilePath, 0, _timerCounter, 0.5F);
            fg.Dispose();
            
        }

        private void DrawHittedTarget()
        {
            Pen myPen;
            Graphics fg = CreateGraphics();
            fg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!
            myPen = new Pen(Color.OrangeRed, 2);
            fg.DrawEllipse(myPen, _hittedTarget.X - _offset/4, _hittedTarget.Y - _offset / 8, _offset / 2, _offset / 4);
            myPen = new Pen(Color.Yellow, 1);
            fg.DrawEllipse(myPen, _hittedTarget.X - _offset/2, _hittedTarget.Y - _offset / 4, _offset, _offset / 2);
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

        private void _graphics_Tick(object sender, EventArgs e)
        {
            if (_timerCounter < 9)
            {
                DrawMissilePath();
                _timerCounter++;
            }
                
            else
            {
                DrawHittedTarget();
                _graphicsTimer.Stop();
                _timerCounter = 1;
            }
        }
    }
}
