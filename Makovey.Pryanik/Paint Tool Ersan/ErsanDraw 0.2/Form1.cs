using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErsanDraw_0._2
{
    public partial class Form1 : Form
    {
        bool draw, choose, toggle=true;
        Color CurrentColor = Color.Black;
        string toolname = "pen"; 
        int x1, y1, x2, y2;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = PaintList.CreateGraphics();
        }
        private void ColourDisplayToogle_Click(object sender, EventArgs e)
        {
            if (toggle)
            {
                toggle =false;
                ButtonOfColour.Visible = true;
                ElipseOfColour.Visible = false;
             }
            else
            {
                toggle = true;
                ButtonOfColour.Visible = false;
                ElipseOfColour.Visible = true;

            }
        }

            private void ElipseOfColour_MouseDown(object sender, MouseEventArgs e)
            {
                choose = true;
                Bitmap bmp = (Bitmap)ElipseOfColour.Image.Clone();
                DisplayOfColour.BackColor = bmp.GetPixel(e.X, e.Y);
            }
            private void ElipseOfColour_MouseUp(object sender, MouseEventArgs e)
            {
             choose = false;
             CurrentColor = DisplayOfColour.BackColor;
            }
            private void ElipseOfColour_MouseMove(object sender, MouseEventArgs e)
            {
                if (choose)
                {
                this.ElipseOfColour_MouseDown(sender, e);
                }
            }

        private void NewListButton_Click(object sender, EventArgs e)
        {
            PaintList.Refresh();
        }
        private void ToolPen_Click(object sender, EventArgs e)
        {
            toolname = "Pen";
        }

        private void ButtonOfColour_Click(object sender, EventArgs e)
        {
                DialogResult D = colorDialog1.ShowDialog();
                if (D == System.Windows.Forms.DialogResult.OK)
                    CurrentColor = colorDialog1.Color;
                DisplayOfColour.BackColor = CurrentColor;
        }

        private void ToolLine_Click(object sender, EventArgs e)
        {
            toolname = "line";
        }

        private void PaintList_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x1 = e.X; y1= e.Y;
        }
        private void PaintList_MouseMove(object sender, MouseEventArgs e)
        {
            if (toolname == "pen")
            {
                Graphics g = PaintList.CreateGraphics();
                if (draw)
                {
                    x2 = x1; y2 = y1;
                    x1 = e.X; y1 = e.Y;
                    paint_simple();
                }
            }
            if (toolname =="line")
                if (draw)
                {
                    x2 = e.X; y2 = e.Y;
                    paint_simple();
                }
        }
        private void PaintList_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void paint_simple()
        {
            Pen p = new Pen(CurrentColor);
            g.DrawLine(p, x1,y1,x2,y2);
        }

        
    }
}
