using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace CitrusPaint {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {


        List<Brush.AbstractPen> figures = new List<Brush.AbstractPen>();
        private string selectedTool;
        Dictionary<string, Type> tools = new Dictionary<string, Type>();
        Color color = Color.FromRgb(0,0,0);


        public MainWindow() {
            InitializeComponent();
            ReleaseMouseCapture();

            tools.Add("Pen", typeof(Brush.Pen));
            tools.Add("Line", typeof(Brush.LinePen));

            selectedTool = "Pen";
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {

            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed && figures.Count>0) {
                figures.Last().Draw(canvas, e.GetPosition(canvas));
            }

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e) {
            figures.Add(
                Activator.CreateInstance(
                    tools[selectedTool]) as Brush.AbstractPen);

            figures.Last().SetColor(color);

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            selectedTool = (sender as Button).Tag.ToString();
        }

        private void ColorChange(object sender, RoutedPropertyChangedEventArgs<double> e) {

            Slider slider = e.OriginalSource as Slider;
            if (slider.Name.ToString() == "sliderRed") color.R = (byte)e.NewValue;
            if (slider.Name.ToString() == "sliderGreen") color.G = (byte)e.NewValue;
            if (slider.Name.ToString() == "sliderBlue") color.B = (byte)e.NewValue;

            colorIndicator.Fill = new SolidColorBrush(color);
        }
    }
}
