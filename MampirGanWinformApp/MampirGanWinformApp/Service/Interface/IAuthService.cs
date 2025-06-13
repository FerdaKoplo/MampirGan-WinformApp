using MampirGanWinformApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampirGanWinformApp.Service.Interface
{
     public interface IAuthService
    {
        bool Register(string email, string username, string password);
        User? Login(string username, string password);
    }
}
