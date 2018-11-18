
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CitrusPaint.Brush {
    public class LinePen : AbstractPen {
        Point? startPoint = null;
        Line line = null;

        SolidColorBrush color = Brushes.Black;


        override public void Draw(Canvas canvas, Point point) {

            if(startPoint == null) {
                startPoint = point;
                return;
            }
            if (line != null) canvas.Children.Remove(line);


            line = new Line {
                    X1 = startPoint.Value.X,
                    Y1 = startPoint.Value.Y,
                    X2 = point.X,
                    Y2 = point.Y,
                    StrokeStartLineCap = PenLineCap.Round,
                    StrokeEndLineCap = PenLineCap.Round,
                    Stroke = color
            };
            canvas.Children.Add(line);
           
        }

        public override void SetColor(Color color) {
            this.color = new SolidColorBrush(color);
        }
    }
}
