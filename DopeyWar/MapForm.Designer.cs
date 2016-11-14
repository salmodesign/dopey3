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
            this.warActivityLabel = new System.Windows.Forms.Label();
            this.startGroupBox = new System.Windows.Forms.GroupBox();
            this.oKButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.columnNation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.Enabled = false;
            this.startAndStopButton.Location = new System.Drawing.Point(11, 538);
            this.startAndStopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(236, 36);
            this.startAndStopButton.TabIndex = 0;
            this.startAndStopButton.Text = "Start war";
            this.startAndStopButton.UseVisualStyleBackColor = true;
            this.startAndStopButton.Click += new System.EventHandler(this.button1_Click);
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
            this.statsListView.Enabled = false;
            this.statsListView.Location = new System.Drawing.Point(12, 269);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(235, 264);
            this.statsListView.TabIndex = 1;
            this.statsListView.UseCompatibleStateImageBehavior = false;
            this.statsListView.View = System.Windows.Forms.View.Details;
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
            this.startGroupBox.Controls.Add(this.oKButton);
            this.startGroupBox.Controls.Add(this.yesButton);
            this.startGroupBox.Location = new System.Drawing.Point(339, 61);
            this.startGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startGroupBox.Size = new System.Drawing.Size(395, 298);
            this.startGroupBox.TabIndex = 3;
            this.startGroupBox.TabStop = false;
            this.startGroupBox.Enter += new System.EventHandler(this.startGroupBox_Enter);
            // 
            // oKButton
            // 
            this.oKButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oKButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.oKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oKButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oKButton.Location = new System.Drawing.Point(233, 245);
            this.oKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(56, 28);
            this.oKButton.TabIndex = 1;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = false;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yesButton.Location = new System.Drawing.Point(104, 245);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(56, 28);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
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
            // columnKills
            // 
            this.columnKills.Text = "Kills";
            this.columnKills.Width = 36;
            // 
            // columnShots
            // 
            this.columnShots.Text = "Shots";
            this.columnShots.Width = 40;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.startGroupBox);
            this.Controls.Add(this.warActivityLabel);
            this.Controls.Add(this.startAndStopButton);
            this.Controls.Add(this.statsListView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.MapForm_ResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.MapForm_ClientSizeChanged);
            this.startGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startAndStopButton;
        private System.Windows.Forms.ListView statsListView;
        private System.Windows.Forms.Label warActivityLabel;
        private System.Windows.Forms.GroupBox startGroupBox;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.ColumnHeader columnNation;
        private System.Windows.Forms.ColumnHeader columnEndurance;
        private System.Windows.Forms.ColumnHeader columnShots;
        private System.Windows.Forms.ColumnHeader columnKills;
    }
}

