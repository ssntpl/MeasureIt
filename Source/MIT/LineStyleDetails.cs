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
    public partial class LineStyleDetails : Form
    {
      
        public LineStyleDetails()
        {
            p = new Pen(Color.Black, 2);
            InitializeComponent();
        }

        private void LineStyleDetails_Load(object sender, EventArgs e)
        {

        }

        private void LineStyle_OK_Click(object sender, EventArgs e)
        {
            
            //check for selected pattern
           
             if (radio_dash.Checked == true)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                
            }
            else if (radio_dot.Checked == true)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else if (radio_dashdot.Checked == true)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            }
             else
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            //check for selected color
            if (radio_blue.Checked == true)
            {
                p.Color = Color.Blue;
            }
            else if (radio_red.Checked == true)
            {
                p.Color = Color.Red;
            }
            else if (radio_green.Checked == true)
            {
                p.Color = Color.Green;
            }
            else
                p.Color=Color.Black;
            Console.WriteLine("Pen is: " + p.DashStyle + "LInePentype:" + p.PenType.ToString());
            DialogResult = DialogResult.OK;
            this.Visible=false;
        }

        //this function returns the pen value to set it to currentpen in main form
        public Pen returnpen()
        {
            return p;
        }
    }
}
