/*
* file: Form.cs
* programmers: Grigory Kozyrev & Connor McQuade
* date: 10/7/2014
* purpose: 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETPaint
{
    public partial class Form1 : Form
    {
        Graphic graph = new Graphic();

        List<Shape> ShapeList = new List<Shape>();
        Shape tempShape = new Shape();

        ColorDialog colorPicker = new ColorDialog();
        ColorDialog colorBorderPicker = new ColorDialog();

        SaveFileDialog saveWindow = new SaveFileDialog();
        OpenFileDialog openWindow = new OpenFileDialog();

        DialogResult dialogEraseDrawing;

        public Form1()
        {
            InitializeComponent();

            saveWindow.DefaultExt = "spf";
            saveWindow.Filter = "SET Paint Format | *.spf";

            openWindow.DefaultExt = "spf";
            openWindow.Filter = "SET Paint Format | *.spf";
        }

        /*
         * Name : toolCircleButton_Click
         * Disc : Changes the shape the user wants to draw to a Circle
        */
        private void toolCircleButton_Click(object sender, EventArgs e)
        {
            if (tempShape.Type.Equals("Circle"))
            {
                tempShape.Type = "none";
                toolCircleButton.Checked = false;
            }
            else
            {
                tempShape.Type = "Circle";
                toolRectangleButton.Checked = false;
                toolLineButton.Checked = false;
                toolCircleButton.Checked = true;
            }
        }

        /*
         * Name : toolRectangleButton_Click
         * Disc : Changes the shape the user wants to draw to a Rectangle
        */
        private void toolRectangleButton_Click(object sender, EventArgs e)
        {
            if (tempShape.Type.Equals("Rectangle"))
            {
                tempShape.Type = "none";
                toolRectangleButton.Checked = false;
            }
            else
            {
                tempShape.Type = "Rectangle";
                toolCircleButton.Checked = false;
                toolLineButton.Checked = false;
                toolRectangleButton.Checked = true;
            }
        }

        /*
         * Name : toolLineButton_Click
         * Disc : Changes the shape the user wants to draw to a Line
        */
        private void toolLineButton_Click(object sender, EventArgs e)
        {
            if (tempShape.Type.Equals("Line"))
            {
                tempShape.Type = "none";
                toolLineButton.Checked = false;
            }
            else
            {
                tempShape.Type = "Line";
                toolCircleButton.Checked = false;
                toolRectangleButton.Checked = false;
                toolLineButton.Checked = true;
            }
        }

        /*
         * Name : drawArea_MouseDown
         * Disc : When the user click down the left-mouse trigger to draw a shape
         *      : the position is logged as the starting point for the
         *      : shape to be drawn with
        */
        private void drawArea_MouseDown(object sender, MouseEventArgs e)
        {
            tempShape.StartPoint = new Point(e.X, e.Y);
            tempShape.EndPoint = new Point(e.X, e.Y);
            tempShape.RubberBanding = true;

            drawArea.Invalidate();
        }

        /*
         * Name : drawArea_MouseUp
         * Disc : When the user lets go of the left-mouse trigger the mouse to draw a shape
         *      : the position is logged as the end point for the
         *      : shape to be drawn with
        */
        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            tempShape.EndPoint = new Point(e.X, e.Y);
            tempShape.RubberBanding = false;
            ShapeList.Add(new Shape(tempShape));

            tempShape.StartPoint = new Point(0, 0);
            tempShape.EndPoint = new Point(0, 0);

            drawArea.Invalidate();
        }

        /*
         * Name : drawArea_Paint
         * Disc : Draws the shape the user had selected based on the points from MouseDown and MouseUp
        */
        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in ShapeList)
            {
                shape.DrawShape(e);
            }

            tempShape.DrawShape(e);

        }

        /*
         * Name : drawArea_MouseMove
         * Disc : Displays the current X/Y coordinates of the cursor on the UI.
        */
        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Equals(MouseButtons.Left))
            {
                tempShape.EndPoint = new Point(e.X, e.Y);
                statusLabel.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
                drawArea.Invalidate();
            }
            else
            {
                statusLabel.Text = "";
            }
        }

        /*
         * Name : toolBorderColor_Click
         * Disc : Allows the user to change the color of a shapes border
         *      : these shapes include: Circle, Rectangle, and Line
        */
        private void toolBorderColor_Click(object sender, EventArgs e)
        {
            colorBorderPicker.Color = toolBorderColor.BackColor;
            colorBorderPicker.ShowDialog();
            toolBorderColor.BackColor = colorBorderPicker.Color;

            tempShape.BorderColor = colorBorderPicker.Color;
        }

        /*
         * Name : toolFillColor_Click
         * Disc : Allows the user to change the color of a shapes fill
         *      : these shapes include: Circle, and Rectangle
        */
        private void toolFillColor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = toolFillColor.BackColor;
            colorPicker.ShowDialog();
            toolFillColor.BackColor = colorPicker.Color;

            tempShape.FillColor = colorPicker.Color;
        }

        /*
         * Name : pxTool1px_Click
         * Disc : changes the shapes border width to 1px
        */
        private void pxTool1px_Click(object sender, EventArgs e)
        {
            tempShape.BorderWidth = 1;
        }

        /*
         * Name : pxTool3px_Click
         * Disc : changes the shapes border width to 3px
        */
        private void pxTool3px_Click(object sender, EventArgs e)
        {
            tempShape.BorderWidth = 3;
        }

        /*
         * Name : pxTool5px_Click
         * Disc : changes the shapes border width to 5px
        */
        private void pxTool5px_Click(object sender, EventArgs e)
        {
            tempShape.BorderWidth = 5;
        }

        /*
         * Name : pxTool8px_Click
         * Disc : changes the shapes border width to 8px
        */
        private void pxTool8px_Click(object sender, EventArgs e)
        {
            tempShape.BorderWidth = 8;
        }

        /*
         * Name : aboutButton_Click
         * Disc : displays an aboutBox that shows the details of the makers of the program
        */
        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.ShowDialog();
        }

        /*
         * Name : exitButton_Click
         * Disc : closes the application
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Name : newFileButton_Click
         * Disc : clears the current screen to allow the user to start on a fresh design
        */
        private void newFileButton_Click(object sender, EventArgs e)
        {
            dialogEraseDrawing = MessageBox.Show("You will lose all unsaved progress!", "Erase Drawing?", MessageBoxButtons.YesNo);
            if (dialogEraseDrawing == DialogResult.Yes)
            {
                ShapeList.Clear();
            }
            else if (dialogEraseDrawing == DialogResult.No)
            {
            }
            drawArea.Invalidate();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveWindow.ShowDialog();

            System.IO.File.WriteAllText(saveWindow.FileName, "");

            using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter(saveWindow.FileName, true))
            {
                foreach (Shape shape in ShapeList)
                {
                    dataFile.WriteLine(shape.ToString());
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openWindow.ShowDialog();

            string[] lines = System.IO.File.ReadAllLines(openWindow.FileName);

            foreach (string line in lines)
            {
                tempShape.FromString(line);
                ShapeList.Add(new Shape(tempShape));
            }

            drawArea.Invalidate();
        }
    }
}
