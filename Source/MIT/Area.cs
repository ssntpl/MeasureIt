using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;

namespace mit
{
    class Area
    {
        public string area_name;
        public Pen area_pen;
        public float radius;
        public float area_value;
        public ArrayList areapoints;
        public int aid;
        //make an attribute called as shape--its default value is "polygon"
        public string shape;
        float mean_x, mean_y;//to calculation location for displaying area values calculated
        public Area()
        {
            shape = "polygon";
            area_pen = new Pen(Color.Black, 2);//used if no pen set from line style
            radius = 0.0f;
        }
        public void drawthisarea(Graphics g, float zoom)
        {
            if (this.shape == "polygon")
            {

                int pointscount = areapoints.Count;
                PointF[] PolygonPoints = new PointF[pointscount];
                for (int i = 0; i < pointscount; i++)
                {
                    PointF temp = (PointF)areapoints[i];
                    temp.X *= zoom;
                    temp.Y *= zoom;
                    PolygonPoints[i] = temp;
                    mean_x = mean_x + temp.X;
                    mean_y = mean_y + temp.Y;
                }
                mean_x = mean_x / pointscount;
                mean_y = mean_y / pointscount;
                g.DrawPolygon(area_pen, PolygonPoints);
              //g.DrawString(area_name + ": " + (area_value * ImagePropertiesClass.scale_value * ImagePropertiesClass.scale_value).ToString("f2") + "sq "+ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(mean_x,mean_y));
                g.DrawString(area_name + ": " + (area_value * ImagePropertiesClass.scale_value * ImagePropertiesClass.scale_value).ToString("f2") + "sq " + ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(PolygonPoints[0].X, PolygonPoints[0].Y));

            }

            else
            {
                PointF p1 = (PointF)areapoints[0];
                PointF p2 = (PointF)areapoints[1];
                float midpoint_x=((p1.X+p2.X)/2 - radius)*zoom;
                float midpoint_y = ((p1.Y + p2.Y) / 2 - radius) * zoom;   
               g.DrawEllipse(area_pen, new RectangleF(midpoint_x, midpoint_y, radius*2*zoom, radius*2*zoom));
               g.DrawString(area_name + ": " + (area_value * ImagePropertiesClass.scale_value * ImagePropertiesClass.scale_value).ToString("f2") + "sq " + ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(midpoint_x + radius*zoom, midpoint_y + radius*zoom));
               g.DrawLine(area_pen, midpoint_x + radius * zoom, midpoint_y + radius * zoom, midpoint_x + radius * zoom * 2, midpoint_y + radius * zoom);
               g.DrawString("R: " + (radius * ImagePropertiesClass.scale_value ).ToString("f2") + ImagePropertiesClass.scale_unit, new Font(FontFamily.GenericSerif, 10), Brushes.Black, new PointF(midpoint_x + radius * zoom, midpoint_y + radius * zoom - 14));
               
            }
        }
    }
}
