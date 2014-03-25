using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mit
{
    public partial class LineDetails : Form
    {
        public LineDetails()
        {
            InitializeComponent();
        }

        private void LineName_ok_Click(object sender, EventArgs e)
        {
            ErrorProvider error = null;
            if (this.LineName.Text == "")
            {
                error = new ErrorProvider();
                error.SetError(this.LineName, "Enter line name");
                error_Label.Text = "Enter line name";
            }


            SQLiteDataReader db_data_lines;
            SQLiteCommand db_cmd_lines = ProjectClass.db_con.CreateCommand(); ;
            db_cmd_lines.CommandText = "SELECT name FROM lines ;";
            db_data_lines = db_cmd_lines.ExecuteReader();
            while (db_data_lines.Read())
                if (this.LineName.Text == db_data_lines.GetString(0))
                {
                    error = new ErrorProvider();
                    error.SetError(this.LineName, "line name exists");
                    error_Label.Text = "line name exists";
                    return;
                }
            
            {
                linename = this.LineName.Text;
                this.DialogResult = DialogResult.OK;
               
            }
            
        }


        public string setlinename()
        {
            return linename;

        }


    }
}
