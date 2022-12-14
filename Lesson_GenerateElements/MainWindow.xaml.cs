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

namespace Lesson_AddRemoveObjects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

                MyCanvas.Children.Add(rectangle);
            }
            else
            {
                MyCanvas.Children.Remove((Rectangle)e.Source);
            }
        }
    }
}
