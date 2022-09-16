
namespace SyntraWestAdvancedDotNetEventsExercise2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbBlue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(112, 68);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(500, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(112, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 150);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(462, 178);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 150);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Checked = true;
            this.cbRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRed.Location = new System.Drawing.Point(158, 428);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(46, 19);
            this.cbRed.TabIndex = 3;
            this.cbRed.Text = "Red";
            this.cbRed.UseVisualStyleBackColor = true;
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Checked = true;
            this.cbGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGreen.Location = new System.Drawing.Point(329, 428);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(57, 19);
            this.cbGreen.TabIndex = 4;
            this.cbGreen.Text = "Green";
            this.cbGreen.UseVisualStyleBackColor = true;
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Checked = true;
            this.cbBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlue.Location = new System.Drawing.Point(511, 428);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(49, 19);
            this.cbBlue.TabIndex = 5;
            this.cbBlue.Text = "Blue";
            this.cbBlue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.cbBlue);
            this.Controls.Add(this.cbGreen);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.CheckBox cbBlue;
    }
}

