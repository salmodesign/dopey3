﻿namespace DopeyWar
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
            this.oKButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.startGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.Enabled = false;
            this.startAndStopButton.Location = new System.Drawing.Point(15, 662);
            this.startAndStopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(315, 44);
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
            this.statsListView.Location = new System.Drawing.Point(16, 331);
            this.statsListView.Margin = new System.Windows.Forms.Padding(5);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(312, 324);
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
            this.warActivityLabel.Location = new System.Drawing.Point(17, 16);
            this.warActivityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warActivityLabel.Name = "warActivityLabel";
            this.warActivityLabel.Size = new System.Drawing.Size(428, 86);
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
            this.startGroupBox.Controls.Add(this.oKButton);
            this.startGroupBox.Controls.Add(this.plusButton);
            this.startGroupBox.Location = new System.Drawing.Point(452, 75);
            this.startGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGroupBox.Size = new System.Drawing.Size(527, 367);
            this.startGroupBox.TabIndex = 3;
            this.startGroupBox.TabStop = false;
            this.startGroupBox.Enter += new System.EventHandler(this.startGroupBox_Enter);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minusButton.Location = new System.Drawing.Point(90, 309);
            this.minusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(41, 32);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // showEnduranceLabel
            // 
            this.showEnduranceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showEnduranceLabel.Location = new System.Drawing.Point(127, 316);
            this.showEnduranceLabel.Name = "showEnduranceLabel";
            this.showEnduranceLabel.Size = new System.Drawing.Size(52, 23);
            this.showEnduranceLabel.TabIndex = 3;
            this.showEnduranceLabel.Text = "3";
            this.showEnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnduranceLabel.Location = new System.Drawing.Point(114, 280);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(83, 23);
            this.EnduranceLabel.TabIndex = 2;
            this.EnduranceLabel.Text = "Endurance:";
            // 
            // oKButton
            // 
            this.oKButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oKButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.oKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oKButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oKButton.Location = new System.Drawing.Point(419, 307);
            this.oKButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(75, 34);
            this.oKButton.TabIndex = 1;
            this.oKButton.Text = "PLAY";
            this.oKButton.UseVisualStyleBackColor = false;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plusButton.Location = new System.Drawing.Point(175, 309);
            this.plusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(44, 32);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 720);
            this.Controls.Add(this.startGroupBox);
            this.Controls.Add(this.warActivityLabel);
            this.Controls.Add(this.startAndStopButton);
            this.Controls.Add(this.statsListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.ColumnHeader columnNation;
        private System.Windows.Forms.ColumnHeader columnEndurance;
        private System.Windows.Forms.ColumnHeader columnShots;
        private System.Windows.Forms.ColumnHeader columnKills;
        private System.Windows.Forms.Label showEnduranceLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Button minusButton;
    }
}

