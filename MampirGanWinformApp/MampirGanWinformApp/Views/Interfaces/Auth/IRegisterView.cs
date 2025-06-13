using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Views.Interfaces.Auth
{
    interface IRegisterView
    {
        string Email { get; }
        string Username { get; }
        string Password { get; }
        void NavigateToLogin();
    }
}
