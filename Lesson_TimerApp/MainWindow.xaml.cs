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

using System.Diagnostics;       // Debug Console
using System.Windows.Threading;   // For timer

namespace Lesson_PlatformerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // fields
        private bool bLeft;
        private bool bRight;

        private int drop = 10;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // gravity
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                bLeft = true;
            }
            else if (e.Key == Key.D)
            {
                bRight = true;
            }

            Debug.WriteLine("bLeft: " + bLeft + ", bRight: " + bRight);
        }

        private void Canvas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                bLeft = false;
            }
            else if (e.Key == Key.D)
            {
                bRight = false;
            }

            Debug.WriteLine("bLeft: " + bLeft + ", bRight: " + bRight);
        }
    }
}
