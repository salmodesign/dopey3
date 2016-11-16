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
    public partial class MapForm : Form
    {
        private War _ww3;

        private Size _orgFormSize;

        private Timer _timer;

        private bool _scaleIsSet;

        private bool _programIsfinished = false;

        private int _endurance = 3;

        private SoundPlayer _anthemSound;
      

        public MapForm()
        {
            InitializeComponent();

            _orgFormSize = new Size(Size.Width, Size.Height); //Store the original form size

            _timer = new Timer();
            _timer.Interval = 140;
            _timer.Tick += _timer_Tick;

            _scaleIsSet = false;

            _path = new Point[9];
            _timerCounter = 0;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            StartAndStop();
        }

        public void UpDateStatsList(List<Nation> ListToShow)
        {
            statsListView.Items.Clear();

            foreach (Nation n in ListToShow)
            {
                string [] rowItem = new string[4];
                rowItem[0] = n.ToString();
                rowItem[1] = n.Endurance.ToString();
                rowItem[2] = n.Shots.ToString();
                rowItem[3] = n.Kills.ToString();
                var itemToAdd = new ListViewItem(rowItem);

                statsListView.Items.Add(itemToAdd);
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
                if (_programIsfinished)
                    Application.Exit();
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
            if (_timerCounter == 0)
            {
                _ww3.CreateAttack();
                warActivityLabel.Text = _ww3.Attacker + " attacks " + _ww3.Defender;
                CreateMissilePath(_ww3.Attacker, _ww3.Defender);
            }
                
            if (_timerCounter >= 1 && _timerCounter <= 8)
            {
                DrawMissilePath();
            }
            if (_timerCounter == 9)
            {
                //BackgroundImage = Properties.Resources.worldmap_light;
                DrawHittedTarget();
                UpDateStatsList(_ww3.GetSortedList());

                if (_ww3.Defender.Endurance == 0)
                    DisplayDefeated(_ww3.Defender);

                if (_ww3.CheckIfWinner())
                {
                    _timer.Stop();
                    startAndStopButton.Text = "Exit Program";
                    _programIsfinished = true;
                    CelebrateWinner(_ww3.Attacker);
                }
            }

            _timerCounter++;
            if (_timerCounter > 18)
                _timerCounter = 0;
        }


        private void startGroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void MapForm_ClientSizeChanged(object sender, EventArgs e)
        {
            startGroupBox.Left = (this.ClientSize.Width - startGroupBox.Width) / 2;
            startGroupBox.Top = (this.ClientSize.Height - startGroupBox.Height) / 2;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _endurance++;
            showEnduranceLabel.Text = _endurance.ToString();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            startGroupBox.Visible = false;
            startAndStopButton.Enabled = true;

            _ww3 = new War(_endurance);
            UpDateStatsList(_ww3.GetSortedList());
        }
        private void DisableFormResizing()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (_endurance > 1)
            {
                _endurance--;
                showEnduranceLabel.Text = _endurance.ToString();
            }
        }

        private void statsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }
    }
}
