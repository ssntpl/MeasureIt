using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace mit
{
    class ProjectClass
    {

        //project details
        public static string softName = "MeasureIT OnScreen";
        public static string softVersion = "0.9b";
        public static string defaultPath = "";
        public static string defaultProjectName = "My Project";



        public static MainForm mainForm;               //To store reference of main form

        public static SQLiteConnection  db_con;     //used to create connection with DB
        public static SQLiteCommand     db_cmd;     //used for DB command processing
        public static SQLiteDataReader  db_data;    //used to read data from DB

        public static bool projectLoaded = false;   //To check wether project is loaded or not
        public static bool projectSaved  = false;   //To check wether the project is saved or not

        public static string projectPath  = null;   //To store main directory path
        public static string imageDirPath = null;   //To store image directory path
        public static string dataDirPath = null;   //To store data directory path
        public static string mainFilePath = null;   //To store solution file path

        public static string projectName  = null;   //To store project name
        public static string solutionName = null;   //To store project name





       
        public static bool loadProject(string path)//here path is the ".mit" requested to open
        {
            //This function is called to load the project

            bool isAllValid = true;   //Flag variable to track loading of project

            if (projectLoaded)
            {
                //Another project is already loaded. close it and then continue.

                Console.Write("Project already loaded");

                if(closeProject())    //TODO Create a function to close a project.
                {
                    //Project closed so continue.
                }
                else
                {
                    //Project failed to close. Stop loading new project.
                    isAllValid=false;

                    //TODO optional
                    //Can prompt that cannot load another project.
                    
                }

            }
            else if (!System.IO.File.Exists(path))
            {
                //The file don't exist
                isAllValid = false;
            }
            else if (false)  //TODO Create a function to check wether the file is valid MIT project
            {
                //The file is not a valid MIT project
                isAllValid = false;
            }

            if(isAllValid)
            {
                //Everything seems to be ok. Load the project.
                
                mainFilePath = path;                                            //Set main file path
                projectPath = System.IO.Path.GetDirectoryName(mainFilePath);    //Set the path of mainFile
                imageDirPath = System.IO.Path.Combine(projectPath, "Images");      //Set image directory path
                dataDirPath = System.IO.Path.Combine(projectPath, "Data");

                //Create DB connection
                ProjectClass.db_con = new SQLiteConnection("Data Source=" + mainFilePath + ";Version=3;New=False;Compress=True;");
                ProjectClass.db_con.Open();                                     // open the connection:
                ProjectClass.db_cmd = ProjectClass.db_con.CreateCommand();      // create a new SQL command:

                //Read data from DB
                ProjectClass.db_cmd.CommandText = "SELECT value FROM settings WHERE name='projectName';";
                ProjectClass.db_data = ProjectClass.db_cmd.ExecuteReader();
                if (ProjectClass.db_data.Read())
                    projectName = ProjectClass.db_data.GetString(0);
                ProjectClass.db_data.Close();
                    
                //Create basic tree node
                TreeNode mainNode = new TreeNode();
                mainNode.Name = "mainNode";
                mainNode.Text = projectName; //"Main Project";
                mainForm.treeView1.Nodes.Add(mainNode);

                //Add image nodes in tree...
                ProjectClass.db_cmd.CommandText = "SELECT iid FROM images;";
                ProjectClass.db_data = ProjectClass.db_cmd.ExecuteReader();
                while(ProjectClass.db_data.Read())
                    addImage(ProjectClass.db_data.GetInt32(0));
                ProjectClass.db_data.Close();
            
            }

            //If everything completed without errors then set projectLoaded to true and return true
            if (isAllValid)
                projectLoaded = true;
            return projectLoaded;
        }

        public static bool closeProject()
        {
            //Closes the opened project.
            ImagePropertiesClass.scale_set = false;
            mainForm.vector_lines.RemoveRange(0,mainForm.vector_lines.Count);
            mainForm.vector_areas.RemoveRange(0, mainForm.vector_areas.Count);
            mainForm.treeView1.Nodes.Clear();
            mainForm.pictureBox1.Image = null;
            mainForm.imagerelatedtools_enable(false);
            mainForm.loadtime_toolenable(false);
            mainForm.Text = "MeasureIT onScreen";
            ImagePropertiesClass.scale_set = false;
            projectLoaded = false;
            
            return !projectLoaded;
        }

       

        public static bool addImage(int iid)
        {
            //Just adds the node and create the required dynamic functions..

            //TODO
            //the function should also create an image class and object,
            //that has image properties and dynamic functions to the tree nodes

            SQLiteDataReader db_data_local;
            SQLiteCommand db_cmd_local = ProjectClass.db_con.CreateCommand(); ;

            SQLiteDataReader db_data_local_2;
            SQLiteCommand db_cmd_local_2 = ProjectClass.db_con.CreateCommand(); ;

            

            string imageName = "";
            string imagePath = "";
            Line line_class;
            Area area_class;
            PointF pt;
            string pen_style="";//to insert pen_style for line and ares

            //Read iid from DB
            db_cmd_local.CommandText = "SELECT name, extension, scale,scale_set,scale_x1,scale_y1,scale_x2,scale_y2 ,scale_unit FROM images WHERE iid='" + iid + "';";
            db_data_local = db_cmd_local.ExecuteReader();
            if (db_data_local.Read())
            {
                imageName = db_data_local.GetString(0);
                imagePath = System.IO.Path.Combine(imageDirPath, iid + db_data_local.GetString(1));
                ImagePropertiesClass.scale_value = db_data_local.GetFloat(2);
                if (ImagePropertiesClass.scale_value != 0)
                {
                    ImagePropertiesClass.scale_value = db_data_local.GetFloat(2);
                    ImagePropertiesClass.scale_set = true;
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!Vale of scale set:" + db_data_local.GetName(3) + db_data_local.GetName(4));
                    ImagePropertiesClass.scale_startpt.X = db_data_local.GetFloat(4);
                    ImagePropertiesClass.scale_startpt.Y = db_data_local.GetFloat(5);
                    ImagePropertiesClass.scale_endpt.X = db_data_local.GetFloat(6);
                    ImagePropertiesClass.scale_endpt.Y = db_data_local.GetFloat(7);
                    ImagePropertiesClass.scale_unit = db_data_local.GetString(8);

                }
                Console.WriteLine("Value of scale set:" + db_data_local.GetName(3));
               
            }
            db_data_local.Close();

            string tempiid = "image_" + iid.ToString();

            //To add node in the first node of tree
            TreeNode mainNode = new TreeNode();
            mainNode.Name = tempiid;
            mainNode.Text = imageName;
            mainForm.treeView1.Nodes[0].Nodes.Add(mainNode);
            mainForm.treeView1.Nodes[0].ExpandAll();

            mainNode = new TreeNode();
            mainNode.Name = iid.ToString() + "_Lines";
            mainNode.Text = "Lines";
            mainForm.treeView1.Nodes[0].FirstNode.Nodes.Add(mainNode);
            mainForm.treeView1.ExpandAll();
            mainForm.line_list = mainNode;

            mainNode = new TreeNode();
            mainNode.Name = iid.ToString() + "_Areas";
            mainNode.Text = "Areas";
            mainForm.treeView1.Nodes[0].FirstNode.Nodes.Add(mainNode);
            mainForm.treeView1.ExpandAll();
            mainForm.area_list = mainNode;



            db_cmd_local.CommandText = "SELECT name, x1, y1, x2, y2, color,length,line_style,lid  FROM lines;"; // WHERE iid='" + iid + "';";
            db_data_local = db_cmd_local.ExecuteReader();
            while (db_data_local.Read())
            {
               
                line_class = new Line();
               
                line_class.line_name = db_data_local.GetString(0);
                line_class.start.X = db_data_local.GetFloat(1);
                line_class.start.Y = db_data_local.GetFloat(2);
                line_class.end.X = db_data_local.GetFloat(3);
                line_class.end.Y = db_data_local.GetFloat(4);
                line_class.line_pen.Color = System.Drawing.Color.FromArgb(db_data_local.GetInt32(5));
                line_class.line_length = db_data_local.GetFloat(6);
                
                 pen_style=db_data_local.GetString(7);
                 line_class.lid = db_data_local.GetInt32(8);
                 Console.WriteLine("pen_style recorded: " + pen_style);
                if (pen_style == "Dot")
                {
                    line_class.line_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                }
                else if (pen_style == "Dash")
                {
                    line_class.line_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }
                else if (pen_style == "DashDot")
                {
                    line_class.line_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                }
                else
                {
                    line_class.line_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }

                //added for multipoint nov19

                db_cmd_local_2.CommandText = "SELECT x, y FROM line_points WHERE lid=@lid ORDER BY pid;";
                db_cmd_local_2.Parameters.AddWithValue("@lid", line_class.lid);
                db_data_local_2 = db_cmd_local_2.ExecuteReader();
                while (db_data_local_2.Read())
                {
                    pt = new PointF();
                    pt.X = db_data_local_2.GetFloat(0);
                    pt.Y = db_data_local_2.GetFloat(1);
                    line_class.points.Add(pt);
                    
                }
                db_data_local_2.Close();



                ProjectClass.mainForm.vector_lines.Add(line_class);

                //Added  by SAM for tree
                mainForm.line_list.Nodes.Add(new TreeNode(line_class.line_name));
            }
            db_data_local.Close();

            db_cmd_local.CommandText = "SELECT name, aid, color,area,area_style,shape ,radius FROM areas;"; // WHERE iid='" + iid + "';";
            db_data_local = db_cmd_local.ExecuteReader();
            while (db_data_local.Read())
            {
                area_class = new Area();
                area_class.area_name = db_data_local.GetString(0);
                area_class.aid = db_data_local.GetInt32(1);
                area_class.area_pen.Color = System.Drawing.Color.FromArgb(db_data_local.GetInt32(2));
                area_class.area_value = db_data_local.GetFloat(3);
                area_class.areapoints = new System.Collections.ArrayList();
                Console.WriteLine("value is:" + db_data_local.GetValue(5));
                area_class.shape = db_data_local.GetString(5);
                area_class.radius = db_data_local.GetFloat(6);
                //entry of area_style
                //Console.WriteLine("Area Style Type: "+db_data_local.GetString(4));
                pen_style = db_data_local.GetString(4);
                Console.WriteLine("pen_style recorded: " + pen_style);
                if (pen_style == "Dot")
                {
                    Console.WriteLine("pen_style is " + pen_style);
                    area_class.area_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                }
                else if (pen_style == "Dash")
                {
                    Console.WriteLine("pen_style is " + pen_style);
                    area_class.area_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }
                else if (pen_style == "DashDot")
                {
                    Console.WriteLine("pen_style is " + pen_style);
                    area_class.area_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                }
                else
                {

                    area_class.area_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }

                db_cmd_local_2.CommandText = "SELECT x, y FROM area_points WHERE aid=@aid ORDER BY pid;"; // WHERE iid='" + iid + "';";
                db_cmd_local_2.Parameters.AddWithValue("@aid", area_class.aid);
                db_data_local_2 = db_cmd_local_2.ExecuteReader();
                while (db_data_local_2.Read())
                {
                    pt = new PointF();
                    pt.X = db_data_local_2.GetFloat(0);
                    pt.Y = db_data_local_2.GetFloat(1);
                    area_class.areapoints.Add(pt);
                }
                db_data_local_2.Close();

                //Added  by SAM for tree
                mainForm.area_list.Nodes.Add(new TreeNode(area_class.area_name));

                ProjectClass.mainForm.vector_areas.Add(area_class);
            }
            db_data_local.Close();

            
            //TODO optional
            //EXCEPTION File not exist exception unhandeled

           
   
            if (System.IO.File.Exists(imagePath))//to see if image file exists
            {
                mainForm.pictureBox1.Image = Image.FromFile(imagePath);
                //set the values of ImagePropertiesClass attributes.
                ImagePropertiesClass.imageLoaded = true;
                ImagePropertiesClass.originalImage = Image.FromFile(imagePath);
                ImagePropertiesClass.setvalues(imageName, iid, imagePath, Image.FromFile(imagePath), Image.FromFile(imagePath).PhysicalDimension);//set its values
               // return imgindatabase;
                return true;
            }

            else
            {
                return false;
            }


          

           // return true;
        }


        public static bool IsValidFilePath(string path)
        {
            string pattern = @"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(path);
        }
    
    }
}
