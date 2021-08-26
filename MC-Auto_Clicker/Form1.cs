using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Auto_Clicker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Error!", "MC-Auto_Clicker", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (buttonToggle.Text.Contains("on"))
            {
                clicktimer.Start();
                buttonToggle.Text = "Toogle : off";
            }
            else
            {
                clicktimer.Stop();
                buttonToggle.Text = "Toogle : on";
            }
        }

        private void clicktimer_Tick_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maxcps = (int)Math.Round(1000.0 / (MaxTrackBar.Value + MinTrackBar.Value * 0.2));
            int mincps = (int)Math.Round(1000.0 / (MaxTrackBar.Value + MinTrackBar.Value * 0.4));
            try
            {
                clicktimer.Interval = rnd.Next(mincps, maxcps);
            }
            catch
            {
                // ignored
            }

            bool mousedown = MouseButtons == MouseButtons.Left;
            if (mousedown)
            {
                mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                Thread.Sleep(millisecondsTimeout: rnd.Next(1, 6));
                mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            }
        }

        private void MaxTrackBar_Scroll(object sender, EventArgs e)
        {
            string max = MaxTrackBar.Value.ToString();
            labelMax.Text = "Max CPS: " + max;
        }

        private void MinTrackBar_Scroll(object sender, EventArgs e)
        {
            string min = MinTrackBar.Value.ToString();
            labelMin.Text = "Min CPS: " + min;
        }
    }
}