using System.Drawing;
using System.Windows.Forms;

namespace PenHomework
{
    public partial class Form1 : Form
    {
        bool draw = false;
        string painttool = "pen";
        Color currentColor = Color.Black;
        Graphics g;
        Point prevPoint, currPoint;

        public Form1()
        { 
            InitializeComponent();
            g = Canvas.CreateGraphics();
        }

        private void ButtonClear_MouseClick(object sender, MouseEventArgs e)
        {
            g.Clear(Canvas.BackColor);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            currPoint = e.Location;
            if ((painttool == "line") || (painttool == "rectangle"))
            {
                prevPoint = e.Location;
            }
        }

        private void ButtonPen_MouseClick(object sender, MouseEventArgs e)
        {
            painttool = "pen";
        }

        private void ButtonLine_MouseClick(object sender, MouseEventArgs e)
        {
            painttool = "line";
        }

        private void ButtonEraser_MouseClick(object sender, MouseEventArgs e)
        {
            painttool = "eraser";
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {   if (painttool == "pen")
                {
                    prevPoint = currPoint;
                    currPoint = e.Location;
                    paint();
                }

                if (painttool == "NotBugButAFeature")
                {
                    currPoint = e.Location;
                    paint();
                }

                if (painttool == "eraser")
                {
                    currentColor = Canvas.BackColor;
                    prevPoint = currPoint;
                    currPoint = e.Location;
                    paint();
                }

            }
        }

        private void ButtonColorChooser_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
                currentColor = colorDialog1.Color;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (painttool == "line")
            {
                currPoint = e.Location;
                paint();
            }

            if (painttool == "rectangle")
            {
                currPoint = e.Location;
                Pen p = new Pen(currentColor);
                int height = System.Math.Abs(prevPoint.Y - currPoint.Y);
                int width = System.Math.Abs(prevPoint.X - currPoint.X);
                g.DrawRectangle(p, prevPoint.X, prevPoint.Y, width, height);
            }
            prevPoint = currPoint;
            currPoint = e.Location;
            draw = false;
        }

        private void ButtonBugFeature_MouseClick(object sender, MouseEventArgs e)
        {
            painttool = "NotBugButAFeature";
        }

        private void ButtonRectangle_MouseClick(object sender, MouseEventArgs e)
        {
            painttool = "rectangle";
        }

        private void paint()
        {
            Pen p = new Pen(currentColor);
            g.DrawLine(p, prevPoint, currPoint);
        }
    }
}
