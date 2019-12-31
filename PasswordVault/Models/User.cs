using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault.Models
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private string _deleted;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Deleted { get => _deleted; set => _deleted = value; }
    }
}
