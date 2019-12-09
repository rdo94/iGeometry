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
using System.Windows.Shapes;
using iGeometry_Model;

namespace iGeometry
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        #region WindowFields
        User activeUser = null;
        Stack<Window> activeWindows = new Stack<Window>();
        #endregion

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginUser()
        {
            activeUser = new User()
            {
                Email = tbEmail.Text,
                Password = pbPassword.Password.ToString()
            };
        }

        private void RegisterUser()
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterUser();
        }

        private void BtnToMainPortal_Click(object sender, RoutedEventArgs e)
        {
            MainPortal portal = new MainPortal();
            activeWindows.Push(portal);

            portal.Show();

            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
