/*
* file: Shape.cs
* programmers: Grigory Kozyrev & Connor McQuade
* date: 10/7/2014
* purpose: 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SETPaint
{
    class Shape
    {
        public const String kTypeCircle = "Circle";
        public const String kTypeRectangle = "Rectangle";
        public const String kTypeLine = "Line";

        private String type;

        private Point startPoint;
        private Point endPoint;

        private Color borderColor;
        private Color fillColor;
        private float borderWidth;

        private Graphic graph = new Graphic();
        //Default Shape Constructor
        public Shape()
        {
            type = kTypeLine;

            startPoint = new Point(0, 0);
            endPoint = new Point(0, 0);

            borderColor = Color.Black;
            fillColor = Color.White;
            borderWidth = 1;
        }
        //Shape Constructor
        public Shape(String newType, Point newStartPoint, Point newEndPoint, 
                     Color newBorderColor, Color newFillColor, float newBorderWidth)
        {
            type = newType;

            startPoint = newStartPoint;
            endPoint = newEndPoint;

            borderColor = newBorderColor;
            fillColor = newFillColor;
            borderWidth = newBorderWidth;
        }
        //Shape Constructor
        public Shape(Shape newShape)
        {
            type = newShape.Type;

            startPoint = newShape.StartPoint;
            endPoint = newShape.EndPoint;

            borderColor = newShape.BorderColor;
            fillColor = newShape.FillColor;
            borderWidth = newShape.BorderWidth;
        }
        //Type - Getter/Setter
        public String Type
        {
            set { type = value; }
            get { return type; }
        }
        //RubberBanding - Getter/Setter
        public Boolean RubberBanding
        {
            set { graph.RubberBanding = value; }
            get { return graph.RubberBanding; }
        }
        //StartPoint - Getter/Setter
        public Point StartPoint
        {
            set { startPoint = value; }
            get { return startPoint; }
        }
        //EndPoint - Getter/Setter
        public Point EndPoint
        {
            set { endPoint = value; }
            get { return endPoint; }
        }
        //BorderColor - Getter/Setter
        public Color BorderColor
        {
            set { borderColor = value; }
            get { return borderColor; }
        }

        //FillColor - Getter/Setter
        public Color FillColor
        {
            set { fillColor = value; }
            get { return fillColor; }
        }
        //BorderWidth - Getter/Setter
        public float BorderWidth
        {
            set { borderWidth = value; }
            get { return borderWidth; }
        }

        public override String ToString()
        {
            String retString = type + "|";

            retString += StartPoint.X + "|" + StartPoint.Y + "|";
            retString += EndPoint.X + "|" + EndPoint.Y + "|";

            retString += borderColor.ToArgb().ToString() + "|";
            retString += fillColor.ToArgb().ToString() + "|";;

            retString += borderWidth.ToString();

            return retString;
        }

        public void FromString(String data)
        {
            String[] values = data.Split('|');

            Type = values[0];

            startPoint.X = Convert.ToInt32(values[1]);
            startPoint.Y = Convert.ToInt32(values[2]);
            endPoint.X = Convert.ToInt32(values[3]);
            endPoint.Y = Convert.ToInt32(values[4]);

            borderColor = Color.FromArgb(Convert.ToInt32(values[5]));
            fillColor = Color.FromArgb(Convert.ToInt32(values[6]));

            borderWidth = Convert.ToInt32(values[7]);
        }

        /*
         * Name : DrawShape
         * Disc : Draws a shape based on the shape type, the given points
         *      : the border color setting, the fill color setting, and the border width
        */
        public void DrawShape(PaintEventArgs e)
        {
            graph.StartPoint = startPoint;
            graph.EndPoint = endPoint;

            graph.Pen.Color = borderColor;
            graph.Pen.Width = borderWidth;
            graph.Brush = new SolidBrush(fillColor);

            if (type.Equals(kTypeCircle))
            {
                graph.DrawCircle(e);
            }
            else if (type.Equals(kTypeRectangle))
            {
                graph.DrawRectangle(e);
            }
            else if (type.Equals(kTypeLine))
            {
                graph.DrawLine(e);
            }
        }
    }
}
