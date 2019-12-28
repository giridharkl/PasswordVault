using PasswordVault.ViewModels;
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

namespace PasswordVault
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        LoginViewModel loginViewModel;
        public Login()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            this.DataContext = loginViewModel;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(authenticate())
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnForgotPw_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool authenticate()
        {
            string _user = this.txtUsername.Text;
            string _pass = this.txtPassword.Password;

            return true;
        }
    }
}
