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
using IotDeviceManager.ViewModels;

namespace IotDeviceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
        private void OpenAddDeviceWindow(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddDeviceWindow(); 
            addWindow.Owner = this;
            addWindow.ShowDialog(); 
        }

        private void OpenLogPage(object sender, RoutedEventArgs e)
        {
            LogPage logWindow = new LogPage();
            logWindow.Owner = this;
            logWindow.ShowDialog();
        }
    }
}
