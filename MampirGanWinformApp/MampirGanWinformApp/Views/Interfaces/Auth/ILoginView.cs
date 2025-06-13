using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Views.Interfaces.Auth
{
    interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        
    }
}
