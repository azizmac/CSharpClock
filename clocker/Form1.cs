using Microsoft.VisualBasic.Devices;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace clocker
{
    public partial class Form1 : Form
    {
        bool isStart = false;
        public Form1()
        {
            InitializeComponent();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sTimeClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btStop.Enabled = false;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void btStart_Click(object sender, EventArgs e)
        {

            if (isStart == false)
            {
                sTimeAlarm.Text = msTime.Text;
                timer2.Start();
                msTime.Visible = false;
                btStart.Text = "Убрать будильник";
                isStart = true;
            }
            else
            {
                sTimeAlarm.Text = "00:00";
                timer2.Stop();
                msTime.Visible = true;
                btStart.Text = "Завести будильник";
                isStart = false;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStop.Enabled = false;
            msTime.Visible = true;
            btStart.Text = "Завести будильник";
            isStart = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sTimeClock.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");

            if (sTimeClock.Text == sTimeAlarm.Text + ":00")
            {
                btStop.Enabled = true;
            }

        }

    }
}
