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
            this.yesButton = new System.Windows.Forms.Button();
            this.oKButton = new System.Windows.Forms.Button();
            this.startGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.Enabled = false;
            this.startAndStopButton.Location = new System.Drawing.Point(15, 636);
            this.startAndStopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(205, 58);
            this.startAndStopButton.TabIndex = 0;
            this.startAndStopButton.Text = "Start war";
            this.startAndStopButton.UseVisualStyleBackColor = true;
            this.startAndStopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsListView
            // 
            this.statsListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.statsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.statsListView.Enabled = false;
            this.statsListView.Location = new System.Drawing.Point(16, 206);
            this.statsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(204, 408);
            this.statsListView.TabIndex = 1;
            this.statsListView.UseCompatibleStateImageBehavior = false;
            this.statsListView.View = System.Windows.Forms.View.Details;
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
            this.startGroupBox.Controls.Add(this.oKButton);
            this.startGroupBox.Controls.Add(this.yesButton);
            this.startGroupBox.Location = new System.Drawing.Point(452, 75);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Size = new System.Drawing.Size(527, 367);
            this.startGroupBox.TabIndex = 3;
            this.startGroupBox.TabStop = false;
            this.startGroupBox.Enter += new System.EventHandler(this.startGroupBox_Enter);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.yesButton.Location = new System.Drawing.Point(138, 302);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 35);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // oKButton
            // 
            this.oKButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oKButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.oKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oKButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oKButton.Location = new System.Drawing.Point(311, 302);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(75, 35);
            this.oKButton.TabIndex = 1;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = false;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DopeyWar.Properties.Resources.worldmap;
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
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button oKButton;
    }
}

