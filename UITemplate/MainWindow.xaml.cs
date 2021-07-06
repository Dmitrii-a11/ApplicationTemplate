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

namespace UITemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            //CloseMenuButton.Visibility = Visibility.Visible;
            //OpenMenuButton.Visibility = Visibility.Hidden;
        }

        private void CloseMenuButton_Click(object sender, RoutedEventArgs e)
        {
            //OpenMenuButton.Visibility = Visibility.Visible;
            //CloseMenuButton.Visibility = Visibility.Hidden;
        }
    }
}
