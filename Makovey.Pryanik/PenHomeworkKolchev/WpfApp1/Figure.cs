using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    class Figure
    {
        private List<Point> Coordinates;

        public Figure()
        {
            InitList();
        }

        private void InitList()
        {
            Coordinates = new List<Point>();
        }

        public Figure(Point aPoint) : this()
        {
            Coordinates.Add(aPoint);
        }

        public void Draw(UIElementCollection p)
        {
            for (int i = 0; i < Coordinates.Count - 1; i++)
            {
                System.Windows.Shapes.Line line = new System.Windows.Shapes.Line()
                {
                    X1 = Coordinates[i].X,
                    Y1 = Coordinates[i].Y,
                    X2 = Coordinates[i + 1].X,
                    Y2 = Coordinates[i + 1].Y,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                };
                p.Add(line);
            }
        }

        public void AddPoint(Point aPoint)
        {
            Coordinates.Add(aPoint);
        }
    }
}
