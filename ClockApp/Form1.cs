using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class FormStart : Form
    {
        Clock clock = null;
        public FormStart()
        {
            InitializeComponent();
            clock = new Clock();
            clock.LabelTime = this.labelTime;
            clock.LabelSeconds = this.labelSeconds; 
         
            clock.SetOn();
            labelDay.Text = clock.Date.Day.ToString("D2");
            labelMonth.Text = clock.Date.Month.ToString("D2");
        }

   
    }
}
