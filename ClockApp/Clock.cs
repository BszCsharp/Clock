﻿using System;
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
        private Mode modus;
        public delegate void ActionAlarm(object sender, EventArgs e);
        public event ActionAlarm onAlarm;

        public Mode Modus
        {
            get { return modus; }
            set { modus = value; }
        }

        Timer timer;
        public Clock()
        {
            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += timerTick;
            this.Modus = Mode.Clock;
            this.Date = DateTime.Today;
            this.Status = State.Off;
            this.Alarm = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,0,0,0);
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
        public void timerTick(Object sender,EventArgs e)
        {
            this.Time = DateTime.Now;
           
            int h = this.Time.Hour;
            int m = this.Time.Minute;
            if (labelTime != null && this.Modus == Mode.Clock)
            {
                this.labelTime.Text = h.ToString("D2") + ":" + m.ToString("D2");
            }
            if (LabelSeconds != null && this.Modus == Mode.Clock)
            {
                this.LabelSeconds.Text = this.Time.Second.ToString("D2");
            }
            if(this.Time >= this.Alarm && this.Status == State.On)
            {
                this.Status = State.Off;
                if (onAlarm != null) onAlarm(this, new EventArgs());
                
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
    public enum Mode
    {
        Clock,
        Alarm
    }
}
