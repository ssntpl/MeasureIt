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
    public partial class AreaDetails : Form
    {
        public AreaDetails()
        {
            InitializeComponent();
        }

        private void AreaName_OK_Click(object sender, EventArgs e)
        {
            ErrorProvider error = null;
            if (this.AreaName.Text == "")
            {
                error = new ErrorProvider();
                error.SetError(this.AreaName, "Enter line name");
                error_Label.Text = "Enter line name";
            }

            SQLiteDataReader db_data_areas;
            SQLiteCommand db_cmd_areas = ProjectClass.db_con.CreateCommand(); ;
            db_cmd_areas.CommandText = "SELECT name FROM areas ;";
            db_data_areas = db_cmd_areas.ExecuteReader();
            while (db_data_areas.Read())
                if (this.AreaName.Text == db_data_areas.GetString(0))
                {
                    error = new ErrorProvider();
                    error.SetError(this.AreaName, "area name exists");
                    error_Label.Text = "area name exists";
                    return;
                }
            
            
                areaname = this.AreaName.Text;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            
        }
        public string setareaname()
        {
            return areaname;

        }

        private void AreaName_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
