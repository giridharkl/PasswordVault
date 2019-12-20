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

using PasswordVault.ViewModels;

namespace PasswordVault
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            MainViewModel mainViewModel = new MainViewModel();
            mainViewModel.AppTitle = Constants.AppTitle;
            mainViewModel.VaultRows = SQLiteDataAccess.LoadVault();
            this.VaultRows.ItemsSource = mainViewModel.VaultRows;
            //this.DataContext = mainViewModel;
        }

        private void RibbonMenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
