namespace CpuLoadApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkIndefinite;


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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCpuLoad = new System.Windows.Forms.Label();
            this.numLoadPercentage = new System.Windows.Forms.NumericUpDown();
            this.numDurationSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.chkIndefinite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartStop.Location = new System.Drawing.Point(12, 30);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(122, 51);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start Load";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.SystemColors.Info;
            this.lblTemp.Location = new System.Drawing.Point(170, 43);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(85, 13);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "CPU Temp: -- °C";
            // 
            // lblCpuLoad
            // 
            this.lblCpuLoad.AutoSize = true;
            this.lblCpuLoad.BackColor = System.Drawing.SystemColors.Info;
            this.lblCpuLoad.Location = new System.Drawing.Point(170, 68);
            this.lblCpuLoad.Name = "lblCpuLoad";
            this.lblCpuLoad.Size = new System.Drawing.Size(79, 13);
            this.lblCpuLoad.TabIndex = 2;
            this.lblCpuLoad.Text = "CPU Load: -- %";
            // 
            // numLoadPercentage
            // 
            this.numLoadPercentage.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLoadPercentage.Location = new System.Drawing.Point(170, 90);
            this.numLoadPercentage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLoadPercentage.Name = "numLoadPercentage";
            this.numLoadPercentage.Size = new System.Drawing.Size(60, 20);
            this.numLoadPercentage.TabIndex = 3;
            this.numLoadPercentage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numDurationSeconds
            // 
            this.numDurationSeconds.Location = new System.Drawing.Point(170, 120);
            this.numDurationSeconds.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numDurationSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDurationSeconds.Name = "numDurationSeconds";
            this.numDurationSeconds.Size = new System.Drawing.Size(60, 20);
            this.numDurationSeconds.TabIndex = 4;
            this.numDurationSeconds.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(236, 92);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(45, 13);
            this.lblLoad.TabIndex = 5;
            this.lblLoad.Text = "Load %:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(236, 122);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(64, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration (s):";
            // 
            // chkIndefinite
            // 
            this.chkIndefinite.AutoSize = true;
            this.chkIndefinite.Checked = true;
            this.chkIndefinite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndefinite.Location = new System.Drawing.Point(170, 159);
            this.chkIndefinite.Name = "chkIndefinite";
            this.chkIndefinite.Size = new System.Drawing.Size(98, 17);
            this.chkIndefinite.TabIndex = 0;
            this.chkIndefinite.Text = "Run indefinitely";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(334, 188);
            this.Controls.Add(this.chkIndefinite);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.numDurationSeconds);
            this.Controls.Add(this.numLoadPercentage);
            this.Controls.Add(this.lblCpuLoad);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnStartStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Elephant Load Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.numLoadPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCpuLoad;

        private System.Windows.Forms.NumericUpDown numLoadPercentage;
        private System.Windows.Forms.NumericUpDown numDurationSeconds;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblDuration;

    }
}
