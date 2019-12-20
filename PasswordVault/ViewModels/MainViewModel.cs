using PasswordVault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private string _appTitle;
        private List<Vault> _vaultRows;

        public string AppTitle
        {
            get { return _appTitle; }
            set { 
                _appTitle = value;
                NotifyPropertyChanged("Title"); 
            }
        }

        public List<Vault> VaultRows { get => _vaultRows; set => _vaultRows = value; }
    }
}
