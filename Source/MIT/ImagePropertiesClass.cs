using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace mit
{
     class ImagePropertiesClass
    {
        public static MainForm mainForm_imgprop;  
         static string ImageName;
         static public int ImageId;
         static public string ImagePath;
         static public Image originalImage;
         
         static float zoomfactor=1.0f;
         static public float scale_value;//value of one pixelin real length
         static public string scale_unit;//units in which measurements made. 
         static SizeF origimg_size;
         static SizeF currentimg_size;
         static public bool imageLoaded=false;//this is used to know whther image is loaded in picture box or no if
                                              //if loaded disable Add Image tool.


         //scale related details
         static public PointF scale_startpt = new PointF();
         static public PointF scale_endpt = new PointF();
         static public bool scale_set = false;//during load is scale is set 
         //then value loaded in scale_value attribute of ImageProperties class.
       

         //define pen to be used  for scale.
            public static Pen scalepen;
            public static void set_scalepen()
            {
               scalepen= new Pen(Color.BlueViolet, 3);
                scalepen.StartCap = LineCap.ArrowAnchor;
                scalepen.EndCap = LineCap.ArrowAnchor;
                scalepen.DashStyle = DashStyle.DashDot;
            }


        public static void setvalues(string img_name,int img_id,string img_path,Image org_img,SizeF org_size)
        {
            ImageName = img_name;
            ImageId = img_id;
            ImagePath = img_path;
            originalImage = org_img;
            origimg_size = org_size;
            currentimg_size = org_size;

        }
        public  static bool addImage(int iid)
        {
            //Just adds the node and create the required dynamic functions..

            //TODO
            //the function should also create an image class and object,
            //that has image properties and dynamic functions to the tree nodes

            SQLiteDataReader db_data_local;
            SQLiteCommand db_cmd_local = ProjectClass.db_con.CreateCommand(); ;

          

            //Read iid from DB
            db_cmd_local.CommandText = "SELECT name, extension FROM images WHERE iid='" + iid + "';";
            db_data_local = db_cmd_local.ExecuteReader();
            if (db_data_local.Read())
            {
                ImageName = db_data_local.GetString(0);
                ImagePath = System.IO.Path.Combine(ProjectClass.imageDirPath, iid + db_data_local.GetString(1));
            }
            db_data_local.Close();

            ////To add node in the first node of tree
            ////TreeNode mainNode = new TreeNode();
            ////mainNode.Name = iid.ToString();
            ////mainNode.Text = imageName;
            ////mainForm.treeView1.Nodes[0].Nodes.Add(mainNode);
            ////mainForm.treeView1.Nodes[0].ExpandAll();

            //TODO optional
            //EXCEPTION File not exist exception unhandeled

            mainForm_imgprop.pictureBox1.Image = Image.FromFile(ImagePath);
            imageLoaded = true;//image loaded in picturebox
            originalImage = Image.FromFile(ImagePath);     //added to perform zoom wrt original image
            origimg_size = originalImage.Size;          //stores actual height and width of image.
            zoomfactor = 1.0f;                                 //to reset the zoomFactor when new image is loaded
            // MessageBox.Show("Imageis" + chosenFile);
            // statusStrip1.Text = chosenFile;


            return true;
        }


        public static  bool addImage()
        {
            //To open browse image and then load image

            mainForm_imgprop.openFileDialog1.Title = "Select the Image";
            mainForm_imgprop.openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|TIFF|*.tiff|PDF|*.pdf";
            mainForm_imgprop.openFileDialog1.FileName = "";

            string chosenFile = "";
            string fileName = "";
            
            string imageExt = "";
            Random r = new Random();
            string randomFlag = r.Next().ToString();
           
            string newLocation = "";

            if (mainForm_imgprop.openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                chosenFile = mainForm_imgprop.openFileDialog1.FileName;


                fileName = System.IO.Path.GetFileName(chosenFile);
                ImageName = System.IO.Path.GetFileNameWithoutExtension(chosenFile);
                imageExt = System.IO.Path.GetExtension(chosenFile);

                //Add info to db
                ProjectClass.db_cmd.CommandText = "INSERT INTO images (name, extension, location, scale, scale_set, scale_x1, scale_y1, scale_x2, scale_y2) VALUES (@name, @extension, @location, 0, 0, 0, 0, 0, 0);";
                ProjectClass.db_cmd.Parameters.AddWithValue("@name", ImageName);
                ProjectClass.db_cmd.Parameters.AddWithValue("@extension", imageExt);
                ProjectClass.db_cmd.Parameters.AddWithValue("@location", randomFlag);
                ProjectClass.db_cmd.ExecuteNonQuery();

                //Read iid from DB
                ProjectClass.db_cmd.CommandText = "SELECT iid FROM images WHERE location='" + randomFlag + "';";
                ProjectClass.db_data = ProjectClass.db_cmd.ExecuteReader();
                if (ProjectClass.db_data.Read())
                    ImageId = ProjectClass.db_data.GetInt32(0);
                ProjectClass.db_data.Close();

                fileName = ImageId.ToString() + imageExt;
                newLocation = System.IO.Path.Combine(ProjectClass.imageDirPath, fileName);
                System.IO.File.Copy(chosenFile, newLocation);

                ProjectClass.db_cmd.CommandText = "UPDATE images SET location = @location WHERE location = @randomFlag;";
                ProjectClass.db_cmd.Parameters.AddWithValue("@location", newLocation);
                ProjectClass.db_cmd.Parameters.AddWithValue("@randomFlag", randomFlag);
                ProjectClass.db_cmd.ExecuteNonQuery();

                //To add image in tree and load in picturebox..
                return ProjectClass.addImage(ImageId);
            }
            else
                return false;
        }

        public static void resetvalues()
        {
                   
            ImageName="";
            ImageId=0;
            ImagePath="";
            zoomfactor=1.0f ;
            scale_value=0;
            imageLoaded=false;
        }

        public static void setzoomfactor(float zoom)
        {
            zoomfactor += zoom;
        }

        public static  void resetzoomto(float f)//to keep zoom values with limit of 0.2 to 2.0 and also reset to zoomvalue 1.0
        {
            zoomfactor = f;
        }
        public static float getzoomfactor()
        {
            return zoomfactor;
        }
        
         public static void update_areas(Graphics g)//called from paint
         {
             //take from database and show it
         }
         public static void update_lines(Graphics g)//called from paint
         {
             //take from database and show it
         }
    }
}
