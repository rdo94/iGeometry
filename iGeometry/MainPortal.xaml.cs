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

namespace iGeometry
{
    /// <summary>
    /// Interaction logic for MainPortal.xaml
    /// </summary>
    public partial class MainPortal : Window
    {
        #region WindowFields

        #endregion

        public MainPortal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sideNav.Visibility == System.Windows.Visibility.Collapsed)
            {
                sideNav.Visibility = System.Windows.Visibility.Visible;
                (sender as Button).Content = "<";
            }
            else
            {
                sideNav.Visibility = System.Windows.Visibility.Collapsed;
                (sender as Button).Content = ">";
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
