using System;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmSpash : Form
    {
        public frmSpash()
        {
            InitializeComponent();
            progressBar.MarqueeAnimationSpeed = 30;
        }

        private void showTime_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void progTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                progTimer.Stop();
            }
        }
    }
}