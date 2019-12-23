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
        private int _id;
        private string _url;
        private string _username;
        private string _password;
        private string _email;
        private string _phone;
        private string _passphrase;
        private string _comments;
        private Vault _vault;

        public MainViewModel(Vault vault)
        {
            _vault = vault;
        }
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

        public string Password
        {
            get => _vault.Password;
            set 
            { 
                if(string.Equals(_vault.Password, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Password = value;
                NotifyPropertyChanged(null);
            }
        }

        public string Url { get => _vault.Url;
            set {
                if (string.Equals(_vault.Url, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Url = value;
                NotifyPropertyChanged("Url");
            }
        }

        public string Username { get => _vault.Username;
            set {
                if (string.Equals(_vault.Username, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Username = value;
                NotifyPropertyChanged("Username");
            }
        }

        public string Email
        {
            get => _vault.Email;
            set
            {
                if (string.Equals(_vault.Email, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Email = value;
                NotifyPropertyChanged("Email");
            }
        }

        public string Phone { get => _vault.Phone;
            set
            {
                if (string.Equals(_vault.Phone, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Phone = value;
                NotifyPropertyChanged("Phone");
            }
        }

        public string Passphrase { get => _vault.Passphrase;
            set
            {
                if (string.Equals(_vault.Passphrase, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Passphrase = value;
                NotifyPropertyChanged("Passphrase");
            }
        }

        public int Id { get => _vault.Id;
            set
            {
                if (_vault.Id == value)
                {
                    return;
                }
                _vault.Id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public string Comments { get { return _vault.Comments; }
            set
            {
                if (string.Equals(_vault.Comments, value, StringComparison.CurrentCulture))
                {
                    return;
                }
                _vault.Comments = value;
                NotifyPropertyChanged("Comments");
            }
        }

        private String generatePassword(int len)
        {
            return Membership.GeneratePassword(len, 1);
        }
    }
}
