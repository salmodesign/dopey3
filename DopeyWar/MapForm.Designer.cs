namespace DopeyWar
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.startAndStopButton = new System.Windows.Forms.Button();
            this.statsListView = new System.Windows.Forms.ListView();
            this.columnNation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warActivityLabel = new System.Windows.Forms.Label();
            this.startGroupBox = new System.Windows.Forms.GroupBox();
            this.minusButton = new System.Windows.Forms.Button();
            this.showEnduranceLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startAndStopButton.Enabled = false;
            this.startAndStopButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.startAndStopButton.Location = new System.Drawing.Point(11, 538);
            this.startAndStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(236, 36);
            this.startAndStopButton.TabIndex = 0;
            this.startAndStopButton.Text = "Start war";
            this.startAndStopButton.UseVisualStyleBackColor = false;
            this.startAndStopButton.Click += new System.EventHandler(this.startAndStopButton_Click);
            // 
            // statsListView
            // 
            this.statsListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.statsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNation,
            this.columnEndurance,
            this.columnShots,
            this.columnKills});
            this.statsListView.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.statsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.statsListView.Location = new System.Drawing.Point(12, 269);
            this.statsListView.Margin = new System.Windows.Forms.Padding(4);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(235, 264);
            this.statsListView.TabIndex = 1;
            this.statsListView.UseCompatibleStateImageBehavior = false;
            this.statsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnNation
            // 
            this.columnNation.Text = "Nation";
            this.columnNation.Width = 84;
            // 
            // columnEndurance
            // 
            this.columnEndurance.Text = "Endurance";
            this.columnEndurance.Width = 70;
            // 
            // columnShots
            // 
            this.columnShots.Text = "Shots";
            this.columnShots.Width = 40;
            // 
            // columnKills
            // 
            this.columnKills.Text = "Kills";
            this.columnKills.Width = 36;
            // 
            // warActivityLabel
            // 
            this.warActivityLabel.BackColor = System.Drawing.Color.Black;
            this.warActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warActivityLabel.ForeColor = System.Drawing.Color.Red;
            this.warActivityLabel.Location = new System.Drawing.Point(13, 13);
            this.warActivityLabel.Name = "warActivityLabel";
            this.warActivityLabel.Size = new System.Drawing.Size(321, 70);
            this.warActivityLabel.TabIndex = 2;
            this.warActivityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGroupBox
            // 
            this.startGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startGroupBox.BackgroundImage")));
            this.startGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startGroupBox.Controls.Add(this.minusButton);
            this.startGroupBox.Controls.Add(this.showEnduranceLabel);
            this.startGroupBox.Controls.Add(this.EnduranceLabel);
            this.startGroupBox.Controls.Add(this.playButton);
            this.startGroupBox.Controls.Add(this.plusButton);
            this.startGroupBox.Location = new System.Drawing.Point(325, 139);
            this.startGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.startGroupBox.Size = new System.Drawing.Size(395, 298);
            this.startGroupBox.TabIndex = 3;
            this.startGroupBox.TabStop = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minusButton.Location = new System.Drawing.Point(68, 251);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(31, 26);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // showEnduranceLabel
            // 
            this.showEnduranceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showEnduranceLabel.Location = new System.Drawing.Point(95, 257);
            this.showEnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showEnduranceLabel.Name = "showEnduranceLabel";
            this.showEnduranceLabel.Size = new System.Drawing.Size(39, 19);
            this.showEnduranceLabel.TabIndex = 3;
            this.showEnduranceLabel.Text = "3";
            this.showEnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnduranceLabel.Location = new System.Drawing.Point(86, 228);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(62, 19);
            this.EnduranceLabel.TabIndex = 2;
            this.EnduranceLabel.Text = "Endurance:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.playButton.Location = new System.Drawing.Point(314, 249);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(56, 28);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plusButton.Location = new System.Drawing.Point(131, 251);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(33, 26);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(20, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(79, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endurance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(154, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shots";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(200, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kills";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGroupBox);
            this.Controls.Add(this.warActivityLabel);
            this.Controls.Add(this.startAndStopButton);
            this.Controls.Add(this.statsListView);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapForm";
            this.Text = "The Dopey World War";
            this.ResizeEnd += new System.EventHandler(this.MapForm_ResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.MapForm_ClientSizeChanged);
            this.SizeChanged += new System.EventHandler(this.MapForm_SizeChanged);
            this.startGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startAndStopButton;
        private System.Windows.Forms.ListView statsListView;
        private System.Windows.Forms.Label warActivityLabel;
        private System.Windows.Forms.GroupBox startGroupBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ColumnHeader columnNation;
        private System.Windows.Forms.ColumnHeader columnEndurance;
        private System.Windows.Forms.ColumnHeader columnShots;
        private System.Windows.Forms.ColumnHeader columnKills;
        private System.Windows.Forms.Label showEnduranceLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

