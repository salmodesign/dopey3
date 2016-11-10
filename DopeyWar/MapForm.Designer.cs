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
            this.button1 = new System.Windows.Forms.Button();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.statsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 517);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start war";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mapPanel
            // 
            this.mapPanel.BackgroundImage = global::DopeyWar.Properties.Resources.worldmap;
            this.mapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapPanel.Location = new System.Drawing.Point(771, 485);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(160, 79);
            this.mapPanel.TabIndex = 1;
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
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DopeyWar.Properties.Resources.worldmap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.statsListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.ListView statsListView;
    }
}

