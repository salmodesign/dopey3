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
        private bool _scaleIsSet;
        private bool _programIsfinished = false;
        private int _startEndurance;
        private int _timerCounter;

        private War _ww3;
        private Size _orgFormSize;
        private Timer _timer;
        private List <Label> _maplabels;

        private Nation _norge;//for test

        public MapForm()
        {
            InitializeComponent();

            _orgFormSize = new Size(Size.Width, Size.Height); //Store the original form size

            _timer = new Timer();
            _timer.Interval = 60;
            _timer.Tick += _timer_Tick;
            _timerCounter = 0;

            _scaleIsSet = false;
            _startEndurance = 3;

            _path = new Point[33];

            _programIsfinished = false;

            _maplabels = new List <Label>();

   
        }
        #region Events

        private void startAndStopButton_Click(object sender, EventArgs e)
        {
            
            StartAndStop();
        }
        
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_timerCounter == 0)
            {
                _ww3.CreateAttack();
                warActivityLabel.Text = _ww3.Attacker + " attacks " + _ww3.Defender;
                CreateMissilePath(_ww3.Attacker, _ww3.Defender);
                PlayRocketSound();
            }

            if (_timerCounter >= 1 && _timerCounter <= 32)
                DrawMissilePath();
            
            if (_timerCounter == 33)
            {
                PlayBombSound();
                DrawHittedTarget();
                UpDateStatsList(_ww3.GetSortedList());
                if (_ww3.Defender.Endurance == 0)
                    DisplayDefeated(_ww3.Defender);
            }
            _timerCounter++;

            if (_timerCounter > 60)
            {
                if (_ww3.CheckIfWinner())
                {
                    _timer.Stop();
                    startAndStopButton.Text = "Exit Program";
                    _programIsfinished = true;
                    CelebrateWinner(_ww3.Attacker);
                    warActivityLabel.Text = _ww3.Attacker + " WINS!";
                    warActivityLabel.ForeColor = Color.Green;
                }
                _timerCounter = 0;
            }
        }

        private void MapForm_ClientSizeChanged(object sender, EventArgs e)
        {
            startGroupBox.Left = (this.ClientSize.Width - startGroupBox.Width) / 2;
            startGroupBox.Top = (this.ClientSize.Height - startGroupBox.Height) / 2;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _startEndurance++;
            showEnduranceLabel.Text = _startEndurance.ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (_startEndurance > 1)
            {
                _startEndurance--;
                showEnduranceLabel.Text = _startEndurance.ToString();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            startGroupBox.Visible = false;
            startAndStopButton.Enabled = true;
            _ww3 = new War(_startEndurance);  
            UpDateStatsList(_ww3.GetSortedList());

              
            foreach (var item in Scaling.GetInstance().AllScalebleObjects())
                CreateMapLabel(item);
        }
        #endregion Events

        #region Methods
        private void StartAndStop()
        {
            if (!_scaleIsSet)
            {
                Scaling.GetInstance().ApplyUserScaling(_orgFormSize.Width, Size.Width, _orgFormSize.Height, Size.Height);

                foreach (var item in Scaling.GetInstance().AllScalebleObjects())
                    UpdateMapLabel(item);

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
                if (_isRocketSoundActive) 
                    _rocketSound.Stop();
                if(_isBombSoundActive)
                    _bombSound.Stop();
            }
        }

        private void UpDateStatsList(List<Nation> ListToShow)
        {
            statsListView.Items.Clear();

            foreach (Nation n in ListToShow)
            {
                string[] rowItem = new string[4];
                rowItem[0] = n.ToString();
                rowItem[1] = n.Endurance.ToString();
                rowItem[2] = n.Shots.ToString();
                rowItem[3] = n.Kills.ToString();
                var itemToAdd = new ListViewItem(rowItem);

                statsListView.Items.Add(itemToAdd);
            }
        }


        private void CreateMapLabel (IScaleable obj) //for test
        {
            Controls.Add(
                new Label {
                    Name = "MapObj" + obj.ToString(),
                    Location = new Point(obj.PosX, obj.PosY),
                    AutoSize = true,
                    ForeColor = Color.Ivory,
                    BackColor = Color.Transparent,
                    Text = obj.ToString(),
        });
            
        }

        private void UpdateMapLabel (IScaleable obj) //for test
        {
            Control [] MapLabels = Controls.Find("MapObj" + obj.ToString(), true); //BYT TILL NAME?!
            for (int i=0; i < MapLabels.Length; i++)
            {
                MapLabels[i].Location = new Point(obj.PosX, obj.PosY);
            }
        }

        private void DisableFormResizing()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
                
        //protected override void OnMouseDoubleClick(MouseEventArgs e)
        //{
        //    base.OnMouseDoubleClick(e);
        //    int x = e.X; int y = e.Y;
        //    MessageBox.Show("x: " + x.ToString() + " " + "y: " + y.ToString());
        //}
    }
}
#endregion Methods