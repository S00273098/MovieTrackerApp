using MovieTrackerApp.Commands;
using MovieTrackerApp.Models;
using MovieTrackerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(int selectedTabIndex)
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private MainViewModel ViewModel => (MainViewModel)DataContext;
        private void BtnWantToWatch_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedTabIndex = 0;
        }

        private void BtnWatching_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedTabIndex = 1;
        }

        private void BtnWatched_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedTabIndex = 2;
        }
    }
}
