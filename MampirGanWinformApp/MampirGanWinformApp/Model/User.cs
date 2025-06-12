﻿using System;
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
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
    }
}
