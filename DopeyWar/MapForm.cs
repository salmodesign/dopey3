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

        public MapForm()
        {
            InitializeComponent();
            _ww3 = new War();
            statsListView.Columns.Add("Nation");
            statsListView.Columns.Add("Endurance");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nation winner = _ww3.WarStrike(this);
            if (winner != null)
                MessageBox.Show("Winner : " + winner);
            
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
            
        }

    }
}
