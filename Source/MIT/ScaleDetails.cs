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
    public partial class ScaleDetails : Form
    {
        float pixelvalue;
        public ScaleDetails(float length)
        {
            InitializeComponent();
            this.unit_combobox.SelectedIndex = 0;
            pixelvalue = length;
            this.pixel_length.Text = length.ToString() + "  px";
        }

        private void Scalevalue_ok_Click(object sender, EventArgs e)
        {//put validation here
            panel1.Invalidate();
            panel1.Update();
            ErrorProvider error = new ErrorProvider();
            error_Label.Text = "...";
            if (real_length1.Text == "")
            {
                error.SetError(real_length2, "Scale Value cannot be empty");
                error_Label.Text = "Scale Value cannot be empty";
                return;
            }
            else
            {
                error.SetError(real_length2, "");
            }
            if (Convert.ToInt32(real_length1.Text) == 0)
            {
                error.SetError(real_length2, "Enter Proper Scale Value(Scale Value cannot be null or Zero)");
                error_Label.Text = "Scale Value cannot be Zero";
                return;
            }
            else
            {
                error.SetError(real_length2, "");
            }
            if (unit_combobox.SelectedIndex == 0)
            {
                error.SetError(unit_combobox, "Select the unit");
                error_Label.Text = "Select the unit (cm,metre,feet)";
                return;
            }
            else
            {
                error.SetError(unit_combobox, "");
            }
            double scale_calculated = Convert.ToInt32(real_length1.Text.ToString())/pixelvalue;
            
            ImagePropertiesClass.scale_value = (float)Math.Round(scale_calculated,2);
            ImagePropertiesClass.scale_set = true;//now the scale is set for the loaded image
            ImagePropertiesClass.scale_unit = this.unit_combobox.SelectedItem.ToString();//returns the selected index(unit)
            Console.WriteLine("Value of the Scale is:" + ImagePropertiesClass.scale_value);
            
            //enter value in db
            Commonforallfunctions.set_scalepoints();
            ProjectClass.db_cmd.CommandText = "UPDATE images set scale=@scale ,scale_x1=@scale_x1,scale_y1=@scale_y1,scale_x2=@scale_x2,scale_y2=@scale_y2 ,scale_unit=@scale_unit where iid=" + ImagePropertiesClass.ImageId + ";";
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale", ImagePropertiesClass.scale_value);
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale_x1",ImagePropertiesClass.scale_startpt.X );
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale_y1", ImagePropertiesClass.scale_startpt.Y);
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale_x2", ImagePropertiesClass.scale_endpt.X);
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale_y2", ImagePropertiesClass.scale_endpt.Y);
            ProjectClass.db_cmd.Parameters.AddWithValue("@scale_unit",ImagePropertiesClass.scale_unit);
            ProjectClass.db_cmd.ExecuteNonQuery();

           
            this.Dispose();
        }

        private void Scalevalue_cancel_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";

        }

        private void real_length_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumPressed = false;

            // see if the keystroke is a number from the keypad.
            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
            {
                // see if the keystroke is a number from the top of the keyboard.
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // see if the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // a non-numerical keystroke was pressed.
                        // set the flag to true and evaluate in KeyPress event.
                        nonNumPressed = true;
                    }
                }
            }
        }

        private void real_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumPressed == true)
            {
                // stop the non-numeric character from being entered into the textbox.
                e.Handled = true;
            }
        }
    }
}
