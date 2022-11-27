using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

using System.Windows.Threading;     // timer

namespace Lesson_AddRemoveObjects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Rectangle> rectangles = new List<Rectangle>();

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void MyCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source is Canvas)  // is - проверка является ли объект типом данных
            {
                double x = Mouse.GetPosition(MyCanvas).X;
                double y = Mouse.GetPosition(MyCanvas).Y;
                //MessageBox.Show(x.ToString());

                Rectangle rectangle = new Rectangle();
                rectangle.Fill = Brushes.BlueViolet;
                rectangle.Width = 50;
                rectangle.Height = 50;

                Canvas.SetLeft(rectangle, x - rectangle.Width / 2);
                Canvas.SetTop(rectangle, y - rectangle.Height / 2);

                rectangles.Add(rectangle);  // new

                MyCanvas.Children.Add(rectangle);
            }
            else
            {
                MyCanvas.Children.Remove((Rectangle)e.Source);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rectangles.Count; i++)
            {
                double x = Canvas.GetLeft(rectangles[i]);
                Canvas.SetLeft(rectangles[i], x + 5);
            }
        }
    }
}
