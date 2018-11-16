using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        Color CurColor = Color.Black;
        bool Pressed = false;
        Point CurPoint;
        Point PrevPoint;
        Graphics Graph;

        public Paint()
        {
            InitializeComponent();
            Graph = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                CurColor = colorDialog1.Color;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Pressed = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Pressed)
            {
                PrevPoint = CurPoint;
                CurPoint = e.Location;
                PaintPen();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Pressed = true;
            CurPoint = e.Location;
        }
        
        private void PaintPen()
        {
            Pen pen = new Pen(CurColor);
            Graph.DrawLine(pen, PrevPoint, CurPoint);
        }
    }
}
