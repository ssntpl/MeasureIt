using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mit
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Timer startmainform_clock = new Timer();
            startmainform_clock.Interval = 5000;
            startmainform_clock.Start();
            startmainform_clock.Tick += new EventHandler(Timer_Tick);
        }


        public void Timer_Tick(object sender, EventArgs eArgs)
        {

            this.Close();
        }
    }
}
