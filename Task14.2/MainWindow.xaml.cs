using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Task14._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "Дані отримані";
        }
        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(4000);
            textBox1.Text = "Підключено до бази даних";
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 3);
            timer.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(4000);
            textBox1.Text = "Підключення завершено";
            timer.Stop();
        }
    }
}
