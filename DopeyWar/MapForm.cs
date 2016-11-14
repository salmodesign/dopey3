﻿using System;
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
    public partial class MapForm : Form
    {
        private War _ww3;

        private Size _orgFormSize;

        private Timer _timer;

        private bool _scaleIsSet;
      

        public MapForm()
        {
            InitializeComponent();

            _orgFormSize = new Size(Size.Width, Size.Height); //Store the original form size

            _ww3 = new War();
            statsListView.Columns.Add("Nation");
            statsListView.Columns.Add("Endurance");

            _timer = new Timer();
            _timer.Interval = 1500;
            _timer.Tick += _timer_Tick;

            _scaleIsSet = false;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            StartAndStop();
        }

        public void DisplayWarActivity(Nation attacker, Nation defender)
        {
            ChangeActivityLabel(attacker, defender);

            Pen myPen;
            
            Graphics formGraphics = CreateGraphics();

            int x = attacker.PositionX + (defender.PositionX - attacker.PositionX) / 2;
            int y = attacker.PositionY + (defender.PositionY - attacker.PositionY) / 2;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            Point startPoint = new Point(attacker.PositionX, attacker.PositionY);
            Point midPoint = new Point(x - rno.Next(5,50), y - rno.Next(10,100));
            Point hittedRandTarget = new Point(defender.PositionX + rno.Next(-20, 20), defender.PositionY + rno.Next(-20, 20));
            Point[] points = new Point[3] { startPoint, midPoint, hittedRandTarget};
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Added for extra quality!
            
            myPen = new Pen(Color.OrangeRed, 2);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - 5, hittedRandTarget.Y-3, 10, 6);
            myPen = new Pen(Color.Yellow, 1);
            formGraphics.DrawEllipse(myPen, hittedRandTarget.X - 10, hittedRandTarget.Y - 6, 20, 12);

            myPen = new Pen(Color.LightBlue, 3);
            formGraphics.DrawCurve(myPen, points);

            formGraphics.Dispose();
        }

        public void UpDateList(List<Nation> ListToShow)
        {
            statsListView.Items.Clear();

            foreach (Nation n in ListToShow)
            {
                string [] rowItem = new string[2];
                rowItem[0] = n.ToString();
                rowItem[1] = n.Endurance.ToString();
                statsListView.Items.Add(new ListViewItem(rowItem));
            }
        }
        private void ChangeActivityLabel (Nation attacker, Nation defender)
        {
            warActivityLabel.Text = attacker + " attacks " + defender;
        }

        public void DisplayDefeated(Nation defender)
        {
            Point defenderPoint = new Point(defender.PositionX, defender.PositionY);
            Controls.Add(new Label { Location=defenderPoint, AutoSize=true, BackColor=Color.Black, ForeColor=Color.Red, Text = defender + "\nDEFEATED"});
            warActivityLabel.Text += "\n" + defender + " defeated!";
        }

        private void MapForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            int x = e.X; int y = e.Y;
            MessageBox.Show("x: " + x.ToString() + " " + "y: " + y.ToString());
        }

        public void StartAndStop()
        {
            if (!_scaleIsSet)
            {
                Scaling.ApplyUserScaling(_orgFormSize.Width, Size.Width, _orgFormSize.Height, Size.Height);
                DisableFormResizing();
                _scaleIsSet = true;
            }
            if (_timer.Enabled == false)
            {
                startAndStopButton.Text = "Stop";
                _timer.Start();
            }
            else
            {
                startAndStopButton.Text = "Resume";
                _timer.Stop();
            }                      
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            _ww3.PickNations();
            DisplayWarActivity(_ww3.Attacker, _ww3.Defender);
            _ww3.Defender.MakeDamage();
            UpDateList(_ww3.GetSortedList());

            if (_ww3.Defender.Endurance == 0)
                DisplayDefeated(_ww3.Defender);

            if (_ww3.CheckIfWinner())
            {
                _timer.Stop();
                Nation winner = _ww3.Attacker;
                Point winnerPoint = new Point(winner.PositionX, winner.PositionY);
                Controls.Add(new Label { Location = winnerPoint, AutoSize = true, BackColor = Color.Black, ForeColor = Color.Green, Text = winner + "\nWINNER" });
            }  
        }

        private void DisableFormResizing()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
