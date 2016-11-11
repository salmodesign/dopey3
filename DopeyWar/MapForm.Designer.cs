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
            this.startAndStopButton = new System.Windows.Forms.Button();
            this.statsListView = new System.Windows.Forms.ListView();
            this.warActivityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.Location = new System.Drawing.Point(11, 517);
            this.startAndStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(154, 47);
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
            this.statsListView.Location = new System.Drawing.Point(12, 167);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(154, 332);
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
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DopeyWar.Properties.Resources.worldmap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.warActivityLabel);
            this.Controls.Add(this.startAndStopButton);
            this.Controls.Add(this.statsListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.MapForm_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startAndStopButton;
        private System.Windows.Forms.ListView statsListView;
        private System.Windows.Forms.Label warActivityLabel;
    }
}

