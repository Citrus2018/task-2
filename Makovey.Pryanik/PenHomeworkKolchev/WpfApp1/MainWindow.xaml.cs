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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Figure> figures;

        public MainWindow()
        {
            InitializeComponent();
            figures = new List<Figure>();
        }
        private void Invalidate()
        {
            Canvas.Children.Clear();
            foreach (var figure in figures)
                figure.Draw(Canvas.Children);
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                figures.Last().AddPoint(e.GetPosition((IInputElement)sender));
                Invalidate();
            }
        }
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            figures.Add(new Figure(e.GetPosition((IInputElement)sender)));
            Invalidate();
        }
        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Invalidate();
        }
    }
}
