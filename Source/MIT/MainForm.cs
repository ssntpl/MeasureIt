using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.IO;
using System.Data.SQLite;

namespace mit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ProjectClass.mainForm = this;       //Giving reference of mainForm to projectClass
            ImagePropertiesClass.mainForm_imgprop = this;
            //OPTIONAL
            //retrieve the default path from ini or db....
            ProjectClass .defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ProjectClass.defaultPath = System.IO.Path.Combine(ProjectClass.defaultPath, "MeasureIT");
            ProjectClass.defaultPath = System.IO.Path.Combine(ProjectClass.defaultPath, "Projects");
            imagerelatedtools_enable(false);//since no image loaded in form
            vector_lines=new ArrayList();
            vector_areas = new ArrayList();
            //scale_class = new Line();//this object stores value related to scale of image.
            if (ProjectClass.projectLoaded)
                loadtime_toolenable(true);
            else
                loadtime_toolenable(false);
            
           //set scalepen defined in ImageProperties Class
            ImagePropertiesClass.set_scalepen();
            if (ImagePropertiesClass.scale_set)
            {
                toolStripStatus_scale.Text = "Scale Set 1:"+ImagePropertiesClass.scale_value;
                
            }
            //initialize list for trees
            line_list = new TreeNode();
            area_list = new TreeNode();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            currentpen = new Pen(Color.Black,3);
         

        }

        private void Line_tool_Click(object sender, EventArgs e)
        {
            if (ImagePropertiesClass.scale_set)
            {
                form_linedetails = new LineDetails();
                currentpen = Commonforallfunctions.getdefaultpen();//set default pen
                if (form_linedetails.ShowDialog() == DialogResult.OK)//if form was successfully closed
                {
                    //call function to disable appropriate controls
                    functiontime_settools(false);//set the tools enable property to false
                    this.Cancel_tool.Enabled = true;
                    this.LineStyle_tool.Enabled = true;
                    Commonforallfunctions.setlinebool(true);
                    Commonforallfunctions.setdrawbool(true);
                    Commonforallfunctions.setRecordpointsbool(true);//to indicate that points clicked are to be recorded in list.




                    line_class = new Line();
                    line_class.line_name = form_linedetails.setlinename();//get the line name.
                    Console.WriteLine("Line name is:" + line_class.line_name);//debugging purpose
                  //  line_thread = new LineCalculation_Thread();//start the thread
                    multipointline_thread = new AreaCalculation_Thread(); 
                    calculationfinish_Thread = new Thread(this.run);//thread started to see when above thread is finished.
                    calculationfinish_Thread.Start();
                    LineStyle_tool.Enabled = true;//enabled so that linestyle can be chosen


                }
            }

            else
            {
                
                    MessageBox.Show("Scale is to be set First \n Click on \"SetScale\" to set the scale", "You are missing something!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Area_tool_Click(object sender, EventArgs e)
        {
            if (ImagePropertiesClass.scale_set)
            {
                form_areadetails = new AreaDetails();
                currentpen = Commonforallfunctions.getdefaultpen();//to set default pen
                functiontime_settools(false);//set the tools enable property to false
                this.Cancel_tool.Enabled = true;
                Commonforallfunctions.setareabool(true);
                Commonforallfunctions.setdrawbool(true);
                Commonforallfunctions.setRecordpointsbool(true);//to indicate that points clicked are to be recorded in list.
                if (form_areadetails.ShowDialog() == DialogResult.OK)
                {
                    area_class = new Area();
                    this.LineStyle_tool.Enabled = true;
                    area_class.area_name = form_areadetails.setareaname();
                    area_thread = new AreaCalculation_Thread();
                    Console.WriteLine("Area name is:" + area_class.area_name);//debugging purpose
                    calculationfinish_Thread = new Thread(this.run);//thread started to see when above thread is finished.
                    calculationfinish_Thread.Start();
                }
            }
            else
            {
                MessageBox.Show("Scale is to be set First \n Click on \"SetScale\" to set the scale", "You are missing something!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void SetScale_tool_Click(object sender, EventArgs e)
        {
            Commonforallfunctions.setsetscalebool(true);//setscale function requested by user
            functiontime_settools(false); //set the tools enable property to false
            Commonforallfunctions.setdrawbool(true);
            Commonforallfunctions.setRecordpointsbool(true);//to start recording points for end points of scale

            scaleline_thread = new LineCalculation_Thread();//start thread to take end points of line.
           
            //set to current pen
            currentpen = ImagePropertiesClass.scalepen;

            calculationfinish_Thread = new Thread(this.run);//to check when this is over
            calculationfinish_Thread.Start();
         
        }

        private void Count_tool_Click(object sender, EventArgs e)
        {
            form_countdetails = new CountDetails();
            form_countdetails.ShowDialog();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the Project";
            openFileDialog1.InitialDirectory = ProjectClass.defaultPath;
            openFileDialog1.Filter = "MIT project|*.mit";
            openFileDialog1.FileName = "";
            string chosenFile = "";
            
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                chosenFile = openFileDialog1.FileName;
                ImagePropertiesClass.resetvalues();
                if (!ProjectClass.loadProject(chosenFile))
                {
                    //Failed to load project
                    //do something
                }
                else //else project is successfully loaded
                {
                    //set title of form to project name (of loaded project)
                    ProjectClass.mainForm.Text = ProjectClass.projectName + " - MeasureIT onScreen";
                    //project is loaded enable controls
                    loadtime_toolenable(true);
                    //to be done if image exists in database then enable imagerelated tools this needs to be checked 
                    if (ImagePropertiesClass.imageLoaded)
                    {
                        imagerelatedtools_enable(true);
                        this.AddImage_tool.Enabled = false;
                        this.addImageToolStripMenuItem.Enabled = false;
                    }
                }
            }
            if (ImagePropertiesClass.scale_set)
            {
                toolStripStatus_scale.Text = "Scale Set 1:" + ImagePropertiesClass.scale_value;

            }
        
        }

       

        private void AddImage_tool_Click(object sender, EventArgs e)
        {
          

            if (ImagePropertiesClass.addImage())//imageloaded successfuly
            {
                //enable the opearation and image related buttons
                imagerelatedtools_enable(true);
                if(ImagePropertiesClass.imageLoaded)
                    this.AddImage_tool.Enabled = false;//no more images can now be added to project
               
            }
            else
            {
                //dispose this imgprop object
            }

        }

        private void Save_tool_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Title = "Save As";
            //saveFileDialog1.FileName = "";

            //if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //{
            //    // chosenFile = saveFileDialog1.FileName;


            //}
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject form_saveproject = new SaveProject();
            if (form_saveproject.ShowDialog() == DialogResult.OK)
            {
               // make databases here
            }
           

        }

        private void LineStyle_tool_Click(object sender, EventArgs e)
        {
           form_linestyledetails = new LineStyleDetails();
           if (form_linestyledetails.ShowDialog() == DialogResult.OK & Commonforallfunctions.getRecordpointsbool())//only set pen when any of the unctionclicked
           {

               currentpen = (Pen)(form_linestyledetails.returnpen()).Clone();//check this out
               form_linestyledetails.Close();
               LineStyle_tool.Enabled = false;

           }
          
            Console.WriteLine(currentpen.DashStyle);
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        //this functions tell about which controls are to be disabled during form_load
        public void loadtime_toolenable(bool b)
        {
            toolStrip2.Enabled = b;
            //items in toolbar
            Save_tool.Enabled = b;
           AddImage_tool.Enabled = b;
         
            //items in drop down menu
            closeProjecttoolStripMenuItem.Enabled = b;
            printPriviewToolStripMenuItem.Enabled = b;
            printToolStripMenuItem.Enabled = b;
            addImageToolStripMenuItem.Enabled = b;
            saveToolStripMenuItem.Enabled = b;
            saveAstoolStripMenuItem.Enabled = b;
            //project drop down
            generateSummaryToolStripMenuItem.Enabled = b;
        }

        //this function controls enable enable functions if image loaded in picture box
        public void imagerelatedtools_enable(bool b)
        {
            SetScale_tool.Enabled = b;
            ZoomIn_tool.Enabled = b;
            Zoomout_tool.Enabled = b;
            Normal_tool.Enabled = b;
           
            Area_tool.Enabled = b;
            Line_tool.Enabled = b;

            LineStyle_tool.Enabled = b;

            //toolstrip
            setscaleToolStripMenuItem.Enabled = b;
            lineToolStripMenuItem.Enabled = b;
            areaToolStripMenuItem.Enabled = b;
        }
        //this functions controls enable which controls are to be enabled or
        //disabled during function like (line,area,count)
        private void functiontime_settools(bool b)
        {

            //items in drop down menu
            closeProjecttoolStripMenuItem.Enabled = b;
            printPriviewToolStripMenuItem.Enabled = b;
            printToolStripMenuItem.Enabled = b;
            //addImageToolStripMenuItem.Enabled = b;

            //items in toolbar
            Save_tool.Enabled = b;
            //AddImage_tool.Enabled = b;
            SetScale_tool.Enabled = b;
            OK_tool.Enabled = b;
        
            Open_tool.Enabled = b;
            Area_tool.Enabled = b;
            Line_tool.Enabled = b;
           //project drop down
            generateSummaryToolStripMenuItem.Enabled = b;
            areaToolStripMenuItem.Enabled = b;
            lineToolStripMenuItem.Enabled = b;
            setscaleToolStripMenuItem.Enabled = b;
          


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                if (me.Button == MouseButtons.Right)
                {
                   // this.ContextMenu.Show(this, new Point(me.X, me.Y));
                }
                Commonforallfunctions.setdrawbool(false);
                Commonforallfunctions.setcancelbool(true);
                Commonforallfunctions.setRecordpointsbool(false);
                Commonforallfunctions.setcalculationthread_finishbool(true);
                this.pictureBox1.Invalidate();
                this.pictureBox1.Update();
                this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            }
            if (Commonforallfunctions.getRecordpointsbool())
            {
                this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
                Commonforallfunctions.setclickbool(true);//only used when calculation to be performed.
                Commonforallfunctions.setcurrentpoint(me.Location, ImagePropertiesClass.getzoomfactor());
                
            }
            else
            {
                this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void Cancel_tool_Click(object sender, EventArgs e)
        {
            Commonforallfunctions.setcancelbool(true);
            LineStyle_tool.Enabled = false;//we need to disable it since no operation selected
            functiontime_settools(true);
            if (Commonforallfunctions.getcalculationthread_finishbool())
            {
                Commonforallfunctions.resetall();//it is done so that cancelbool set to false again
                calculationfinish_Thread.Abort();//terminate the thread to see when to enable OK button
            }
            else
            {
                Commonforallfunctions.clear_listofpoints();
            }
            this.pictureBox1.Invalidate();
            this.pictureBox1.Update();

          

          
        }

        //this is the thread run function used for finding if the thread is over and enabling
        //the ok button on the form to enter data to database;
        public void run()
        {

            Console.WriteLine("Inside thread now!!!");
            //checked if claculation  Thread finished or Cancel clicked
            while (!(Commonforallfunctions.getcalculationthread_finishbool()))
            {
                Thread.Sleep(500);
                if (Commonforallfunctions.getcancelbool())
                {
                    if (Commonforallfunctions.getareabool()||Commonforallfunctions.getlinebool())
                    {
                        //area thread over
                        break;
                    }
                    else
                    {
                        Commonforallfunctions.resetall();
                        break;
                    }
                }
                Console.WriteLine("Inside Checking");

            }
            enable_OK();
            

        }


        public void enable_OK()
        {
            //this is used to pass the function to GUI thread
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Invoker(enable_OK), null);
                return;
            }
            else
            {
                
                OK_tool.Enabled = true;
                LineStyle_tool.Enabled = false;//now we dont need line style
                this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;//since thread ended so change cursor to default
                
                
            }



        }

        private void OK_tool_Click(object sender, EventArgs e)
        {
            int aid=0;
            Console.WriteLine("Scale bool" + Commonforallfunctions.getsetscalebool());
            if (Commonforallfunctions.getlinebool())//then line operation was requested
            {
                if (Commonforallfunctions.listofpoints.Count >= 2)
                {
                    Commonforallfunctions.calculatemultipoint_length();
                    //fill the remaining values in line class
                    line_class.setendpoints();
                    
                    line_class.points = (ArrayList)Commonforallfunctions.getlistofpoints().Clone();
                    line_class.line_length = Commonforallfunctions.getlength();
                    //  line_class.line_pen = (Pen)form_linestyledetails.returnpen().Clone();//pen of line class set
                    line_class.line_pen = currentpen;
                    Console.WriteLine("Length Calculated is :" + line_class.line_length);
                    //here vector type use to store all line drawn on picture box
                    ProjectClass.db_cmd.CommandText = "INSERT INTO lines (name, x1, y1, x2, y2, color, length, display,line_style) VALUES (@name, @x1, @y1, @x2, @y2, @color, @length, 1,@line_style);";
                    ProjectClass.db_cmd.Parameters.AddWithValue("@name", line_class.line_name);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@x1", line_class.start.X);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@y1", line_class.start.Y);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@x2", line_class.end.X);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@y2", line_class.end.Y);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@color", line_class.line_pen.Color.ToArgb());
                    ProjectClass.db_cmd.Parameters.AddWithValue("@length", line_class.line_length);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@line_style", line_class.line_pen.DashStyle.ToString());
                    ProjectClass.db_cmd.ExecuteNonQuery();
                    //Added  by SAM for tree

                    //add the points in line_points table
                    int lid;
                    //Read lid from DB
                    ProjectClass.db_cmd.CommandText = "SELECT max(lid) FROM lines;";
                    ProjectClass.db_data = ProjectClass.db_cmd.ExecuteReader();
                    if (ProjectClass.db_data.Read())
                    {
                        lid = ProjectClass.db_data.GetInt32(0);
                        ProjectClass.db_data.Close();

                        int pointscount = line_class.points.Count;
                        PointF[] PolygonPoints = new PointF[pointscount];
                        for (int i = 0; i < pointscount; i++)
                        {
                            PointF pt = (PointF)line_class.points[i];
                            ProjectClass.db_cmd.CommandText = "INSERT INTO line_points (lid, x, y) VALUES (@lid, @x, @y);";
                            ProjectClass.db_cmd.Parameters.AddWithValue("@x", pt.X);
                            ProjectClass.db_cmd.Parameters.AddWithValue("@y", pt.Y);
                            ProjectClass.db_cmd.Parameters.AddWithValue("@lid", lid);
                            ProjectClass.db_cmd.ExecuteNonQuery();
                        }
                        line_list.Nodes.Add(new TreeNode(line_class.line_name));
                        vector_lines.Add(line_class);
                    }
                }
                this.pictureBox1.Invalidate();
                this.pictureBox1.Update();
                

            }
            else if (Commonforallfunctions.getsetscalebool())
            {
                
                Commonforallfunctions.calculate_length();
                Console.WriteLine(scale_value);
                //open scale details form

                form_scaledetails = new ScaleDetails(Commonforallfunctions.getlength());
                form_scaledetails.ShowDialog();
                if (ImagePropertiesClass.scale_set)
                {
                    //put end points in db and set values in ImagePropertiesClass
                  
                    //now scale is set show its value in toolStrip
                    toolStripStatus_scale.Text = "Scale Set 1:"+ImagePropertiesClass.scale_value;
                }

            }
            else if (Commonforallfunctions.getareabool())
            {
                if (Commonforallfunctions.listofpoints.Count >= 2) //
                {   
                    if (Commonforallfunctions.listofpoints.Count == 2)
                    {
                        area_class.shape = "circle";
                    }
                    Commonforallfunctions.calculate_area();//calculate area
                   area_class.radius= Commonforallfunctions.getradius();
                    area_class.area_value = Commonforallfunctions.getarea();//put area value in database
                    area_class.areapoints = (ArrayList)Commonforallfunctions.getlistofpoints().Clone();
                    area_class.area_pen = currentpen;
                    //add to temporay arraylist till database is not being used
                    Console.WriteLine("Inside writing to db");
                    ProjectClass.db_cmd.CommandText = "INSERT INTO areas (name, color, area, display,area_style,radius,shape) VALUES (@name, @color, @area, 1,@area_style,@radius,@shape);";
                    ProjectClass.db_cmd.Parameters.AddWithValue("@name", area_class.area_name);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@color", area_class.area_pen.Color.ToArgb());
                    ProjectClass.db_cmd.Parameters.AddWithValue("@area", area_class.area_value);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@area_style", area_class.area_pen.DashStyle.ToString());
                    ProjectClass.db_cmd.Parameters.AddWithValue("@radius", area_class.radius);
                    ProjectClass.db_cmd.Parameters.AddWithValue("@shape", area_class.shape);

                    ProjectClass.db_cmd.ExecuteNonQuery();

                    //Read iid from DB
                    ProjectClass.db_cmd.CommandText = "SELECT max(aid) FROM areas;";
                    ProjectClass.db_data = ProjectClass.db_cmd.ExecuteReader();
                    if (ProjectClass.db_data.Read())
                        aid = ProjectClass.db_data.GetInt32(0);
                    ProjectClass.db_data.Close();

                    int pointscount = area_class.areapoints.Count;
                    PointF[] PolygonPoints = new PointF[pointscount];
                    for (int i = 0; i < pointscount; i++)
                    {
                        PointF pt = (PointF)area_class.areapoints[i];
                        ProjectClass.db_cmd.CommandText = "INSERT INTO area_points (aid, x, y) VALUES (@aid, @x, @y);";
                        ProjectClass.db_cmd.Parameters.AddWithValue("@x", pt.X);
                        ProjectClass.db_cmd.Parameters.AddWithValue("@y", pt.Y);
                        ProjectClass.db_cmd.Parameters.AddWithValue("@aid", aid);
                        ProjectClass.db_cmd.ExecuteNonQuery();
                    }

                    //Added  by SAM for tree//also add value of area
                    area_list.Nodes.Add(new TreeNode(area_class.area_name));
                    vector_areas.Add(area_class);
                    Console.WriteLine("Sahpe:" + area_class.shape + "Area" + area_class.area_value);
                    Console.WriteLine("Inside writing to db so length area:" + vector_areas.Count);
                    this.pictureBox1.Invalidate();
                    this.pictureBox1.Update();
                }
            }
            Commonforallfunctions.resetall();
            functiontime_settools(true);
            this.Cancel_tool.Enabled = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            int x = MousePosition.X; // Get the Mouse Position x co-ordinate
            int y = MousePosition.Y; // Get the Mouse Position y co-ordinate
            MouseEventArgs m = (MouseEventArgs)e;
            position_StatusStrip.Text = " X=" + m.X / zoomfactor + " Y=" + m.Y / zoomfactor;
            if (Commonforallfunctions.getdrawbool())
            {
                int count=Commonforallfunctions.listofpoints.Count;
                if (count != 0&&!Commonforallfunctions.getcalculationthread_finishbool())
                {
                  
                    Pen p = currentpen;
                    PointF p1 = (PointF)Commonforallfunctions.listofpoints[count - 1];//get the last entered point in list
                    p1.X *= ImagePropertiesClass.getzoomfactor();
                    p1.Y *= ImagePropertiesClass.getzoomfactor();
                    Graphics g = this.pictureBox1.CreateGraphics();
                    this.pictureBox1.Invalidate();
                    this.pictureBox1.Update();
                    g.DrawLine(p, p1, e.Location);
                    Commonforallfunctions.calculatemultipoint_length();
                    if(Commonforallfunctions.getlinebool())//line opration
                    {
                        float length_value = Commonforallfunctions.getlength();
                        float zoom = ImagePropertiesClass.getzoomfactor();
                       length_value  =length_value+ (float)Math.Sqrt(Math.Pow((p1.X/zoom - e.X/zoom), 2)+Math.Pow((p1.Y/zoom-e.Y/zoom),2));
                         g.TranslateTransform(p1.X, p1.Y);
                         g.DrawString( (length_value * ImagePropertiesClass.scale_value).ToString("f2") + ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(0, 0));

                    }


                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Console.WriteLine("!!!!!!!!Inside paint now!!!!!!");
            Graphics g = e.Graphics;//graphics object on which drawing done

            draw_Lines(g);
            draw_Areas(g);
            draw_Scale(g);
            //used for drawing current area which is not saved into database yet
            if (Commonforallfunctions.getareabool())
            {
                int countareapoints = Commonforallfunctions.getlistofpoints().Count;
                ArrayList templist=Commonforallfunctions.getlistofpoints();
                if (countareapoints> 1)//atleast 2 points are required for drawing line
                {
                    PointF[] PolygonPoints = new PointF[countareapoints];
                    for (int i = 0; i < countareapoints; i++)
                    {
                        PointF temp = (PointF)templist[i];
                        temp.X *= ImagePropertiesClass.getzoomfactor();
                        temp.Y *= ImagePropertiesClass.getzoomfactor();
                        PolygonPoints[i] = temp;
                    }

                    g.DrawPolygon(currentpen,PolygonPoints);
                   
                }
            }

            if (Commonforallfunctions.getlinebool())
            {
                int countlinepoints = Commonforallfunctions.getlistofpoints().Count;
                ArrayList templist = Commonforallfunctions.getlistofpoints();
                if (countlinepoints > 1)//atleast 2 points are required for drawing line
                {
                    PointF[] PolygonPoints = new PointF[countlinepoints];
                    for (int i = 0; i < countlinepoints; i++)
                    {
                        PointF temp = (PointF)templist[i];
                        temp.X *= ImagePropertiesClass.getzoomfactor();
                        temp.Y *= ImagePropertiesClass.getzoomfactor();
                        PolygonPoints[i] = temp;
                    }

                    g.DrawLines(currentpen, PolygonPoints);

                }
            }


        }
        
        public void draw_Lines(Graphics g)
        {
            
            //following used to draw lines stored in the database with display value 1
          
            int count=vector_lines.Count;
            Console.WriteLine("Inside paint  Lines drawn:" + count);
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Line temp = (Line)vector_lines[i];
                     //from retrieve
                   // temp.drawthisline(g, ImagePropertiesClass.getzoomfactor());
                    temp.drawthismultipointline(g, ImagePropertiesClass.getzoomfactor());
                    Console.WriteLine("!!!!!!!!!!!!LIne Length!!!!!!" + temp.line_length);
                    Console.WriteLine("value in vector " + i + temp.start + " " + temp.end);
                }
            }
          }
          public void draw_Areas(Graphics g)
          {
              //following used to draw area stored in the database with display value 1
              int countarea = vector_areas.Count;//area entities to be drawn
              Console.WriteLine("Inside paint Areas drawn:" + countarea);
              if (countarea != 0)
              {
                  for (int i = 0; i < countarea; i++)
                  {
                      Area a = (Area)vector_areas[i];

                      a.drawthisarea(g, ImagePropertiesClass.getzoomfactor());


                  }
              }

          }
         public void draw_Scale(Graphics g)
         {
             if (ImagePropertiesClass.scale_set)//if scale has been set then draw the scale
             {
                 float zoom = ImagePropertiesClass.getzoomfactor();
                 g.DrawLine(ImagePropertiesClass.scalepen, ImagePropertiesClass.scale_startpt.X * zoom, ImagePropertiesClass.scale_startpt.Y * zoom, ImagePropertiesClass.scale_endpt.X * zoom, ImagePropertiesClass.scale_endpt.Y * zoom);
                 Console.WriteLine("Value of Scale points are!!!!!!!!!!!!!!");
                 Console.WriteLine(ImagePropertiesClass.scale_startpt.X * zoom + "  " + ImagePropertiesClass.scale_startpt.Y * zoom + "  " + ImagePropertiesClass.scale_endpt.X * zoom + "  " + ImagePropertiesClass.scale_endpt.Y * zoom + " " + ImagePropertiesClass.scale_set);
             }
          }

        private void ZoomIn_tool_Click(object sender, EventArgs e)
        {
            try
            {
                if (zoomfactor < 2.0f)
                    zoomfactor += .2f;
                else
                    zoomfactor = 2.0f;
                ImagePropertiesClass.setzoomfactor(0.2f);//increase zoom value
                if (ImagePropertiesClass.getzoomfactor() >= 2.0f)//max zoom factor value is 2.0
                    ImagePropertiesClass.resetzoomto(2.0f);
                float temp = (float)ImagePropertiesClass.getzoomfactor();
                pictureBox1.Image = PictureBoxZoom(ImagePropertiesClass.originalImage, new SizeF(temp, temp));
                //to repaint so that lines are aligned wrt to zoom value
                this.pictureBox1.Invalidate();
                this.pictureBox1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error msg: " + ex.ToString());
       
            }
         
        }

        private void Zoomout_tool_Click(object sender, EventArgs e)
        {


          
            if (zoomfactor > 0.2f)
                zoomfactor -= .2f;
            else
                zoomfactor = 0.2f;
            ImagePropertiesClass.setzoomfactor(-0.2f);//decrease zoom value
            if (ImagePropertiesClass.getzoomfactor() < 0.2f)
                ImagePropertiesClass.resetzoomto(0.2f);
            float temp = (float)ImagePropertiesClass.getzoomfactor();
            pictureBox1.Image = PictureBoxZoom(ImagePropertiesClass.originalImage, new SizeF(temp, temp));
            //to repaint so that lines are aligned wrt to zoom value
            this.pictureBox1.Invalidate();
            this.pictureBox1.Update();


        }


         public Image PictureBoxZoom(Image img, SizeF size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

         private void Normal_tool_Click(object sender, EventArgs e)
         {
             zoomfactor = 1.0f;
             ImagePropertiesClass.resetzoomto(1.0f);//set zoom value
             float temp = (float)ImagePropertiesClass.getzoomfactor();
             pictureBox1.Image = PictureBoxZoom(ImagePropertiesClass.originalImage, new SizeF(temp, temp));
             //to repaint so that lines are aligned wrt to zoom value
             this.pictureBox1.Invalidate();
             this.pictureBox1.Update();
         }

         private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (MessageBox.Show("Are you sure you want to exit?", "Confirm Application Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
             {

             }
             else
                 e.Cancel = true;
         }

         private void exitToolStripMenuItem_Click(object sender, EventArgs e)
         {

             if (MessageBox.Show("Are you sure you want to exit?", "Confirm Application Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 Application.Exit();
             }
            
         }

         private void aboutMeasureITOnScreenToolStripMenuItem_Click(object sender, EventArgs e)
         {
             About_MIT about = new About_MIT();
             about.ShowDialog();
             
         }

         private void closeProjecttoolStripMenuItem_Click(object sender, EventArgs e)
         {
             ProjectClass.closeProject();
         }

         private void generateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
         {
             SQLiteDataReader db_data_local_1;
             SQLiteCommand db_cmd_local_1 = ProjectClass.db_con.CreateCommand(); ;

             SQLiteDataReader db_data_local_2;
             SQLiteCommand db_cmd_local_2 = ProjectClass.db_con.CreateCommand(); ;


             //writing to lines.csv file
             TextWriter lines_tw = new StreamWriter(ProjectClass.dataDirPath + "\\Lines.csv");

             db_cmd_local_1.CommandText = "SELECT name, length FROM lines;";
             db_data_local_1 = db_cmd_local_1.ExecuteReader();
             int i = 1;
             lines_tw.WriteLine("Scale units," + ImagePropertiesClass.scale_unit);
             lines_tw.WriteLine("\n");
             lines_tw.WriteLine("S.No,Line Name,Value(" + ImagePropertiesClass.scale_unit + ")");

             while (db_data_local_1.Read())
             {
                 lines_tw.WriteLine(i++ + "," + db_data_local_1.GetString(0) + " , " + db_data_local_1.GetFloat(1) * ImagePropertiesClass.scale_value);
             }
             lines_tw.Close();

             //writing to areas.csv file
             TextWriter areas_tw = new StreamWriter(ProjectClass.dataDirPath + "\\Areas.csv");
             areas_tw.WriteLine("Scale units," + ImagePropertiesClass.scale_unit);
             areas_tw.WriteLine("\n");
             areas_tw.WriteLine("S.No,Area Name,Value(" + ImagePropertiesClass.scale_unit + ")");
             db_cmd_local_2.CommandText = "SELECT name, area FROM areas;";
             db_data_local_2 = db_cmd_local_2.ExecuteReader();
             i = 1;
             while (db_data_local_2.Read())
             {
                 areas_tw.WriteLine(i++ + "," + db_data_local_2.GetString(0) + "," + db_data_local_2.GetFloat(1) * ImagePropertiesClass.scale_value);
             }
             areas_tw.Close();

         }

         private void printToolStripMenuItem_Click(object sender, EventArgs e)
         {
             printDialog1.Document = printDocument1;

             if (printDialog1.ShowDialog() == DialogResult.OK)
             {
                 printDocument1.Print();

             }
         }

         private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             //Graphics p = panel2.CreateGraphics();
             Graphics g = e.Graphics;
             Graphics img_g = Graphics.FromImage(ImagePropertiesClass.originalImage);
             draw_Lines(img_g);
             draw_Areas(img_g);
             draw_Scale(img_g);

             //e.Graphics = this.pictureBox1;
             //OnPaint(p.);
             //e.Graphics = p;
             //Bitmap bm = new Bitmap(pictureBox1.Image);
             //pictureBox1.DrawToBitmap(bm);
             //Graphics g = pictureBox1.Image.
             e.Graphics.DrawImage(pictureBox1.Image, new Point(-14, -15));
             //pictureBox1_Paint(sender, e);
            
         }

         private void printPriviewToolStripMenuItem_Click(object sender, EventArgs e)
         {
             printPreviewDialog1.Document = printDocument1;
             //printPreviewDialog1.BorderStyle = FormBorderStyle.Fixed3D;
             printPreviewDialog1.ShowDialog();
         }

         
    }
}
