using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace mit
{
    public partial class SaveProject : Form
    {

        private bool createDirectory = true;    //to check wether to create project directory or 
        private bool updateSolutionName = true; //to check wether to update solution name or not
        string defaultPath = null;      //to store the default path
        string defaultName = null;      //to store the default project and solution name

        public SaveProject()
        {
            InitializeComponent();
            defaultPath = ProjectClass.defaultPath;
            defaultName = ProjectClass.defaultProjectName;

            if (!Directory.Exists(defaultPath))
                Directory.CreateDirectory(defaultPath);

            //Give default values to the form elements..
            Project_Name.Text = defaultName;
            Project_Location.Text = defaultPath;
            Solution_Name.Text = defaultName;
            checkDetails();
        }



        private void Save_Project_Click(object sender, EventArgs e)
        {
            //enter some validation code here.
            //and create the respective folders.
            //write the name of the project to be saved as
            //it creates a subfolder name images and databases for each project made
            //saveFileDialog1.Title = "Save As";
            //saveFileDialog1.FileName = "";

            bool isAllValid = true;

            string projectName = null;
            string projectLocation = null;
            string solutionName = null;

            string mainFilePath = null;

            projectName = Project_Name.Text;
            solutionName = Solution_Name.Text;

            //check if directory to be made or no its true by default
            if (createDirectory)
                projectLocation = Path.Combine(Project_Location.Text, projectName);
            else
                projectLocation = Project_Location.Text;



            ErrorProvider errorprovider = new ErrorProvider();


            if (projectName == "")
            {
                isAllValid = false;
                errorprovider.SetError(Project_Name, "Enter Folder Name");
                error_Label.Text = "Enter Folder Name";

            }
            else if (projectLocation == "")
            {
                isAllValid = false;
                errorprovider.SetError(Project_Location, "Enter project location");
                error_Label.Text = "Enter Project Name";

            }
            else if (solutionName == "")
            {
                isAllValid = false;
                errorprovider.SetError(Solution_Name, "Enter solution name");
                error_Label.Text = "Enter Solution Name";

            }

            else if (Directory.Exists(projectLocation) && createDirectory)
            {
                //error message used in validation
                Console.WriteLine("Folder Exists Change Name");

                //TODO
                //Prompt that folder exist and all the files will be overwritten
                //if user says ok then continue else set isAllValid to false 
                //no error here

                errorprovider.SetError(Project_Name,"Folder Exists Change Name");
                error_Label.Text = "Folder Name Already Exists Change Name";
            }

            else if (!ProjectClass.IsValidFilePath(projectLocation))
            {
                //The location conatain invalid characters..
                Console.WriteLine("invalid characters..");

                isAllValid = false;
                //TODO
                //prompt the user about it.
            }

            else if (isAllValid)
            {
                //Everything seems to be fine.. create project
                //create the folder and the sub folder named images and databases

                if (!Directory.Exists(projectLocation))
                    Directory.CreateDirectory(projectLocation);

                if (!Directory.Exists(Path.Combine(projectLocation, "Images")))
                    Directory.CreateDirectory(Path.Combine(projectLocation, "Images"));

                if (!Directory.Exists(Path.Combine(projectLocation, "Data")))
                    Directory.CreateDirectory(Path.Combine(projectLocation, "Data"));

                mainFilePath = Path.Combine(projectLocation, solutionName + ".mit");

                // create a new database connection:
                ProjectClass.db_con = new SQLiteConnection("Data Source=" + mainFilePath + ";Version=3;New=True;Compress=True;");
                ProjectClass.db_con.Open();                            // open the connection:
                ProjectClass.db_cmd = ProjectClass.db_con.CreateCommand();    // create a new SQL command:

                // create table to store image information;
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS settings (name varchar(100), value varchar(100));";
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS images (iid INTEGER PRIMARY KEY AUTOINCREMENT, name varchar(120), extension varchar(20), location varchar(254), scale_set integer,scale float,scale_x1 float,scale_y1 float,scale_x2 float,scale_y2 float,scale_unit varchar(10));";
                ProjectClass.db_cmd.ExecuteNonQuery();
                //ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS lines (lid INTEGER PRIMARY KEY AUTOINCREMENT, name varchar(120), x1 float, y1 float, x2 float, y2 float, color integer,line_style varchar(30), length float, display integer);";
                //ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS lines (lid INTEGER PRIMARY KEY AUTOINCREMENT, name varchar(120), x1 float, y1 float, x2 float, y2 float, color integer,line_style varchar(30), length float, display integer);";
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS areas (aid INTEGER PRIMARY KEY AUTOINCREMENT, name varchar(120), color integer,area_style varchar(30), area float , display integer,shape varchar(30), radius float);";
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS area_points (pid INTEGER PRIMARY KEY AUTOINCREMENT, aid INTEGER,x float, y float);"; 
                ProjectClass.db_cmd.ExecuteNonQuery();
                //added to modification
                ProjectClass.db_cmd.CommandText = "CREATE TABLE IF NOT EXISTS line_points (pid INTEGER PRIMARY KEY AUTOINCREMENT, lid INTEGER, x float, y float);";
                ProjectClass.db_cmd.ExecuteNonQuery();

                //Insert necessary values in tables..
                ProjectClass.db_cmd.CommandText = "INSERT INTO settings (name, value) VALUES('projectName', @value);";
                ProjectClass.db_cmd.Parameters.AddWithValue("@value", projectName);
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "INSERT INTO settings (name, value) VALUES('solutionName', @value);";
                ProjectClass.db_cmd.Parameters.AddWithValue("@value", solutionName);
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "INSERT INTO settings (name, value) VALUES('dateOfCreation', @value);";
                ProjectClass.db_cmd.Parameters.AddWithValue("@value", DateTime.Now.ToString());
                ProjectClass.db_cmd.ExecuteNonQuery();
                ProjectClass.db_cmd.CommandText = "INSERT INTO settings (name, value) VALUES('version', @value);";
                ProjectClass.db_cmd.Parameters.AddWithValue("@value", ProjectClass.softVersion);
                ProjectClass.db_cmd.ExecuteNonQuery();

                //Close db connection
                ProjectClass.db_con.Close();

                //ProjectClass.loadProject(mainFilePath);

                this.Close();       //respective folder made so close the form.
            }

            
            
        }

        private void Cancel_ProjectSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Project_Location.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        

        private void Project_Name_TextChanged(object sender, EventArgs e)
        {
            //Update the solution name text as the project name changes
            if (updateSolutionName)
            {
                Solution_Name.Text = Project_Name.Text;
            }

            checkDetails();
        }

        private void Solution_Name_TextChanged(object sender, EventArgs e)
        {
            //stop the updation if solution name changed manually...
            if (Solution_Name.Text != Project_Name.Text)
            {
                updateSolutionName = false;
            }
            checkDetails();
        }



        private bool checkDetails()
        {
            //Validates the details and enable or disable the save button.

            bool flag = true;
            //Disable or enable save button if text box is empty
            if (Project_Name.Text == "" || Solution_Name.Text == "")
            {
                //Name empty disable the save button
                flag = false;
            }
            else if (!(Path.IsPathRooted(Project_Location.Text) && Project_Location.Text[0] != Path.DirectorySeparatorChar))
            {
                //Disable the save button if the path is not rooted

                //TODO
                //Still works at c:users\sam
                //should not work like this

                //EXCEPTION once occured
                //if illegal character is used..

                flag = false;
            }
            else if (!Save_Project.Enabled)
            {
                //Name is not empty enable the save button
                flag = true;
            }

            Save_Project.Enabled = flag;

            return flag;
        }

        private void checkBoxCreateDirectory_CheckedChanged(object sender, EventArgs e)
        {
            //Updates the value of create directory if the check box is changed..
            createDirectory = checkBoxCreateDirectory.Checked;
        }
    }

}