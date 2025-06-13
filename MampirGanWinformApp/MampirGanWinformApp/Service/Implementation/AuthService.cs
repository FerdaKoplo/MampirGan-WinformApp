using MampirGanWinformApp.Model;
using MampirGanWinformApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Service.Implementation
{
    public class AuthService : IAuthService
    {
        private List<User> _users = new();

        public bool Register(string email, string username, string password)
        {
            if (_users.Any(u => u.email == email || u.username == username))
                return false;

            _users.Add(new User { email = email, username = username, password = password });
            return true;
        }

        public User? Login(string username, string password)
        {
            return _users.FirstOrDefault(u => u.username == username && u.password == password);
        }
    }
}
