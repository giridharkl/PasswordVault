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
using System.Web.Security;

using PasswordVault.ViewModels;
using PasswordVault.Models;

namespace PasswordVault
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            Vault vault = new Vault();
            mainViewModel = new MainViewModel(vault);
            mainViewModel.AppTitle = Constants.AppTitle;
            mainViewModel.VaultRows = SQLiteDataAccess.LoadVault();
            this.DataContext = mainViewModel;
        }

        private void RibbonMenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void AutoPassword_Checked(object sender, RoutedEventArgs e)
        {
            mainViewModel.Password = generatePassword(12);
        }

        private String generatePassword(int len)
        {
            return Membership.GeneratePassword(len, 1);
        }

        private void VaultRows_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Vault vaultRow = dg.SelectedItem as Vault;
            if(vaultRow != null)
            {
                EditVaultRow(vaultRow, this.mainViewModel);
            }
        }

        private void EditVaultRow(Vault vault, MainViewModel viewModel)
        {
            try
            {
                viewModel.Id = vault.Id;
                viewModel.Url = vault.Url;
                viewModel.Username = vault.Username;
                viewModel.Password = vault.Password;
                viewModel.Passphrase = vault.Passphrase;
                viewModel.Email = vault.Email;
                viewModel.Phone = vault.Phone;
                viewModel.Comments = vault.Comments;
            }
            catch(Exception e)
            {

            }
            
        }
    }
}
