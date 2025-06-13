using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Model
{
    public enum UserRole {
        Admin,
        Customer
    }

    public class User
    {
        public int UserID { get; set; }
        public required string email { get; set; }
        public required string username { get; set; }
        public required string password { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
    }
}
