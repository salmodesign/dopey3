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
    public partial class MapForm : Form
    {
        private War _ww3;

        private Size _orgFormSize;

        private Timer _timer;

        private bool _scaleIsSet;
        

        public MapForm()
        {
            InitializeComponent();
            _ww3 = new War();
            statsListView.Columns.Add("Nation");
            statsListView.Columns.Add("Endurance");

            _orgFormSize = new Size(Size.Width, Size.Height); //Store the original form size

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;

            _scaleIsSet = false;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            StartAndStop();
        }

        public void DrawMissile(Nation attacker, Nation defender)
        {
            Pen myPen;
            myPen = new Pen(Color.LightBlue, 3);
            Graphics formGraphics = this.CreateGraphics();

            int x = attacker.Coordinates.X + (defender.Coordinates.X - attacker.Coordinates.X) / 2;
            int y = attacker.Coordinates.Y + (defender.Coordinates.Y - attacker.Coordinates.Y) / 2;

            Random rno = new Random(Guid.NewGuid().GetHashCode());

            Point midPoint = new Point(x, y - rno.Next(10,100));
            Point hittedRandTarget = new Point(defender.Coordinates.X + rno.Next(-20, 20), defender.Coordinates.Y + rno.Next(-20, 20));
            Point[] points = new Point[3] { attacker.Coordinates, midPoint, hittedRandTarget};
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

        public void DisplayDefeated(Nation defender)
        {
            Controls.Add(new Label { Location=defender.Coordinates, AutoSize=true, BackColor=Color.Black, ForeColor=Color.Red, Text = defender + "\nDEFEATED"}); 

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
                Nation.SetNewScaleFactors(_orgFormSize.Width, Size.Width, _orgFormSize.Height, Size.Height);
                _ww3.AdjustCoordinatesToScale();
                _scaleIsSet = true;
            }

            if (_timer.Enabled == false)
            {
                button1.Text = "Stop";
                _timer.Start();
            }
            else
            {
                button1.Text = "Resume";
                _timer.Stop();
            }                      
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            Nation winner = _ww3.WarStrike(this);
            if (winner != null)
            {
                _timer.Stop();
                Controls.Add(new Label { Location = winner.Coordinates, AutoSize = true, BackColor = Color.Black, ForeColor = Color.Green, Text = winner + "\nWINNER" });
            }
        }
    }
}
