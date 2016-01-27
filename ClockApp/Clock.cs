using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers;
using System.Windows.Forms;

namespace ClockApp
{
    public class Clock
    {
        private State status;
        Timer timer;
        public Clock()
        {
            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += timerTick;
            this.Date = DateTime.Today;
        }
        public State Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        private DateTime alarm;

        public DateTime Alarm
        {
            get { return alarm; }
            set { alarm = value; }
        }
        public void SetOn()
        {
            timer.Enabled = true;
        }
        public void timerTick(Object dender,EventArgs e)
        {
            this.Time = DateTime.Now;
            if(labelTime != null)
            {
                int h = this.Time.Hour;
                int m = this.Time.Minute;
                this.labelTime.Text = h.ToString("D2") + ":" + m.ToString("D2");
            }
            if(LabelSeconds != null)
            {
                this.LabelSeconds.Text = this.Time.Second.ToString("D2");
            }
        }
        private Label labelTime;
        public Label LabelTime
        {
            //get { return labelTime; }
            set { labelTime = value; }
        }
        private Label labelSeconds;

        public Label LabelSeconds
        {
            private get { return labelSeconds; }
            set { labelSeconds = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        
        

    }
    public enum State
    {
        On,
        Off
    }
}
