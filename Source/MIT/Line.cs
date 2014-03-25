using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Drawing.Drawing2D;

namespace mit
{
    class Line
    {
        public string line_name;
        public Pen line_pen;
        public PointF start, end,midpoint;
        public float line_length;
        public ArrayList points;
        public int lid;
        public Line()
        {
            start = new Point();
            end = new Point();
            points = new ArrayList();
            line_pen = new Pen(Color.Black, 2);//used if no pen set from line style
            
        }

        public void drawthisline(Graphics g,float zoom)
        {
            midpoint = new PointF((start.X + end.X) / 2, (start.Y + end.Y) / 2); 
            g.DrawLine(line_pen, start.X*zoom,start.Y*zoom,end.X*zoom,end.Y*zoom);
            g.TranslateTransform(start.X*zoom, start.Y*zoom);
       //    m.Rotate((float)Math.Atan((start.Y - end.Y) / (start.X - end.Y)),MatrixOrder.Append);
            float degree=(float)((180/Math.PI)*Math.Atan((start.Y - end.Y) / (start.X - end.Y)));
            Console.WriteLine("Value of degree:"+degree);
            //.WriteLine("Distance is {0}", distanceinmetres.ToString("f2"));
            //g.RotateTransform(degree);
            g.DrawString(line_name+": "+(line_length*ImagePropertiesClass.scale_value).ToString("f2")+ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black,new PointF(0,0));
            g.ResetTransform();

        }

        public void drawthismultipointline(Graphics g,float zoom)
        { Console.WriteLine("!!!!!!!!!!!!LIne Length!!!!!! before if clause ponits size:" + line_length+" "+points.Count);

            
            if (points.Count != 0)
            {Console.WriteLine("!!!!!!!!!!!!LIne Length!!!!!!after if clause" + line_length);

                int pointscount = points.Count;
                PointF[] PolygonPoints = new PointF[pointscount];
                for (int i = 0; i < pointscount; i++)
                {
                    PointF temp = (PointF)points[i];
                    temp.X *= zoom;
                    temp.Y *= zoom;
                    PolygonPoints[i] = temp;
                }
                    g.DrawLines(line_pen, PolygonPoints);

                    // Console.WriteLine("!!!!!!!!!!!!LIne Length!!!!!!" + line_length);

                    g.DrawString(line_name + ": " + (line_length * ImagePropertiesClass.scale_value).ToString("f2") +  ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(PolygonPoints[0].X, PolygonPoints[0].Y));


                }
             
              
            }
            
        
        public void setendpoints()
        {
            ArrayList list=Commonforallfunctions.getlistofpoints();
            int count = list.Count;
            start = (PointF)list[0];
            end = (PointF)list[count-1];
        }
    }
}
