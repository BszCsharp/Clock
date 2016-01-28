using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ClockApp
{
    public partial class FormStart : Form
    {
        Clock clock = null;
        DateTime alarmTime = new DateTime();
        SoundPlayer player = null;
        Image img1 = Image.FromFile("off.png");
        Image img2 = Image.FromFile("off2.png");
        public FormStart()
        {
            InitializeComponent();
            clock = new Clock();
            clock.LabelTime = this.labelTime;
            clock.LabelSeconds = this.labelSeconds;
            clock.Modus = Mode.Clock;
            clock.onAlarm += Alarm;
         
            clock.SetOn();
            labelDay.Text = clock.Date.Day.ToString("D2");
            labelMonth.Text = clock.Date.Month.ToString("D2");
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //global::ClockApp.Properties.Resources.clock;
            UnmanagedMemoryStream s = Properties.Resources.wecker;
            //System.IO.Stream s = a.GetManifestResourceStream("ClockApp.Resources.wecker.wav");
            //player = new SoundPlayer("wecker.wav");
            player = new SoundPlayer(s);
            //player.Play();
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            if (clock.Modus == Mode.Clock)
            {
                clock.Modus = Mode.Alarm;
                labelSeconds.Visible = false;
                labelMode.Text = Mode.Alarm.ToString();
                labelTime.Text = clock.Alarm.Hour.ToString("D2") + ":" + clock.Alarm.Minute.ToString("D2");
            }
            else
            {
                clock.Modus = Mode.Clock; 
                labelSeconds.Visible = true;
                labelMode.Text = Mode.Clock.ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(clock.Modus == Mode.Alarm)
            {
                clock.Alarm =  clock.Alarm.AddHours(1.00);
                String zeit = clock.Alarm.Hour.ToString("D2") + ":" + clock.Alarm.Minute.ToString("D2");
                labelTime.Text = zeit;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (clock.Modus == Mode.Alarm)
            {
                clock.Alarm = clock.Alarm.AddHours(-1.00);
                String zeit = clock.Alarm.Hour.ToString("D2") + ":" + clock.Alarm.Minute.ToString("D2");
                labelTime.Text = zeit;
            }
        }

        private void buttonMinPlus_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonMinPlus_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock.Modus == Mode.Alarm)
            {
                clock.Alarm = clock.Alarm.AddMinutes(1.00);
                String zeit = clock.Alarm.Hour.ToString("D2") + ":" + clock.Alarm.Minute.ToString("D2");
                labelTime.Text = zeit;
            }
        }

        private void buttonMinPlus_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            if(clock.Status == State.Off)
            {
                clock.Status = State.On;
            }
            else
            {
                clock.Status = State.Off;
            }
            labelOnOff.Text = clock.Status.ToString();

        }
        private void Alarm(object sender,EventArgs e)
        {
            labelOnOff.Text = clock.Status.ToString();
           // MessageBox.Show("Alarm");
            player.Play();
            timerOnOff.Enabled = true;
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            player.Stop();
            timerOnOff.Enabled = false;
        }

        private void timerOnOff_Tick(object sender, EventArgs e)
        {
            if(buttonOnOff.BackgroundImage == img1)
            {
                buttonOnOff.BackgroundImage = img2;
            }
            else buttonOnOff.BackgroundImage = img1;
        }


   
    }
}
