using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
//using System.Drawning;
//using System.Windows.Forms;

namespace Paint

{
   
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // uint sColor = 0xFF000000;
        private Point prev;
        public Point FirstPointOfLine;
        public Point SecondPointOfLine;
        public SolidColorBrush FirstColor = new SolidColorBrush(Colors.Black);
        private bool isPaint = false;
        public string sCheck="Pen";
        private const int SIZE = 2;
      

        public MainWindow()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void SomeButton(object sender, RoutedEventArgs e)
        {
            
            switch((sender as Button).Content.ToString())
            {
                case "CLearAll":
                    canvas.Children.Clear();
                    break;
                case "Line":
                    sCheck = "Line";
                    break;
                case "Pen":
                    sCheck = "Pen";
                    break;
                case "Ficha":
                    sCheck = "Ficha";
                    break;
                case "Color":
                    System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
                    if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Drawing.Color color1 = colorDialog.Color;
                        Color color = Colors.Red;
                        color.A = color1.A;
                        color.R = color1.R;
                        color.G = color1.G;
                        color.B = color1.B;
                        FirstColor = new SolidColorBrush(color);
                    }
                    break;
                case "WTF":/*
                    Color color = Colors.Red;
                    color.A = color1.A;
                    color.R = color1.R;
                    color.G = color1.G;
                    color.B = color1.B;
                    FirstColor = new SolidColorBrush(color);
                    */
                    break;
                case "Rectangle":
                    sCheck="Rectangle";
                    
                    break;
                default:
                    break;

            }
        }     

        public void Color_Click(object sender, RoutedEventArgs e)
        {
                
        }

        private void MouseMove(object sender, MouseEventArgs e) 
        {

            switch (sCheck)
            {
                case "Pen":
                    if (!isPaint) return;
                    var point = Mouse.GetPosition(canvas);
                    var line = new Line
                    {
                        Stroke = FirstColor,
                        StrokeThickness = SIZE,
                    };

                    if ((point.X < 680 - 6) && (point.Y < 366 - 6) && (point.X > 0) && (point.Y > 0) && (Mouse.LeftButton != 0))
                    {
                        line.X1 = prev.X;
                        line.Y1 = prev.Y;
                        line.X2 = point.X;
                        line.Y2 = point.Y;
                        canvas.Children.Add(line);
                    }
                    else
                    {
                        if ((point.X < 680 - 6) && (point.Y < 366 - 6) && (point.X > 0) && (point.Y > 0) && (Mouse.LeftButton == 0))
                        {
                            line.X1 = point.X;
                            line.Y1 = point.Y;
                            line.X2 = point.X;
                            line.Y2 = point.Y;
                            canvas.Children.Add(line);}
                    }
                    prev = point;
                    break;
                case "Ficha":
                    if (!isPaint) return;
                    var NewPoint = Mouse.GetPosition(canvas);
                    var NewLine = new Line
                    {
                        Stroke = FirstColor,
                        StrokeThickness = SIZE,
                        X1 = prev.X,
                        X2 = NewPoint.X,
                        Y1 = prev.Y,
                        Y2 = NewPoint.Y,


                    };
                    canvas.Children.Add(NewLine);
            
            break;
                case "Rectangle":
                    sCheck = "Rectangle";
                    break;
            }
        }

        public void MouseDown(object sender, MouseButtonEventArgs e)
        {            
            if (isPaint) return;
            isPaint = true;
            prev = Mouse.GetPosition(canvas);
            var dot = new Ellipse { Width = SIZE, Height = SIZE, Fill = FirstColor };
            dot.SetValue(Canvas.LeftProperty, prev.X);
            dot.SetValue(Canvas.TopProperty, prev.Y);
            canvas.Children.Add(dot);
            FirstPointOfLine = prev;
        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {        
            isPaint = false;            
            SecondPointOfLine = Mouse.GetPosition(canvas);
            if ((sCheck=="Line")&&(Mouse.LeftButton==0))
            {                
                Line SuperNewLine = new Line
                {
                    Stroke = FirstColor,
                    StrokeThickness = SIZE,
                    X1 = FirstPointOfLine.X,
                    X2 = Mouse.GetPosition(canvas).X,
                    Y1 = FirstPointOfLine.Y,
                    Y2 = Mouse.GetPosition(canvas).Y,
                };
                FirstPointOfLine = prev;
                canvas.Children.Add(SuperNewLine);
            }
            if ((sCheck == "Rectangle") && (Mouse.LeftButton == 0))
            {
                Line FirstLineOfRectanglee = new Line
                {
                    Stroke = FirstColor,
                    StrokeThickness = SIZE,
                    X1 = FirstPointOfLine.X,
                    X2 = Mouse.GetPosition(canvas).X,
                    Y1 = FirstPointOfLine.Y,
                    Y2 = FirstPointOfLine.Y,
                };
               
               canvas.Children.Add(FirstLineOfRectanglee);
                Line FirstLineOfRectanglee2 = new Line
                {
                    Stroke = FirstColor,
                    StrokeThickness = SIZE,
                    X1 = FirstPointOfLine.X,
                    X2 = Mouse.GetPosition(canvas).X ,
                    Y1 =  Mouse.GetPosition(canvas).Y,
                    Y2 =  Mouse.GetPosition(canvas).Y,
                };

                Line SecondLine = new Line
               {
                   Stroke = FirstColor,
                   StrokeThickness = SIZE,
                   X1 = FirstPointOfLine.X,
                   X2 = FirstPointOfLine.X,
                   Y1 = FirstPointOfLine.Y,
                   Y2 = Mouse.GetPosition(canvas).Y,
               };
                
                Line SecondLine2 = new Line
                {
                    Stroke = FirstColor,
                    StrokeThickness = SIZE,
                    X1 = Mouse.GetPosition(canvas).X,
                    X2 = Mouse.GetPosition(canvas).X,
                    Y1 = FirstPointOfLine.Y,
                    Y2 = Mouse.GetPosition(canvas).Y,
                };

                FirstPointOfLine = prev;
                 canvas.Children.Add(SecondLine);
               canvas.Children.Add(FirstLineOfRectanglee2);
                 canvas.Children.Add(SecondLine2);

            }
        }

        private void wtf(object sender, RoutedEventArgs e)
        {
           

        }
    }
}
