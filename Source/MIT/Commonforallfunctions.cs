using System;
using System.Collections;
using System.Drawing;
using System.Data.SQLite;
namespace mit
{
    class Commonforallfunctions
    {
       static bool drawing=false;//interactive drawing
      static bool click_detected = false;//click inside picturebox
      static bool cancel_function = false;//cancel click to finish thread if cancel clicked then value is true
      static bool calculationthread_finish = false;//this is used to check if the calculation thread is finished.
                                                     //so that ok button could be activated.         
      static bool Recordpoints = false;//this is used to indicate start of calculation thread it will tell when to click points in picture box into list
                                                 
      static PointF currentclicked_point=new Point();
     public static ArrayList listofpoints=new ArrayList() ;//points clicked

     //to find which function clicked/requested by user
     static bool line_operation=false;
     static bool setscale_operation = false;
     static bool area_operation = false;
     static bool count_operation = false;

        // calculated result value
        static float length_value;
        static float area_value;
        static float radius;
        //default pen
        static Pen defaultpen =new Pen(Color.Black, 2);
        
        //getting pen
        public static Pen getdefaultpen()
        {
            return defaultpen;
        }
        //for click_detected
           public static void setclickbool(bool b)
           {
               click_detected=b;
           }

            public static bool getclickbool()
            {
                return click_detected;
            }
        //for drawing
            public static void setdrawbool(bool b)
            {
                drawing = b;
            }

            public static bool getdrawbool()
            {
                return drawing;
            }

            //for calculationthread_finish
            public static void setcalculationthread_finishbool(bool b)
            {
                calculationthread_finish = b;
            }

            public static bool getcalculationthread_finishbool()
            {
                return calculationthread_finish;
            }


            //for Recordpoints
            public static void setRecordpointsbool(bool b)
            {
                Recordpoints = b;
            }

            public static bool getRecordpointsbool()
            {
                return Recordpoints;
            }

        //for currentclicked_point
            public static void setcurrentpoint(PointF p,float zoom)
            {//point taken to its original form
                p.X/=zoom;
                    p.Y/=zoom;
                currentclicked_point = p;
                listofpoints.Add(p);
                Console.WriteLine(listofpoints.ToString());
            }
           
            public static PointF getcurrentpoint()
            {
                return currentclicked_point;
            }


            public static ArrayList getlistofpoints()
            {

                return listofpoints;
            }
        //for cancel_function
            public static void setcancelbool(bool b)
            {
                cancel_function = b;
            }

            public static bool getcancelbool()
            {
                return cancel_function;
            }

            //for setscale 
            public static void setsetscalebool(bool b)
            {
                setscale_operation = b;
            }

            public static bool getsetscalebool()
            {
                return setscale_operation;
            }

            //for line 
            public static void setlinebool(bool b)
            {
                line_operation = b;
            }

            public static bool getlinebool()
            {
                return line_operation ;
            }

            //for area 
            public static void setareabool(bool b)
            {
               area_operation = b;
            }

            public static bool getareabool()
            {
                return area_operation;
            }
        //to reset all the values
            public static void resetall()
            {
                drawing = false;
                click_detected = false;
                cancel_function = false;
                calculationthread_finish = false;
                listofpoints.Clear();
                area_value = 0.0f;
                length_value = 0.0f;
                radius = 0.0f;
                //reset oprations bool
                area_operation = false;
                line_operation = false;
                setscale_operation = false;
                
                
            }
        //to resetonly boolean values
            public static void resetall_bool()
            {
                drawing = false;
                click_detected = false;
                cancel_function = false;
                calculationthread_finish = false;
                Recordpoints = false;
                //reset operations bool
                area_operation = false;
                line_operation = false;
                setscale_operation = false;


            }


        public  static void clear_listofpoints()
        {
            listofpoints.Clear();
        }
        public static void  calculate_length()
        {
            int count;
            PointF p1,p2;
            p1=new PointF();
            p2 =new PointF();
           
            if((count=listofpoints.Count)!=0)
            {
                p1 = (PointF)listofpoints[0];
                Console.WriteLine(p1);
                p2 = (PointF)listofpoints[1];
                Console.WriteLine(p2);
                length_value = (float)Math.Sqrt(Math.Pow((p1.X - p2.X), 2)+Math.Pow((p1.Y-p2.Y),2));
               
            
            }
            Console.WriteLine("Value in func: " + length_value);
        }

        public static void calculatemultipoint_length()
        {
            length_value = 0.0f;
            
            PointF p1,p2;
            p1=new PointF();
            p2 =new PointF();
            for (int i = 0; i < listofpoints.Count - 1; i++)
            {
                p1 = (PointF)listofpoints[i];
                p2 = (PointF)listofpoints[i+1];
                length_value += (float)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));

                
            }
                
        }
        public static void calculate_area()
        {
            area_value = 0.0f;

            if (listofpoints.Count == 2)
            {
                calculate_length();
                radius = length_value / 2;
                area_value = (float)Math.PI * radius * radius;

            }
            else
            {
                PointF p1, p2;
                for (int i = 0; i < listofpoints.Count; i++)
                {
                    p1 = (PointF)listofpoints[i];

                    if (i == listofpoints.Count - 1)
                    {
                        p2 = (PointF)listofpoints[0];
                    }
                    else
                    {
                        try
                        {
                            p2 = (PointF)listofpoints[i + 1];
                        }
                        catch (Exception e)
                        {
                            p2 = new PointF(0, 0);
                        }
                    }
                    area_value += det(p1, p2);
                }
            }
                Console.WriteLine("Value in func: " + area_value);
        }

        static float det(PointF p1, PointF p2)
        {
            return (p1.X * p2.Y - p1.Y * p2.X);
        }
        public static float getlength()
        {
            return length_value;
            }

        public static float getarea()
        {
            return area_value;
        }

        public static void set_scalepoints()
        {
            ImagePropertiesClass.scale_startpt = (PointF)listofpoints[0];
            ImagePropertiesClass.scale_endpt = (PointF)listofpoints[1];
        }
        public static float getradius()
        {
            return radius;
        }
    }
}
