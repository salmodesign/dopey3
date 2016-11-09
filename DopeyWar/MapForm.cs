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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ww3.WarStrike(this);
            
        }

        public void DrawMissile(Nation attacker, Nation defender)
        {

        }

        public void UpDateList(List<Nation> ListToShow)
        {
            nationsListBox.Items.Clear();
            foreach (Nation n in ListToShow)
            {
                nationsListBox.Items.Add(n + "\t\t" + n.Endurance.ToString());
            }
        }

        public void DisplayDefeated(Nation defender)
        {

        }
    }
}
