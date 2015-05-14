/*
* file: Graphic.cs
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
    class Graphic
    {
        private Boolean rubberBanding;
        private String tool;
        private Rectangle rect = new Rectangle();

        private Point startPoint;
        private Point endPoint;

        private Pen pen = new Pen(Color.Black, 1);
        private SolidBrush brush = new SolidBrush(Color.White);

        private GraphicsPath gp = new GraphicsPath();
        //Default Constructor
        public Graphic()
        {
            rubberBanding = false;
            tool = "none";

            startPoint = new Point(0, 0);
            endPoint = new Point(0, 0);
        }
        /*
         * Name : RubberBanding
         * Disc : Handles and rubber banding for the 3 available shapes
        */
        public Boolean RubberBanding
        {
            set 
            { 
                rubberBanding = value;
                if (rubberBanding)
                {
                    pen.DashPattern = new float[] { 2, 2 };
                }
                else
                {
                    pen.DashPattern = new float[] { 2 };
                }
            }
            get { return rubberBanding; }
        }


        //Tool - Getter/Setter
        public String Tool
        {
            set { tool = value; }
            get { return tool; }
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

        //Pen - Getter/Setter
        public Pen Pen
        {
            set { pen = value; }
            get { return pen; }
        }

        //Brush - Getter/Setter
        public SolidBrush Brush
        {
            set { brush = value; }
            get { return brush; }
        }

        /*
         * Name : CreateRectangleBox
         * Disc : Creates a retangle box for the RECTANGLE and the CIRCLE to use.
         *      : This is a base for the creation of a rectangle and circle
        */
        private void CreateRectangleBox()
        {
            int rectStartX = 0;
            int rectStartY = 0;
            int rectEndX = 0;
            int rectEndY = 0;

            if (StartPoint.X > EndPoint.X)
            {
                rectStartX = EndPoint.X;
                rectEndX = StartPoint.X;
            }
            else if (StartPoint.X < EndPoint.X)
            {
                rectStartX = StartPoint.X;
                rectEndX = EndPoint.X;
            }

            if (StartPoint.Y > EndPoint.Y)
            {
                rectStartY = EndPoint.Y;
                rectEndY = StartPoint.Y;
            }
            else if (StartPoint.Y < EndPoint.Y)
            {
                rectStartY = StartPoint.Y;
                rectEndY = EndPoint.Y;
            }

            rect = new Rectangle(rectStartX, rectStartY, rectEndX - rectStartX, rectEndY - rectStartY);
        }

        /*
         * Name : DrawCircle
         * Disc : Draws a circle to the screen with a predefined:
         *      : PEN to draw the shape
         *      : BRUSH to fill the shape
        */
        public void DrawCircle(PaintEventArgs e)
        {
            CreateRectangleBox();
            e.Graphics.FillEllipse(brush, rect);
            e.Graphics.DrawEllipse(pen, rect);
        }

        /*
         * Name : DrawRectangle
         * Disc : Draws a Rectangle to the screen with a predefined:
         *      : PEN to draw the shape
         *      : BRUSH to fill the shape
        */
        public void DrawRectangle(PaintEventArgs e)
        {
            CreateRectangleBox();
            e.Graphics.FillRectangle(brush, rect);
            e.Graphics.DrawRectangle(pen, rect);
        }

        /*
         * Name : DrawLine
         * Disc : Draws a Line to the screen with a predefined:
         *      : PEN to draw the shape
        */
        public void DrawLine(PaintEventArgs e)
        {
            gp.Reset();
            gp.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
            e.Graphics.DrawPath(pen, gp);
        }
    }
}
