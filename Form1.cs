using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntraWestAdvancedDotNetEventsExercise2
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int redColor = CheckColorStatus(cbRed);
            int greenColor = CheckColorStatus(cbGreen);
            int blueColor = CheckColorStatus(cbBlue);

            this.BackColor = Color.FromArgb(redColor, greenColor, blueColor);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                timer1.Interval = 1000;
            }
            else
            {
                timer1.Interval = 1000 / trackBar1.Value;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private int CheckColorStatus(CheckBox aCheckbox)
        {
            if(aCheckbox.Checked)
            {
                return _random.Next(256);
            }
            else
            {
                return 0;
            }
        }
    }
}
