using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault.Models
{
    public class Vault
    {
        private int _id;
        private string _url;
        private string _username;
        private string _password;
        private string _email;
        private string _phone;
        private string _passphrase;
        private string _comments;

        public int Id { get => _id; set => _id = value; }
        public string Url { get => _url; set => _url = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Passphrase { get => _passphrase; set => _passphrase = value; }
        public string Comments { get => _comments; set => _comments = value; }
    }
}
