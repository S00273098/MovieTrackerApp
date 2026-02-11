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

namespace MovieTrackerApp
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }
        private void WantToWatch_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow(0);
        }

        private void Watching_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow(1);
        }

        private void Watched_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow(2);
        }

        private void OpenMainWindow(int tabIndex)
        {
            MainWindow main = new MainWindow(tabIndex);
            main.Show();
            this.Close();
        }
    }
}
