using PasswordVault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace PasswordVault.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private string _appTitle;
        private List<Vault> _vaultRows;
        private bool _autoPassword;
        private string _password;

        public string AppTitle
        {
            get { return _appTitle; }
            set { 
                _appTitle = value;
                NotifyPropertyChanged("Title"); 
            }
        }

        public List<Vault> VaultRows { get => _vaultRows; set => _vaultRows = value; }
        public bool AutoPassword { 
            get => _autoPassword; 
            set 
            { 
                _autoPassword = value;
                _password = generatePassword(12);
            } 
        }

        public string Password { get => _password; set => _password = value; }

        private String generatePassword(int len)
        {
            return Membership.GeneratePassword(len, 1);
        }
    }
}
