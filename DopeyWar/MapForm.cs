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

        private FormWindowState _lastWindowState; //Used only to determine when form is being maximized

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
        
        /// <summary>
        /// Main timer event, uses a counter to perform tasks in the right 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_timerCounter == 0)
            {
                _ww3.CreateAttack();
                warActivityLabel.Text = _ww3.Attacker + " attacks " + _ww3.Defender;
                CreateMissilePath(_ww3.Attacker, _ww3.Defender); //The path is created...
                PlayRocketSound();
            }

            if (_timerCounter >= 1 && _timerCounter <= 32)
                DrawMissilePath();                              //..and drawn step by step
            
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
            if (startGroupBox.Visible == true)
            {
                startGroupBox.Left = (this.ClientSize.Width - startGroupBox.Width) / 2;
                startGroupBox.Top = (this.ClientSize.Height - startGroupBox.Height) / 2;
            }
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
            FormResizeAllowed(true);

            _ww3 = new War(_startEndurance);
            UpDateStatsList(_ww3.GetSortedList());
              
            foreach (var item in Scaling.GetInstance().AllScalebleObjects())
                CreateMapLabel(item);

            UpdateAllMapLabels(); 
        }

        private void MapForm_ResizeEnd(object sender, EventArgs e)
        {
            UpdateAllMapLabels();
        }

        private void MapForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != _lastWindowState) // When window state changes (ex. maiximized)
            {
                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    UpdateAllMapLabels();
                }
                _lastWindowState = WindowState;
            }
        }

        private void mapLabelsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAllMapLabels();
        }
        #endregion Events

        #region Methods
        private void StartAndStop()
        {
            if (!_scaleIsSet)
            {
                mapLabelsCheckBox.Checked = false;
                mapLabelsCheckBox.Enabled = false;
                UpdateAllMapLabels();
                FormResizeAllowed(false);
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
                    Name = "MapObj" + obj.Name,
                    AutoSize = true,
                    Location = new Point(obj.PosX, obj.PosY),
                    ForeColor = Color.Ivory,
                    BackColor = Color.Transparent,
                    Text = obj.Name,
            });    
        }

        private void UpdateAllMapLabels()
        {
            Scaling.GetInstance().ApplyUserScaling(_orgFormSize.Width, Size.Width, _orgFormSize.Height, Size.Height);

            foreach (var item in Scaling.GetInstance().AllScalebleObjects())
                UpdateMapLabel(item);
        }

        private void UpdateMapLabel (IScaleable obj)
        {
            Control [] MapLabels = Controls.Find("MapObj" + obj.Name, true);
            for (int i=0; i < MapLabels.Length; i++)
            {
                MapLabels[i].Location = new Point(obj.PosX, obj.PosY);
                if (mapLabelsCheckBox.Checked == true)
                    MapLabels[i].Visible = true;
                else
                    MapLabels[i].Visible = false;
            }
        }

        private void FormResizeAllowed(bool isAllowed)
        {
            if (isAllowed)
            {
                MaximizeBox = true;
                MinimizeBox = true;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                MaximizeBox = false;
                MinimizeBox = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }
    }
}
#endregion Methods