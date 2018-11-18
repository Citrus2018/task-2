using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CitrusPaint.Brush {
    public class Pen : AbstractPen {
        Polyline polyline;
        bool first = true;

        public Pen() {
            polyline = new Polyline();
            polyline.StrokeThickness = 1;
            polyline.FillRule = FillRule.EvenOdd;
            polyline.Stroke = Brushes.Black;
        }


        override public void Draw(Canvas canvas, Point point) {
            
            polyline.Points.Add(point);


            if (first) {
                canvas.Children.Add(polyline);
                first = false;
            }
        }

        public override void SetColor(Color color) {
            polyline.Stroke = new SolidColorBrush(color);
        }
    }
}
