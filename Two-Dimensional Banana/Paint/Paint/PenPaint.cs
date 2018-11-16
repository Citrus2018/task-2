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
        Graphics Graphs;

        public Paint()
        {
            InitializeComponent();
            Graphs = panel1.CreateGraphics();
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
            Graphs.DrawLine(pen, PrevPoint, CurPoint);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if ((letter < 'А' || letter > 'я') && (letter < 'A' || letter > 'z') && (letter > '9' || letter < '0') )
            {
                e.Handled = true;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char) Keys.Back)
                {
                    if (textBox1.Text.Length > 0)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    }
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }

        }
    }
}
