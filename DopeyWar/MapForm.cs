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

        private SoundPlayer _anthemSound;
      

        public MapForm()
        {
            InitializeComponent();

            _orgFormSize = new Size(Size.Width, Size.Height); //Store the original form size

            _ww3 = new War();
            //statsListView.Columns.Add("Nation", 85);
            //statsListView.Columns.Add("Endurance", 50);

            _timer = new Timer();
            
            _timer.Interval = 200;

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

            DrawMissile(attacker.PositionX, attacker.PositionY, defender.PositionX, defender.PositionY);
        }

        public void UpDateList(List<Nation> ListToShow)
        {
            statsListView.Items.Clear();

            foreach (Nation n in ListToShow)
            {
                string [] rowItem = new string[4];
                rowItem[0] = n.ToString();
                rowItem[1] = n.Endurance.ToString();
                rowItem[2] = n.Shots.ToString();
                rowItem[3] = n.Kills.ToString();
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
            _ww3.CreateAttack();
            DisplayWarActivity(_ww3.Attacker, _ww3.Defender);
            UpDateList(_ww3.GetSortedList());

            if (_ww3.Defender.Endurance == 0)
                DisplayDefeated(_ww3.Defender);

            if (_ww3.CheckIfWinner())
            {
                _timer.Stop();
                startAndStopButton.Text = "Exit Program";
                _programIsfinished = true;
                Nation winner = _ww3.Attacker;
                Point winnerPoint = new Point(winner.PositionX, winner.PositionY);

                Controls.Add(new Label {Location = winnerPoint, AutoSize = true, BackColor = Color.Black, ForeColor = Color.Green, Text = winner + "\nWINNER" });
                
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

                //TO DO check sound and cut in beginings if slow start. 
 
                //pb.Left = (this.ClientSize.Width - pb.Width) / 2;
                //pb.Top = (this.ClientSize.Height - pb.Height) / 2;
     
            }  
        }


        private void startGroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void MapForm_ClientSizeChanged(object sender, EventArgs e)
        {
            startGroupBox.Left = (this.ClientSize.Width - startGroupBox.Width) / 2;
            startGroupBox.Top = (this.ClientSize.Height - startGroupBox.Height) / 2;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            startGroupBox.Visible = false;
            startAndStopButton.Enabled = true;
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            startGroupBox.Visible = false;
            startAndStopButton.Enabled = true;
        }
        private void DisableFormResizing()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        
    }
}
